using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracaInzynierska.Helpers;
using System.IO;
using ExcelDataReader;
using System.Text.RegularExpressions;

namespace PracaInzynierska.Controls
{
    public partial class WeatherControl : UserControl
    {
        private const string ERROR_FILE_SAVE = "Błąd: Nie można zapisać pliku. ";
        private const string ERROR_FILE_OPEN = "Błąd: Nie można otworzyć pliku. ";
        private const string WARRNING_NOT_SELECTED_POINTS = "UWAGA: Nie zaznaczono żadnej lokalizacji.";
        private const string WARRNING_NOT_SELECTED_PATH = "UWAGA: Nie wyznaczono żadnego folderu z plikami.";
        private const string WARRNING_FOLDER_NOT_EXIST = "UWAGA: Wyznaczony folder, który nie istnieje.";
        private const int WEATHER_COLUMNS_COUNT = 7;
        private const int FILE_SUBSTRING_NUMBER = 9;
        private const int FILE_SUBSTRING_LENGTH_NUMBER = 3;
        private DataTable newDataTable;
        private DataTable modifiedDataTable;
        private DataTable dataSource;
        private int turbinCounter = 0;
        private int parametersCounter = 0;
        private int radioButtonChangeCounter = 0;
        private List<int> localizationsList = new List<int>();
        private List<int> selectedLocal = new List<int>();
        private int gCounter = 0;
        private DateTime[] changingDates = { new DateTime(2012,03,25,2,0,0) , new DateTime(2012,03,25,3,0,0),
                                             new DateTime(2013,03,31,2,0,0) , new DateTime(2013,03,31,3,0,0),
                                             new DateTime(2014,03,30,2,0,0) , new DateTime(2014,03,30,3,0,0)};
        private string[] columnsName = { "Data", "PS", "QV10M", "T10M", "V10M", "ϕ10M", "V50M", "ϕ50M", "Vx", "Px" };

        #region konstruktor
        public WeatherControl()
        {
            InitializeComponent();
            this.splitContainer1.SplitterDistance = this.splitContainer1.Size.Width / 2;
            
            //dgvWeatherResults.DataSource = modifiedDataTable = GlobalMeasurements.GlobalModifiedDataTable;
            //if (dgvWeatherResults.DataSource != null)
            //{
            //    SetColumnsToThreeDecimalPlaces();
            //    ShowElementsAfterLoad();
            //}
            

        }
        #endregion


        #region zdarzenia
        private void btnLoad_Click(object sender, EventArgs e)
        {
            string globalFileName = "";
            try
            {
                if (Validation())
                {
                    this.Cursor = Cursors.WaitCursor;
                    string[] filesPath = Directory.GetFiles(fbdCsv.SelectedPath);
                    bool isFirst = true;
                    int fileCounter = 0;
                    DateTime dateTimeFrom = new DateTime(dtpDateFrom.Value.Year, dtpDateFrom.Value.Month, dtpDateFrom.Value.Day, dtpTimeFrom.Value.Hour, 0, 0);
                    DateTime dateTimeTo = new DateTime(dtpDateTo.Value.Year, dtpDateTo.Value.Month, dtpDateTo.Value.Day, dtpTimeTo.Value.Hour, 0, 0);
                    selectedLocal = new List<int>();
                    dataSource = null;

                    foreach (string filePath in filesPath)
                    {
                        string fileName = globalFileName = Path.GetFileName(filePath);
                        int localization = int.Parse(fileName.Substring(FILE_SUBSTRING_NUMBER, FILE_SUBSTRING_LENGTH_NUMBER));
                        for (int i = 0; i < lbPointsLocation.SelectedItems.Count; i++)
                        {
                            selectedLocal.Add(Int32.Parse(lbPointsLocation.SelectedItems[i].ToString()));
                        }
                        if (selectedLocal.Contains(localization))
                        {
                            FileStream fileStream = File.Open(filePath, FileMode.Open, FileAccess.Read);
                            DataTable table = new DataTable();
                            bool isColumnCreated = false;


                            using (StringReader reader = new StringReader(new StreamReader(fileStream, Encoding.Default).ReadToEnd()))
                            {
                                int counter = 0;
                                while (reader.Peek() != -1)
                                {
                                    string line = reader.ReadLine();

                                    counter++;
                                    if (line == null || line.Length == 0)
                                        continue;

                                    string[] values = line.Split(';');

                                    if (!isColumnCreated)
                                    {
                                        for (int i = 0; i < values.Count(); i++)
                                        {
                                            if (i == 0)
                                                table.Columns.Add(columnsName[i], typeof(DateTime));
                                            else
                                                table.Columns.Add(columnsName[i] + "(" + localization + ")", typeof(double));
                                        }
                                        if (cbSpeedAndPower.Checked)
                                        {
                                            table.Columns.Add(columnsName[values.Count()] + "(" + localization + ")", typeof(double));
                                            table.Columns.Add(columnsName[values.Count() + 1] + "(" + localization + ")", typeof(double));
                                        }
                                        isColumnCreated = true;
                                    }
                                    DateTime rowDateTime = ConvertDateTime(values[0]);
                                    if ((!cbDateTimeFrom.Checked && !cbDateTimeTo.Checked) ||
                                        (cbDateTimeFrom.Checked && !cbDateTimeTo.Checked && rowDateTime >= dateTimeFrom) ||
                                        (cbDateTimeTo.Checked && !cbDateTimeFrom.Checked && rowDateTime <= dateTimeTo) ||
                                        (cbDateTimeFrom.Checked && cbDateTimeTo.Checked && rowDateTime >= dateTimeFrom && rowDateTime <= dateTimeTo))
                                    {
                                        table.Rows.Add(SetDataRowWithValues(table.NewRow(), values, isFirst));
                                    }
                                }
                                isFirst = false;
                            }
                            fileStream.Close();
                            if (dataSource == null)
                                dataSource = table;
                            else if (fileCounter > 0)
                            {
                                int startNumber = 1;
                                if (fileCounter % lbPointsLocation.SelectedItems.Count == 0)
                                    startNumber = 0;

                                for (int i = startNumber; i < table.Columns.Count; i++)
                                {
                                    if (fileCounter < lbPointsLocation.SelectedItems.Count)
                                        dataSource.Columns.Add(table.Columns[i].ColumnName, table.Columns[i].DataType);
                                    for (int j = 0; j < table.Rows.Count; j++)
                                    {
                                        if (i == 0)
                                        {
                                            dataSource.Rows.Add(dataSource.NewRow());
                                        }
                                        dataSource.Rows[fileCounter < lbPointsLocation.SelectedItems.Count ? j :
                                            fileCounter % lbPointsLocation.SelectedItems.Count == 0 ? i == 0 ? dataSource.Rows.Count - 1 : dataSource.Rows.Count - table.Rows.Count + j :
                                            dataSource.Rows.Count - table.Rows.Count + j].SetField(table.Columns.Count * (fileCounter % lbPointsLocation.SelectedItems.Count) + i - startNumber, table.Rows[j].ItemArray[i]);
                                    }
                                }
                            }
                            fileCounter++;
                            dgvWeatherResults.DataSource = dataSource;
                        }
                    }
                    parametersCounter = (dgvWeatherResults.Columns.Count - 1) / lbPointsLocation.SelectedItems.Count;
                    ShowWeatherElements();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ERROR_FILE_OPEN + " Ścieżka do pliku: " + globalFileName + " " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnLoadFolder_Click(object sender, EventArgs e)
        {
            if (fbdCsv.ShowDialog() == DialogResult.OK)
            {
                string globalFileName = "";
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    string[] filesPath = Directory.GetFiles(fbdCsv.SelectedPath);
                    localizationsList = new List<int>();
                    tbFolderPath.Text = fbdCsv.SelectedPath;
                    lbPointsLocation.Items.Clear();
                    foreach (string filePath in filesPath)
                    {
                        string fileName = globalFileName = Path.GetFileName(filePath);
                        int localization = int.Parse(fileName.Substring(FILE_SUBSTRING_NUMBER, FILE_SUBSTRING_LENGTH_NUMBER));
                        if (!localizationsList.Contains(localization))
                        {
                            localizationsList.Add(localization);
                            lbPointsLocation.Items.Add(" " + localization);
                        }
                    }
                   
                    ShowElementsAfterLoad();
                }
                catch (Exception ex)
                {
                    throw new Exception(ERROR_FILE_OPEN + " Ścieżka do pliku: " + globalFileName + " " + ex.Message);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void btnGenerateCsv_Click(object sender, EventArgs e)
        {
            try
            {
                if (sfdCsv.ShowDialog() == DialogResult.OK)
                {

                    this.Cursor = Cursors.WaitCursor;
                    StringBuilder sb = new StringBuilder();
                    int columnCount = 0;
                    string cellValue = "";
                    foreach(DataGridViewColumn column in dgvWeatherResults.Columns.OfType<DataGridViewColumn>().OrderBy(x=>x.DisplayIndex))
                    {
                        
                        if (column.Visible && column.Name != "Lp.")
                        {
                            sb.Append(column.HeaderText);
                            if (columnCount < dgvWeatherResults.Columns.Count - 1)
                                sb.Append(';');
                        }
                        columnCount++;
                    }
                    //for (int i = 0; i < dgvMeasurementResults.Columns.Count; i++)
                    //{
                    //    if (dgvMeasurementResults.Columns[i].Visible)
                    //    {
                    //        sb.Append(dgvMeasurementResults.Columns[i].HeaderText);
                    //        if (i < dgvMeasurementResults.Columns.Count - 1)
                    //            sb.Append(';');
                    //    }
                    //}
                    sb.AppendLine();
                    for (int currentRow = 0; currentRow < dgvWeatherResults.Rows.Count; currentRow ++)
                    {
                        if (dgvWeatherResults.Rows[currentRow].Visible)
                        {
                            columnCount = 0;
                            //for (int i = 0; i < dgvMeasurementResults.Columns.Count-1; i++)
                            //{
                            foreach (DataGridViewColumn column in dgvWeatherResults.Columns.OfType<DataGridViewColumn>().OrderBy(x => x.DisplayIndex))
                            {   
                                if (column.Visible && column.Name != "Lp.")
                                {
                                    if (dgvWeatherResults.Rows[currentRow].Cells[column.Index].Value.ToString() == "99999")
                                        sb.Append("");
                                    else
                                    {
                                        if (column.Index > 1)
                                            cellValue = Math.Round((double)dgvWeatherResults.Rows[currentRow].Cells[column.Index].Value, 3).ToString();
                                        else
                                            cellValue = dgvWeatherResults.Rows[currentRow].Cells[column.Index].Value.ToString();
                                        //if (rbDot.Checked)
                                        //    sb.Append(cellValue.Replace(",", "."));
                                        //else
                                            sb.Append(cellValue);
                                    }
                                    if (columnCount < dgvWeatherResults.Columns.Count - 1)
                                        sb.Append(';');
                                }
                                columnCount++;
                            }
                            sb.AppendLine();
                        }
                    }

                    System.IO.File.WriteAllText(sfdCsv.FileName, sb.ToString(), System.Text.Encoding.UTF8);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ERROR_FILE_SAVE + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void rbCheckedChanged(object sender, EventArgs e)
        {
            ColumnReordering();
        }

        private void rbTime_CheckedChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < dgvWeatherResults.Rows.Count; i++)
            {
                DateTime newDateTime;
                if (rbLocalTime.Checked)
                    newDateTime = DateTime.Parse(dgvWeatherResults.Rows[i].Cells["Data"].Value.ToString()).ToLocalTime();
                else
                    newDateTime = DateTime.Parse(dgvWeatherResults.Rows[i].Cells["Data"].Value.ToString()).ToUniversalTime();                
                dgvWeatherResults.Rows[i].Cells["Data"].Value = newDateTime;
            }
        }
        #endregion

        #region metody
        private bool Validation()
        {
            if (string.IsNullOrEmpty(tbFolderPath.Text))
            {
                MessageBox.Show(WARRNING_NOT_SELECTED_POINTS);
                return false;
            }
            if (!Directory.Exists(tbFolderPath.Text))
            {
                MessageBox.Show(WARRNING_FOLDER_NOT_EXIST);
                return false;
            }
            if (lbPointsLocation.SelectedItems.Count == 0)
            {
                MessageBox.Show(WARRNING_NOT_SELECTED_POINTS);
                return false;
            }

            return true;
        }

        private void SetColumnsToThreeDecimalPlaces()
        {
            int columnNumber = 0;
            if (dgvWeatherResults.Columns[0].Name != "Lp.")
                columnNumber = 1;
            else
                columnNumber = 2;

            for (int currentColumn = columnNumber; currentColumn < dgvWeatherResults.Columns.Count; currentColumn++)
            {
                dgvWeatherResults.Columns[currentColumn].DefaultCellStyle.Format = "N3";
                dgvWeatherResults.Columns[currentColumn].DefaultCellStyle.NullValue = 99999;
            }
        }

        private DataTable ConvertTable(DataTable table)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                int turbinCount = turbinCounter;
                DataTable newTable = new DataTable("Etap2");

                for (int i = 2; i <= table.Columns.Count; i++)
                {

                    if (i - 1 < 2)
                    {
                        DataColumn column = new DataColumn();
                        column.ColumnName = table.Columns[i - 1].ColumnName;
                        column.DataType = table.Columns[i - 1].DataType;
                        newTable.Columns.Add(column);
                    }
                    else
                    {
                        for (int j = 0; j < turbinCount; j++)
                        {
                            DataColumn column = new DataColumn();
                            //column.ColumnName = table.Columns[i - 1].ColumnName + "(" + selectedTurbins[j] + ")";
                            column.DataType = table.Columns[i - 1].DataType;
                            newTable.Columns.Add(column);
                        }
                    }

                }
                //(DataTable)newTable;
                List<DataTable> dataTableList = new List<DataTable>();
                int turbinNumber = 0;
                int turbinNumberCounter = -1;

                newDataTable = table.Clone();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if ((int)table.Rows[i].Field<double>("Numer") != turbinNumber)
                    {
                        turbinNumber = (int)table.Rows[i].Field<double>("Numer");
                        turbinNumberCounter++;
                        if (dataTableList.Count < turbinNumber)
                            dataTableList.Add(table.Clone());
                    }
                    dataTableList[turbinNumberCounter].Rows.Add(table.Rows[i].ItemArray);
                }
                for (int i = 0; i < dataTableList[0].Rows.Count; i++)
                {
                    DataRow row = newTable.NewRow();
                    row[0] = dataTableList[0].Rows[i].Field<DateTime>(dataTableList[0].Columns[1].ColumnName);
                    for (int j = 0; j < table.Columns.Count - 2; j++)
                    {
                        for (int m = 0; m < turbinCount; m++)
                            row[m + (turbinCount * j) + 1] = dataTableList[m].Rows[i].Field<double>(dataTableList[m].Columns[j + 2].ColumnName);

                    }
                    newTable.Rows.Add(row);
                }

                return newTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void ColumnReordering()
        {
            if (rbLocalization.Checked)
            {
                int counter = 0;
                for (int i = 0; i < parametersCounter; i++)
                {
                    for (int j = 0; j < lbPointsLocation.SelectedItems.Count; j++)
                    {
                        counter++;
                        dgvWeatherResults.Columns[j * parametersCounter + i + 1].DisplayIndex = counter;
                    }
                }
            }
            else
            {
                for (int i = 1; i < dgvWeatherResults.Columns.Count; i++)
                {
                    dgvWeatherResults.Columns[i].DisplayIndex = dgvWeatherResults.Columns[i].Index;
                }
            }
            //for (int counter = 0; counter < dgvWeatherResults.RowCount; counter++)
            //{
            //    dgvWeatherResults.Rows[counter].Cells[0].Value = counter + 1;
            //}
        }

        private void DgvFiltration()
        {
            for (int i = 2; i < dgvWeatherResults.ColumnCount; i++)
            {
                dgvWeatherResults.Columns[i].Visible = false;
            }
            //for (int currentParameter = 0; currentParameter < lbParameters.SelectedItems.Count; currentParameter++)
            //{
            //    for (int currentTurbin = 0; currentTurbin < lbPointsLocation.SelectedItems.Count; currentTurbin++)
            //    {
            //        for (int currentColumn = 2; currentColumn < dgvWeatherResults.ColumnCount; currentColumn++)
            //        {
            //            if (dgvWeatherResults.Columns[currentColumn].HeaderText.Contains("X" + Int32.Parse(lbParameters.SelectedItems[currentParameter].ToString()) + "(" + Int32.Parse(lbPointsLocation.SelectedItems[currentTurbin].ToString()) + ")")|| currentColumn > lbParameters.Items.Count*lbPointsLocation.Items.Count)
            //                dgvWeatherResults.Columns[currentColumn].Visible = true;
            //        }
            //    }
            //}
        }

        private DataTable GetTableByDates()
        {
            DataTable newDataTable = null;
            BindingSource bs = new BindingSource();
            string filter = "";
            bs.DataSource = dgvWeatherResults.DataSource;
            DateTime dateFrom = ((DateTime)dtpDateFrom.Value).Date.Add(((DateTime)dtpTimeFrom.Value).TimeOfDay);
            DateTime dateTo = ((DateTime)dtpDateTo.Value).Date.Add(((DateTime)dtpTimeTo.Value).TimeOfDay);
            if (cbDateTimeFrom.Checked && !cbDateTimeTo.Checked)
                filter += String.Format("Data >= #{0}# ", dateFrom.ToString(System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat));
            else if (!cbDateTimeFrom.Checked && cbDateTimeTo.Checked)
                filter += String.Format("Data <= #{0}# ", dateTo.ToString(System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat));
            else if (cbDateTimeFrom.Checked && cbDateTimeTo.Checked)
                filter += String.Format("Data >= #{0}# AND Data <= #{1}# ", dateFrom.ToString(System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat), dateTo.ToString(System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat));

            bs.Filter = filter;
            newDataTable = (DataTable)bs.DataSource;
            return newDataTable;
        }

        private void SetYellowColorForEmptyCells(bool isWeather = false)
        {
            int columnsCount = 0;
            for (int currentRow = 0; currentRow < dgvWeatherResults.Rows.Count; currentRow++)
            {
                gCounter = currentRow;
                if (!isWeather)
                    columnsCount = dgvWeatherResults.Rows[currentRow].Cells.Count;
                else
                    columnsCount = dgvWeatherResults.Rows[currentRow].Cells.Count - (WEATHER_COLUMNS_COUNT * lbPointsLocation.SelectedItems.Count);
                for (int currentCell = 2; currentCell < columnsCount; currentCell++)
                {
                    if ((double)dgvWeatherResults.Rows[currentRow].Cells[currentCell].Value == 99999)
                        dgvWeatherResults.Rows[currentRow].Cells[currentCell].Style.BackColor = Color.Yellow;
                }

            }

        }

        private void ShowElementsAfterLoad()
        {
            flpDates.Visible = flpFilters.Visible = pnFolderPath.Visible = btnGenerateCsv.Visible = btnLoadWeather.Visible = pnLoadButtons.Visible = true;
        }

        private void ShowWeatherElements()
        {
            this.flpLocation.Visible = true;
        }

        private void AddAutoIncrementColumn()
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.ValueType = System.Type.GetType("System.Int32");
            column.Name = "Lp.";
            dgvWeatherResults.Columns.Insert(0, column);
            for (int counter = 0; counter < dgvWeatherResults.RowCount; counter++)
            {
                dgvWeatherResults.Rows[counter].Cells[0].Value = counter + 1;
            }
        }

       

        private DataRow SetDataRowWithValues(DataRow dataRow, string[] values, bool isFirstFile = false)
        {
            double windVector10 = 0;
            double windVector50 = 0;
            WeatherCalculator weatherCalculator = new WeatherCalculator();
            for (int i = 0; i < values.Count(); i++)
            {
                switch (i)
                {
                    case 0:
                        string dateTimeString = values[i];
                        dataRow[i] = ConvertDateTime(dateTimeString);
                        break;
                    case 1:
                        dataRow[i] = Math.Round(double.Parse(values[i]) / 100, 3);
                        break;
                    case 2:
                        dataRow[i] = Math.Round(double.Parse(values[i]) * 1000, 3);
                        break;
                    case 3:
                        dataRow[i] = Math.Round(double.Parse(values[i]) - 273.15, 3);
                        break;
                    case 4:
                        dataRow[i] = Math.Round(weatherCalculator.CalculateVectorSpeed(double.Parse(values[i]), double.Parse(values[i + 1])), 3);
                        break;
                    case 5:
                        windVector10 = Math.Round(rbAzimuthVector.Checked ? weatherCalculator.CalculateWindVector(double.Parse(values[i - 1]), double.Parse(values[i])) : weatherCalculator.CalculateWindVector(-double.Parse(values[i - 1]), -double.Parse(values[i])), 3);
                        if (windVector10 >= 0)
                            dataRow[i] = windVector10;
                        else
                            dataRow[i] = windVector10 + 360;
                        break;
                    case 6:
                        double windSpeed = Math.Round(weatherCalculator.CalculateVectorSpeed(double.Parse(values[i]), double.Parse(values[i + 1])), 3);
                        dataRow[i] = windSpeed;
                        if (cbSpeedAndPower.Checked)
                        {
                            dataRow[i + 2] = weatherCalculator.CalculateWindSpeedByHeight((double)nudHx.Value, windSpeed, (double)nudAlpha.Value, 50);
                            dataRow[i + 3] = weatherCalculator.ConversionOfWindSpeedIntoPower(windSpeed, (double)nudPr.Value, (double)nudVci.Value, (double)nudVr.Value, (double)nudVco.Value);
                        }
                        break;
                    case 7:
                        windVector50 = Math.Round(rbAzimuthVector.Checked ? weatherCalculator.CalculateWindVector(double.Parse(values[i - 1]), double.Parse(values[i])) : weatherCalculator.CalculateWindVector(-double.Parse(values[i - 1]), -double.Parse(values[i])), 3);
                        if (windVector50 >= 0)
                            dataRow[i] = windVector50;
                        else
                            dataRow[i] = windVector50 + 360;
                        break;

                }
            }
            

            return dataRow;
        }

        

        private DateTime GenerateLocalDateTime (DateTime firstDateTime, DateTime secondDateTime)
        {
            return new DateTime(firstDateTime.Year, firstDateTime.Month, firstDateTime.Day, secondDateTime.Hour, secondDateTime.Minute, secondDateTime.Second).ToLocalTime();
        }

        private void SetWeatherValuesToTable(DataColumn[] dataWeatherColumns, DataTable weatherDataSource, int dataRowCounter, int rowCounter)
        {
            double windVector10 = 0;
            double windVector50 = 0;
            WeatherCalculator weatherCalculator = new WeatherCalculator();
            for (int i = 0; i < dataWeatherColumns.Count(); i++)
            {
                switch (i)
                {
                    case 0:
                        dgvWeatherResults.Rows[dataRowCounter].Cells[dataWeatherColumns[i].ColumnName].Value = Math.Round((double)weatherDataSource.Rows[rowCounter].ItemArray[i + 2] / 100,3);
                        break;
                    case 1:
                        dgvWeatherResults.Rows[dataRowCounter].Cells[dataWeatherColumns[i].ColumnName].Value = Math.Round((double)weatherDataSource.Rows[rowCounter].ItemArray[i + 2] * 1000,3);
                        break;
                    case 2:
                        dgvWeatherResults.Rows[dataRowCounter].Cells[dataWeatherColumns[i].ColumnName].Value = Math.Round((double)weatherDataSource.Rows[rowCounter].ItemArray[i + 2] - 273.15,3);
                        break;
                    case 3:
                        dgvWeatherResults.Rows[dataRowCounter].Cells[dataWeatherColumns[i].ColumnName].Value = Math.Round(weatherCalculator.CalculateVectorSpeed((double)weatherDataSource.Rows[rowCounter].ItemArray[i + 2], (double)weatherDataSource.Rows[rowCounter].ItemArray[i + 3]), 3);
                        break;
                    case 4:
                        windVector10 = Math.Round(rbAzimuthVector.Checked ? weatherCalculator.CalculateWindVector((double)weatherDataSource.Rows[rowCounter].ItemArray[i + 1], (double)weatherDataSource.Rows[rowCounter].ItemArray[i + 2]) : weatherCalculator.CalculateWindVector(-(double)weatherDataSource.Rows[rowCounter].ItemArray[i + 1], -(double)weatherDataSource.Rows[rowCounter].ItemArray[i + 2]), 3);
                        if(windVector10 >= 0)
                            dgvWeatherResults.Rows[dataRowCounter].Cells[dataWeatherColumns[i].ColumnName].Value = windVector10;
                        else
                            dgvWeatherResults.Rows[dataRowCounter].Cells[dataWeatherColumns[i].ColumnName].Value = windVector10 + 360;
                        break;
                    case 5:
                        dgvWeatherResults.Rows[dataRowCounter].Cells[dataWeatherColumns[i].ColumnName].Value = Math.Round(weatherCalculator.CalculateVectorSpeed((double)weatherDataSource.Rows[rowCounter].ItemArray[i + 2], (double)weatherDataSource.Rows[rowCounter].ItemArray[i + 3]), 3);
                        break;
                    case 6:
                        windVector50 = Math.Round(rbAzimuthVector.Checked ? weatherCalculator.CalculateWindVector((double)weatherDataSource.Rows[rowCounter].ItemArray[i + 1], (double)weatherDataSource.Rows[rowCounter].ItemArray[i + 2]) : weatherCalculator.CalculateWindVector(-(double)weatherDataSource.Rows[rowCounter].ItemArray[i + 1], -(double)weatherDataSource.Rows[rowCounter].ItemArray[i + 2]), 3);
                        if(windVector50 >= 0)
                            dgvWeatherResults.Rows[dataRowCounter].Cells[dataWeatherColumns[i].ColumnName].Value = windVector50;
                        else
                            dgvWeatherResults.Rows[dataRowCounter].Cells[dataWeatherColumns[i].ColumnName].Value = windVector50 + 360;
                        break;
                    default:
                        dgvWeatherResults.Rows[dataRowCounter].Cells[dataWeatherColumns[i].ColumnName].Value = Math.Round((double)weatherDataSource.Rows[rowCounter].ItemArray[i + 2],3);
                        break;
                }
            }
        }
        private DateTime ConvertDateTime(string dateTimeToConvert)
        {
            return new DateTime(int.Parse(dateTimeToConvert.Substring(0, 4)), int.Parse(dateTimeToConvert.Substring(4, 2)),
                                                        int.Parse(dateTimeToConvert.Substring(6, 2)), int.Parse(dateTimeToConvert.Substring(9, 2)), 0, 0);
        }
        

        #endregion

        private void rbUtcTime_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

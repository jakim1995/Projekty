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
    public partial class DataJoinControl : UserControl
    {
        DataTable newDataTable;
        DataTable modifiedDataTable;
        private DataSet dataSet;
        private DataTable dataSource;
        private DataTable weatherDataSource1;
        private DataTable weatherDataSource2;
        private DataTable weatherDataSource3;
        private DataTable weatherDataSource4;
        private const string ERROR_FILE_SAVE = "Błąd: Nie można zapisać pliku. ";
        private const string ERROR_FILE_OPEN = "Błąd: Nie można otworzyć pliku. ";
        private const string WARRNING_NOT_SELECTED_TURBINS = "UWAGA: Nie zaznaczono żadnej turbiny.";
        private const string WARRNING_NOT_SELECTED_PARAMETERS = "UWAGA: Nie zaznaczono żadnego parametru.";
        private const int WEATHER_COLUMNS_COUNT = 7;
        int turbinCounter = 0;
        int weatherFileCounter = 0;
        List<int> selectedParameters = new List<int>();
        List<int> selectedTurbins = new List<int>();
        int gCounter = 0;
        DateTime[] changingDates = { new DateTime(2012,03,25,2,0,0) , new DateTime(2012,03,25,3,0,0),
                                             new DateTime(2013,03,31,2,0,0) , new DateTime(2013,03,31,3,0,0),
                                             new DateTime(2014,03,30,2,0,0) , new DateTime(2014,03,30,3,0,0)};
        #region konstruktor
        public DataJoinControl()
        {
            InitializeComponent();
            this.splitContainer1.SplitterDistance = this.splitContainer1.Size.Width / 2;
            
            dgvMeasurementResults.DataSource = modifiedDataTable = GlobalMeasurements.GlobalModifiedDataTable;
            if (dgvMeasurementResults.DataSource != null)
            {
                SetColumnsToThreeDecimalPlaces();
                ShowElementsAfterLoad();
            }
            

        }
        #endregion


        #region zdarzenia
        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadFolder_Click(object sender, EventArgs e)
        {
            if (lbTurbinNumber.SelectedItems.Count == 0)
            {
                MessageBox.Show(WARRNING_NOT_SELECTED_TURBINS);
            }
            else if (lbParameters.SelectedItems.Count == 0)
            {
                MessageBox.Show(WARRNING_NOT_SELECTED_PARAMETERS);
            }
            else if (fbdCsv.ShowDialog() == DialogResult.OK)
            {
                string globalFileName = "";
                int globalRowNumber = 0;
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    
                    string[] filesPath = Directory.GetFiles(fbdCsv.SelectedPath);
                    DateTime dateFrom = ((DateTime)dtpDateFrom.Value).Date.Add(((DateTime)dtpTimeFrom.Value).TimeOfDay);
                    DateTime dateTo = ((DateTime)dtpDateTo.Value).Date.Add(((DateTime)dtpTimeTo.Value).TimeOfDay);
                    bool isFirst = true;
                    turbinCounter = lbTurbinNumber.SelectedItems.Count;
                    dataSource = null;
                    for (int i = 0; i < lbParameters.SelectedItems.Count; i++)
                    {
                        selectedParameters.Add(Int32.Parse(lbParameters.SelectedItems[i].ToString()));
                    }
                    for (int i = 0; i < lbTurbinNumber.SelectedItems.Count; i++)
                    {
                        selectedTurbins.Add(Int32.Parse(lbTurbinNumber.SelectedItems[i].ToString()));
                    }
                    foreach (string filePath in filesPath)
                    {
                        if(selectedTurbins.Contains(Int32.Parse(Regex.Match(Path.GetFileNameWithoutExtension(filePath), @"\d+").Value)))
                        {
                            globalRowNumber = 0;

                            FileStream fileStream = File.Open(filePath, FileMode.Open, FileAccess.Read);
                            //IExcelDataReader reader = ExcelReaderFactory.CreateCsvReader(fileStream);
                            globalFileName = filePath;
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
                                            if (i < 2 || selectedParameters.Contains(i - 1))
                                                table.Columns.Add(values[i]);
                                        }
                                        isColumnCreated = true;
                                    }

                                    if (isFirst || (counter > 1 && (DateTime.Parse(values[1]) >= dateFrom && DateTime.Parse(values[1]) <= dateTo)))
                                    {
                                        DataRow row = table.NewRow();
                                        int valuesCounter = 0;
                                        for (int i = 0; i < values.Count(); i++)
                                        {
                                            if (i < 2 || selectedParameters.Contains(i-1))
                                            {
                                                row[valuesCounter++] = values[i];
                                            }
                                        }

                                        table.Rows.Add(row);
                                    }
                                }                                
                                isFirst = false;
                            }
                            fileStream.Close();
                            if (dataSource == null)
                                dataSource = table;
                            else
                                dataSource.Merge(table);
                        }
                    }
                    GC.Collect();
                    DataTable clone = dataSource.Clone();
                    for (int currentColumn = 0; currentColumn < dataSource.Columns.Count; currentColumn++)
                    {
                        if (dataSource.Columns[currentColumn].ColumnName != "Data")
                            clone.Columns[currentColumn].DataType = typeof(Double);
                        else
                            clone.Columns[currentColumn].DataType = typeof(DateTime);
                    }
                    for (int currentRow = 1; currentRow < dataSource.Rows.Count; currentRow++)
                    {
                        globalRowNumber = currentRow;
                        
                        clone.ImportRow(dataSource.Rows[currentRow]);
                    }
                    GC.Collect();
                    dataSource = ConvertTable(clone);
                    dgvMeasurementResults.DataSource = dataSource;
                    //dgvMeasurementResults.Sort(dgvMeasurementResults.Columns[0], ListSortDirection.Ascending);
                    GlobalMeasurements.GlobalModifiedDataTable = modifiedDataTable = dataSource;
                    SetColumnsToThreeDecimalPlaces();
                    
                    if (dgvMeasurementResults.Columns[0].Name != "Lp.")
                        AddAutoIncrementColumn();
                    else
                    {
                        for (int rowCounter = 0; rowCounter < dgvMeasurementResults.RowCount; rowCounter++)
                        {
                            dgvMeasurementResults.Rows[rowCounter].Cells[0].Value = rowCounter + 1;
                        }
                    }
                    SetYellowColorForEmptyCells();
                    ShowElementsAfterLoad();
                }
                catch (Exception ex)
                {
                    throw new Exception(ERROR_FILE_OPEN + " Ścieżka do pliku: " + globalFileName + " " + globalRowNumber + " " + ex.Message);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void btnAvarage_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                int rowCounter = 0;
                List<object[]> rowsItems = new List<object[]>();
                DataTable newTable = new DataTable();
                newTable = modifiedDataTable.Clone();
                for (int currentRow = 0; currentRow < modifiedDataTable.Rows.Count; currentRow++)
                {

                    if (rowsItems.Count==6 || rowCounter==0 && rowsItems.Count>0)
                        rowsItems[rowCounter] = modifiedDataTable.Rows[currentRow].ItemArray;
                    else
                        rowsItems.Add(modifiedDataTable.Rows[currentRow].ItemArray);
                    rowCounter++;

                    if (modifiedDataTable.Rows[currentRow].Field<DateTime>("Data").Minute == 0)
                    {
                        
                        DataRow row = newTable.NewRow();
                        for (int currentColumn = 0; currentColumn < modifiedDataTable.Columns.Count; currentColumn++)
                        {
                            if (currentColumn > 0)
                            {
                                double itemValue = 0;
                                int notZeroCounter = 0;
                                int emptyCounter = 0;
                                for (int currentItem = 0; currentItem < rowsItems.Count(); currentItem++)
                                {
                                    if((double)rowsItems[currentItem][currentColumn]!=99999)
                                        itemValue += (double)rowsItems[currentItem][currentColumn];
                                    else
                                        emptyCounter++;
                                    if ((double)rowsItems[currentItem][currentColumn] != 0)
                                        notZeroCounter++;                                        
                                }
                                if (notZeroCounter > 0)
                                    if(emptyCounter == 6)
                                        row[currentColumn] = 99999;
                                    else
                                        row[currentColumn] = itemValue / notZeroCounter;                                    
                                else
                                    row[currentColumn] = 0;
                            }
                            else
                                row[currentColumn] = (DateTime)rowsItems[rowCounter-1][currentColumn];
                        }
                        rowCounter = 0;
                        newTable.Rows.Add(row);
                    }
                }
                dgvMeasurementResults.DataSource = dataSource = modifiedDataTable = newTable;
                SetYellowColorForEmptyCells();
                for (int counter = 0; counter < dgvMeasurementResults.RowCount; counter++)
                {
                    dgvMeasurementResults.Rows[counter].Cells[0].Value = counter + 1;
                }
                ShowWeatherElements();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnFiltration_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                dgvMeasurementResults.DataSource = dataSource = GetTableByDates();
                DgvFiltration();
                ColumnReordering();

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Cursor = Cursors.Default;
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
                    foreach(DataGridViewColumn column in dgvMeasurementResults.Columns.OfType<DataGridViewColumn>().OrderBy(x=>x.DisplayIndex))
                    {
                        
                        if (column.Visible && column.Name != "Lp.")
                        {
                            sb.Append(column.HeaderText);
                            if (columnCount < dgvMeasurementResults.Columns.Count - 1)
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
                    for (int currentRow = 0; currentRow < dgvMeasurementResults.Rows.Count; currentRow ++)
                    {
                        if (dgvMeasurementResults.Rows[currentRow].Visible)
                        {
                            columnCount = 0;
                            //for (int i = 0; i < dgvMeasurementResults.Columns.Count-1; i++)
                            //{
                            foreach (DataGridViewColumn column in dgvMeasurementResults.Columns.OfType<DataGridViewColumn>().OrderBy(x => x.DisplayIndex))
                            {   
                                if (column.Visible && column.Name != "Lp.")
                                {
                                    if (dgvMeasurementResults.Rows[currentRow].Cells[column.Index].Value.ToString() == "99999")
                                        sb.Append("");
                                    else
                                    {
                                        if (column.Index > 1)
                                            cellValue = Math.Round((double)dgvMeasurementResults.Rows[currentRow].Cells[column.Index].Value, 3).ToString();
                                        else
                                            cellValue = dgvMeasurementResults.Rows[currentRow].Cells[column.Index].Value.ToString();
                                        if (rbDot.Checked)
                                            sb.Append(cellValue.Replace(",", "."));
                                        else
                                            sb.Append(cellValue);
                                    }
                                    if (columnCount < dgvMeasurementResults.Columns.Count - 1)
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

        private void btnSetZeroes_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                
                for (int currentRow = 0; currentRow < dgvMeasurementResults.Rows.Count - 1; currentRow++)
                {
                    for (int currentColumn = 0; currentColumn < turbinCounter; currentColumn++)
                    {
                        if (dgvMeasurementResults.Columns.Contains("X1(" + (currentColumn + 1) + ")") && dgvMeasurementResults.Columns.Contains("X9(" + (currentColumn + 1) + ")"))
                        {
                            if ((double)dgvMeasurementResults.Rows[currentRow].Cells["X1(" + (currentColumn + 1) + ")"].Value < 0)
                            {
                                dgvMeasurementResults.Rows[currentRow].Cells["X1(" + (currentColumn + 1) + ")"].Value = 0;
                            }
                            if ((double)dgvMeasurementResults.Rows[currentRow].Cells["X9(" + (currentColumn + 1) + ")"].Value < 0)
                            {
                                dgvMeasurementResults.Rows[currentRow].Cells["X9(" + (currentColumn + 1) + ")"].Value = 0;
                            }
                        }
                    }
                }
                SetYellowColorForEmptyCells();
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

        private void btnAddWeather_Click(object sender, EventArgs e)
        {
            try
            {
                if (fbdCsv.ShowDialog() == DialogResult.OK)
                {
                    if (lbPointsLocation.SelectedItems.Count > 0)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        LoadWeatherFromFiles();
                        dgvMeasurementResults.DataSource = modifiedDataTable = AddWeatherToTable();
                        SetColumnsToThreeDecimalPlaces();
                        if (dgvMeasurementResults.Columns[0].Name != "Lp.")
                            AddAutoIncrementColumn();
                        else
                        {
                            for (int rowCounter = 0; rowCounter < dgvMeasurementResults.RowCount; rowCounter++)
                            {
                                dgvMeasurementResults.Rows[rowCounter].Cells[0].Value = rowCounter + 1;
                            }
                        }
                        SetYellowColorForEmptyCells(true);
                    }
                    else
                        MessageBox.Show("Nie wybrano punktów lokalizacji.");
                }
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

        private void rbCheckedChanged(object sender, EventArgs e)
        {
            ColumnReordering();
        }
        #endregion

        #region metody
        private void SetColumnsToThreeDecimalPlaces()
        {
            int columnNumber = 0;
            if (dgvMeasurementResults.Columns[0].Name != "Lp.")
                columnNumber = 1;
            else
                columnNumber = 2;

            for (int currentColumn = columnNumber; currentColumn < dgvMeasurementResults.Columns.Count; currentColumn++)
            {
                dgvMeasurementResults.Columns[currentColumn].DefaultCellStyle.Format = "N3";
                dgvMeasurementResults.Columns[currentColumn].DefaultCellStyle.NullValue = 99999;
            }
        }

        private DataTable ConvertTable(DataTable table)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                int turbinCount = turbinCounter;
                DataTable newTable = new DataTable("Etap2");
                bool isX9Column = false;
                int x9Counter = 0;

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
                            column.ColumnName = table.Columns[i - 1].ColumnName + "(" + selectedTurbins[j] + ")";
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
                            row[m + (turbinCount * j) + 1] = dataTableList[m].Columns[j + 2].ColumnName.Contains("X9") && dataTableList[m].Rows[i].Field<double>(dataTableList[m].Columns[j + 2].ColumnName) < 0
                                                                    ? 0 : dataTableList[m].Rows[i].Field<double>(dataTableList[m].Columns[j + 2].ColumnName);

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
            if (rbTurbins.Checked)
            {
                int counter = 1;
                for (int i = 0; i < lbTurbinNumber.SelectedItems.Count; i++)
                {
                    for (int j = 0; j < lbParameters.SelectedItems.Count; j++)
                    {
                        counter++;
                        dgvMeasurementResults.Columns[j * lbTurbinNumber.SelectedItems.Count + i + 2].DisplayIndex = counter;
                    }
                }
            }
            else
            {
                for (int i = 2; i < dgvMeasurementResults.Columns.Count; i++)
                {
                    dgvMeasurementResults.Columns[i].DisplayIndex = dgvMeasurementResults.Columns[i].Index;
                }
            }
            for (int counter = 0; counter < dgvMeasurementResults.RowCount; counter++)
            {
                dgvMeasurementResults.Rows[counter].Cells[0].Value = counter + 1;
            }
        }

        private void DgvFiltration()
        {
            for (int i = 2; i < dgvMeasurementResults.ColumnCount; i++)
            {
                dgvMeasurementResults.Columns[i].Visible = false;
            }
            for (int currentParameter = 0; currentParameter < lbParameters.SelectedItems.Count; currentParameter++)
            {
                for (int currentTurbin = 0; currentTurbin < lbTurbinNumber.SelectedItems.Count; currentTurbin++)
                {
                    for (int currentColumn = 2; currentColumn < dgvMeasurementResults.ColumnCount; currentColumn++)
                    {
                        if (dgvMeasurementResults.Columns[currentColumn].HeaderText.Contains("X" + Int32.Parse(lbParameters.SelectedItems[currentParameter].ToString()) + "(" + Int32.Parse(lbTurbinNumber.SelectedItems[currentTurbin].ToString()) + ")")|| currentColumn > lbParameters.Items.Count*lbTurbinNumber.Items.Count)
                            dgvMeasurementResults.Columns[currentColumn].Visible = true;
                    }
                }
            }
        }

        private DataTable GetTableByDates()
        {
            DataTable newDataTable = null;
            BindingSource bs = new BindingSource();
            string filter = "";
            bs.DataSource = dgvMeasurementResults.DataSource;
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
            for (int currentRow = 0; currentRow < dgvMeasurementResults.Rows.Count; currentRow++)
            {
                gCounter = currentRow;
                if (!isWeather)
                    columnsCount = dgvMeasurementResults.Rows[currentRow].Cells.Count;
                else
                    columnsCount = dgvMeasurementResults.Rows[currentRow].Cells.Count - (WEATHER_COLUMNS_COUNT * lbPointsLocation.SelectedItems.Count);
                for (int currentCell = 2; currentCell < columnsCount; currentCell++)
                {
                    if ((double)dgvMeasurementResults.Rows[currentRow].Cells[currentCell].Value == 99999)
                        dgvMeasurementResults.Rows[currentRow].Cells[currentCell].Style.BackColor = Color.Yellow;
                }

            }

        }

        private void ShowElementsAfterLoad()
        {
            this.btnGenerateCsv.Visible = this.btnAvarage.Visible = this.btnSetZeroes.Visible = this.flpRadioButtonsPunctuation.Visible = this.flpRadioButtonsColumns.Visible = true;
        }

        private void ShowWeatherElements()
        {
            this.btnAddWeather.Visible = this.flpLocation.Visible = true;
        }

        private void AddAutoIncrementColumn()
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.ValueType = System.Type.GetType("System.Int32");
            column.Name = "Lp.";
            dgvMeasurementResults.Columns.Insert(0, column);
            for (int counter = 0; counter < dgvMeasurementResults.RowCount; counter++)
            {
                dgvMeasurementResults.Rows[counter].Cells[0].Value = counter + 1;
            }
        }

        private void LoadWeatherFromFiles()
        {
            string[] filesPath = Directory.GetFiles(fbdCsv.SelectedPath);
            List<char> points = new List<char>();
            weatherFileCounter = 0;
            weatherDataSource1 = weatherDataSource2 = weatherDataSource3 = weatherDataSource4 = null;

            foreach (string point in lbPointsLocation.SelectedItems)
            {
                points.Add(point.Trim()[0]);
            }
            foreach (string filePath in filesPath)
            {
                
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                char pointNumber = fileName.Last();
                weatherFileCounter++;
                if(points.Contains(pointNumber))
                {
                    
                    FileStream fileStream = File.Open(filePath, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fileStream);
                    //if((weatherDataSource1==null && pointNumber=='1' ) || (weatherDataSource2 == null && pointNumber == '2') ||
                    //    (weatherDataSource3 == null && pointNumber == '3') || (weatherDataSource4 == null && pointNumber == '4'))
                    //{
                        dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true
                            }
                        });
                    //}
                    //else
                    //{
                    //    dataSet = reader.AsDataSet();
                    //}
                    
                    reader.Close();
                    //dataSet.Tables[0].Columns[0].DataType = typeof(DateTime);
                    switch (pointNumber)
                    {
                        case '1':
                            if (weatherDataSource1 == null)
                                weatherDataSource1 = dataSet.Tables[0];
                            else
                                weatherDataSource1.Merge(dataSet.Tables[0]);
                            break;
                        case '2':
                            if (weatherDataSource2 == null)
                                weatherDataSource2 = dataSet.Tables[0];
                            else
                                weatherDataSource2.Merge(dataSet.Tables[0]);
                            break;
                        case '3':
                            if (weatherDataSource3 == null)
                                weatherDataSource3 = dataSet.Tables[0];
                            else
                                weatherDataSource3.Merge(dataSet.Tables[0]);
                            break;
                        case '4':
                            if (weatherDataSource4 == null)
                                weatherDataSource4 = dataSet.Tables[0];
                            else
                                weatherDataSource4.Merge(dataSet.Tables[0]);
                            break;
                    }
                }
            }
        }

        private DataTable AddWeatherToTable()
        {
            DataTable newTable = dataSource.Copy();
            int weatherRowCount = 0;
            List<DataColumn[]> dataWeatherColumns = new List<DataColumn[]>();
            dataWeatherColumns.Add( new DataColumn[] { new DataColumn("PS(1)",typeof(double)), new DataColumn("QV10M(1)",typeof(double)),
                                        new DataColumn("T10M(1)",typeof(double)), new DataColumn("V10M(1)",typeof(double)),
                                        new DataColumn("ϕ10M(1)",typeof(double)), new DataColumn("V50M(1)",typeof(double)), new DataColumn("ϕ50M(1)",typeof(double)) });
            dataWeatherColumns.Add(new DataColumn[] { new DataColumn("PS(2)",typeof(double)), new DataColumn("QV10M(2)",typeof(double)),
                                        new DataColumn("T10M(2)",typeof(double)), new DataColumn("V10M(2)",typeof(double)),
                                        new DataColumn("ϕ10M(2)",typeof(double)), new DataColumn("V50M(2)",typeof(double)), new DataColumn("ϕ50M(2)",typeof(double)) });
            dataWeatherColumns.Add(new DataColumn[] { new DataColumn("PS(3)",typeof(double)), new DataColumn("QV10M(3)",typeof(double)),
                                        new DataColumn("T10M(3)",typeof(double)), new DataColumn("V10M(3)",typeof(double)),
                                        new DataColumn("ϕ10M(3)",typeof(double)), new DataColumn("V50M(3)",typeof(double)), new DataColumn("ϕ50M(3)",typeof(double)) });
            dataWeatherColumns.Add(new DataColumn[] { new DataColumn("PS(4)",typeof(double)), new DataColumn("QV10M(4)",typeof(double)),
                                        new DataColumn("T10M(4)",typeof(double)), new DataColumn("V10M(4)",typeof(double)),
                                        new DataColumn("ϕ10M(4)",typeof(double)), new DataColumn("V50M(4)",typeof(double)), new DataColumn("ϕ50M(4)",typeof(double)) });
            if (weatherDataSource1 != null)
            {
                newTable.Columns.AddRange(dataWeatherColumns[0]);
                weatherRowCount = weatherDataSource1.Rows.Count;
            }
            if (weatherDataSource2 != null)
            {
                newTable.Columns.AddRange(dataWeatherColumns[1]);
                weatherRowCount = weatherDataSource2.Rows.Count;
            }
            if (weatherDataSource3 != null)
            {
                newTable.Columns.AddRange(dataWeatherColumns[2]);
                weatherRowCount = weatherDataSource3.Rows.Count;
            }
            if (weatherDataSource4 != null)
            {
                newTable.Columns.AddRange(dataWeatherColumns[3]);
                weatherRowCount = weatherDataSource4.Rows.Count;
            }
            dgvMeasurementResults.DataSource = newTable;
            int weatherRowNumber = 0;
            int weatherDataSourceCounter = 0;
            for (int dataRowCounter = 0; dataRowCounter < dgvMeasurementResults.Rows.Count; dataRowCounter++)
            {
                for (int rowCounter = weatherRowNumber; rowCounter < weatherRowCount; rowCounter++, weatherRowNumber++)
                {
                    if(((DateTime)weatherDataSource1.Rows[rowCounter].ItemArray[1]).Minute == 0)
                    {
                        weatherDataSourceCounter = 0;
                        if (weatherDataSource1 != null && (GenerateLocalDateTime((DateTime)weatherDataSource1.Rows[rowCounter].ItemArray[0], (DateTime)weatherDataSource1.Rows[rowCounter].ItemArray[1]) == ((DateTime)(dgvMeasurementResults.Rows[dataRowCounter].Cells["Data"].Value)).AddHours(-1) || changingDates.Contains((DateTime)dgvMeasurementResults.Rows[dataRowCounter].Cells["Data"].Value)))
                        {
                            SetWeatherValuesToTable(dataWeatherColumns[0], weatherDataSource1, dataRowCounter, rowCounter);
                            weatherDataSourceCounter++;
                        }
                        if (weatherDataSource2 != null && (GenerateLocalDateTime((DateTime)weatherDataSource2.Rows[rowCounter].ItemArray[0], (DateTime)weatherDataSource2.Rows[rowCounter].ItemArray[1]) == ((DateTime)(dgvMeasurementResults.Rows[dataRowCounter].Cells["Data"].Value)).AddHours(-1) || changingDates.Contains((DateTime)dgvMeasurementResults.Rows[dataRowCounter].Cells["Data"].Value)))
                        {
                            SetWeatherValuesToTable(dataWeatherColumns[1], weatherDataSource2, dataRowCounter, rowCounter);
                            weatherDataSourceCounter++;
                        }
                        if (weatherDataSource3 != null && (GenerateLocalDateTime((DateTime)weatherDataSource3.Rows[rowCounter].ItemArray[0], (DateTime)weatherDataSource3.Rows[rowCounter].ItemArray[1]) == ((DateTime)(dgvMeasurementResults.Rows[dataRowCounter].Cells["Data"].Value)).AddHours(-1) || changingDates.Contains((DateTime)dgvMeasurementResults.Rows[dataRowCounter].Cells["Data"].Value)))
                        {
                            SetWeatherValuesToTable(dataWeatherColumns[2], weatherDataSource3, dataRowCounter, rowCounter);
                            weatherDataSourceCounter++;
                        }
                        if (weatherDataSource4 != null && (GenerateLocalDateTime((DateTime)weatherDataSource4.Rows[rowCounter].ItemArray[0], (DateTime)weatherDataSource4.Rows[rowCounter].ItemArray[1]) == ((DateTime)(dgvMeasurementResults.Rows[dataRowCounter].Cells["Data"].Value)).AddHours(-1) || changingDates.Contains((DateTime)dgvMeasurementResults.Rows[dataRowCounter].Cells["Data"].Value)))
                        {
                            SetWeatherValuesToTable(dataWeatherColumns[3], weatherDataSource4, dataRowCounter, rowCounter);
                            weatherDataSourceCounter++;
                        }
                        if (weatherDataSourceCounter > 0)
                            break;
                    }
                }
            }

            return newTable;
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
                        dgvMeasurementResults.Rows[dataRowCounter].Cells[dataWeatherColumns[i].ColumnName].Value = Math.Round((double)weatherDataSource.Rows[rowCounter].ItemArray[i + 2] / 100,3);
                        break;
                    case 1:
                        dgvMeasurementResults.Rows[dataRowCounter].Cells[dataWeatherColumns[i].ColumnName].Value = Math.Round((double)weatherDataSource.Rows[rowCounter].ItemArray[i + 2] * 1000,3);
                        break;
                    case 2:
                        dgvMeasurementResults.Rows[dataRowCounter].Cells[dataWeatherColumns[i].ColumnName].Value = Math.Round((double)weatherDataSource.Rows[rowCounter].ItemArray[i + 2] - 273.15,3);
                        break;
                    case 3:
                        dgvMeasurementResults.Rows[dataRowCounter].Cells[dataWeatherColumns[i].ColumnName].Value = Math.Round(weatherCalculator.CalculateVectorSpeed((double)weatherDataSource.Rows[rowCounter].ItemArray[i + 2], (double)weatherDataSource.Rows[rowCounter].ItemArray[i + 3]), 3);
                        break;
                    case 4:
                        windVector10 = Math.Round(rbAzimuthVector.Checked ? weatherCalculator.CalculateWindVector((double)weatherDataSource.Rows[rowCounter].ItemArray[i + 1], (double)weatherDataSource.Rows[rowCounter].ItemArray[i + 2]) : weatherCalculator.CalculateWindVector(-(double)weatherDataSource.Rows[rowCounter].ItemArray[i + 1], -(double)weatherDataSource.Rows[rowCounter].ItemArray[i + 2]), 3);
                        if(windVector10 >= 0)
                            dgvMeasurementResults.Rows[dataRowCounter].Cells[dataWeatherColumns[i].ColumnName].Value = windVector10;
                        else
                            dgvMeasurementResults.Rows[dataRowCounter].Cells[dataWeatherColumns[i].ColumnName].Value = windVector10 + 360;
                        break;
                    case 5:
                        dgvMeasurementResults.Rows[dataRowCounter].Cells[dataWeatherColumns[i].ColumnName].Value = Math.Round(weatherCalculator.CalculateVectorSpeed((double)weatherDataSource.Rows[rowCounter].ItemArray[i + 2], (double)weatherDataSource.Rows[rowCounter].ItemArray[i + 3]), 3);
                        break;
                    case 6:
                        windVector50 = Math.Round(rbAzimuthVector.Checked ? weatherCalculator.CalculateWindVector((double)weatherDataSource.Rows[rowCounter].ItemArray[i + 1], (double)weatherDataSource.Rows[rowCounter].ItemArray[i + 2]) : weatherCalculator.CalculateWindVector(-(double)weatherDataSource.Rows[rowCounter].ItemArray[i + 1], -(double)weatherDataSource.Rows[rowCounter].ItemArray[i + 2]), 3);
                        if(windVector50 >= 0)
                            dgvMeasurementResults.Rows[dataRowCounter].Cells[dataWeatherColumns[i].ColumnName].Value = windVector50;
                        else
                            dgvMeasurementResults.Rows[dataRowCounter].Cells[dataWeatherColumns[i].ColumnName].Value = windVector50 + 360;
                        break;
                    default:
                        dgvMeasurementResults.Rows[dataRowCounter].Cells[dataWeatherColumns[i].ColumnName].Value = Math.Round((double)weatherDataSource.Rows[rowCounter].ItemArray[i + 2],3);
                        break;
                }
            }
        }
        #endregion
    }
}

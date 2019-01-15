using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using PagedList;
using PracaInzynierska.Helpers;

namespace PracaInzynierska.Controls
{
    public partial class TurbinsCsvGeneratorControl : UserControl
    {
        private const string ERROR_FILE_OPEN = "Błąd: Nie można otworzyć pliku. ";
        private const string ERROR_SEARCH_EMPTY_ROWS = "Błąd: Wystąpił błąd podczas szukania pustych wierszy. ";
        private const string ERROR_SEARCH_MISSING_ROWS = "Błąd: Wystąpił błąd podczas szukania brakujących wierszy. ";
        private const string ERROR_SAME_ROWS = "Błąd: Wystąpił błąd podczas szukania takich samych wierszy. ";
        private const string ERROR_FILE_SAVE = "Błąd: Nie można zapisać pliku. ";
        private const string WARRNING_SELECT_TURBIN = "Proszę o zaznaczenie numeru turbiny.";
        private const string INFO_NO_MORE_EMPTY_ROWS = "Nie znaleziono pustych wierszy.";
        private const string X6 = "X6";
        private const string X8 = "X8";
        private const string X12 = "X12";
        private const string NUMBER_STRING = "Numer";
        private const string DATE_STRING = "Data";
        private const string TURBIN_STRING = "Turbina";
        private const string CSV_EXTENTION_STRING = ".csv";
        private const string TEMP_FILE = "zapis_wyniku.csv";
        private const char SEPERATOR = ';';
        

        public DataSet dataSet;
        public DataTable dataTable;
        public List<DataTable> dataTableList;
        public DataRowCollection dataRowCollection;
        public DataTable dataSource;
        public ListBox.SelectedObjectCollection selectedTurbins;
        private DataRowView parentRow;
        private int parentIndex;
        private bool isSearchEmptyRowsBtnClick = false;
        private bool isSearchMissingRowsBtnClick = false;
        private int rowIndex;

        #region konstruktor

        public TurbinsCsvGeneratorControl()
        {
            InitializeComponent();
            this.splitContainer1.SplitterDistance = this.splitContainer1.Size.Width / 2;

            if (GlobalMeasurements.GlobalDataTable != null)
            {
                dgvMeasurementResults.DataSource = GlobalMeasurements.GlobalDataTable;
                ShowElements();
            }
            //else
            //{
            //    if (File.Exists(Path.Combine(Path.GetTempPath(), TEMP_FILE)))
            //    {
            //        dgvMeasurementResults.DataSource = GetTableFromTempCsv(Path.Combine(Path.GetTempPath(), TEMP_FILE));
            //        AddAutoIncrementColumn();
            //    }
            //    SetColumnsToThreeDecimalPlaces();
                
            //}
                
        }
        #endregion

        #region zdarzenia
        private void btnLoadFolder_Click(object sender, EventArgs e)
        {
            string error = "";
            string filename = "";
            if (fbdCsv.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    var filesPath = Directory.GetFiles(fbdCsv.SelectedPath).OrderBy(f => f);
                    error = "0";
                    int counter = 0;
                    dataSource = null;
                    foreach (string filePath in filesPath)
                    {
                        filename = filePath;
                        counter++;
                        FileStream fileStream = File.Open(filePath, FileMode.Open, FileAccess.Read);
                        IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fileStream);

                        error = "1";
                        dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true
                            }
                        });
                        reader.Close();
                        fileStream.Close();
                        //if(dataSet.Tables[0].Columns[3].ColumnName!="X1")
                        //{
                        //    for(int currentColumn = 2; currentColumn < dataSet.Tables[0].Columns.Count; currentColumn++)
                        //    {
                        //        dataSet.Tables[0].Columns[currentColumn].ColumnName = "X" + ((currentColumn - 1).ToString().Length==1 ? "0"+(currentColumn - 1).ToString(): (currentColumn - 1).ToString());
                        //    }
                        //}
                        if (dataSource == null)
                        {
                            error = "2";
                            dataSource = AddSumColumn(dataSet.Tables[0]);

                        }
                        else
                        {
                            error = "3";
                            dataSource.Merge(AddSumColumn(dataSet.Tables[0]));

                        }


                    }
                    error = "4";
                    //dataSource
                    dgvMeasurementResults.DataSource = dataSource;
                    //dgvMeasurementResults.Sort(dgvMeasurementResults.Columns[0], ListSortDirection.Ascending);
                    GlobalMeasurements.GlobalDataTable = dataSource;
                    error = "5";
                    //flpFilterButtons.Visible = true;
                    ShowElements();
                    if (dgvMeasurementResults.Columns[0].Name != "Lp.")
                        AddAutoIncrementColumn();
                    else
                    {
                        for (int rowCounter = 0; rowCounter < dgvMeasurementResults.RowCount; rowCounter++)
                        {
                            dgvMeasurementResults.Rows[rowCounter].Cells[0].Value = rowCounter + 1;
                        }
                    }
                    SetColumnsToThreeDecimalPlaces();
                    dgvMeasurementResults.Refresh();
                    error = "6";
                }
                catch (Exception ex)
                {
                    throw new Exception(ERROR_FILE_OPEN + " Błąd numer: " + error + " " + " Nazwa pliku: " + filename + " " + ex.Message);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdCsv.ShowDialog() == DialogResult.OK)
                {
                    dgvMeasurementResults.DataSource = GetTableFromTempCsv(ofdCsv.FileName);
                    if (dgvMeasurementResults.Columns[0].Name != "Lp.")
                        AddAutoIncrementColumn();
                    else
                    {
                        for (int rowCounter = 0; rowCounter < dgvMeasurementResults.RowCount; rowCounter++)
                        {
                            dgvMeasurementResults.Rows[rowCounter].Cells[0].Value = rowCounter + 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnGenerateCsv_Click(object sender, EventArgs e)
        {
            try
            {
                if (fbdCsv.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    string output = GenerateCsv((DataTable)dgvMeasurementResults.DataSource, SEPERATOR);
                    string path = Path.Combine(fbdCsv.SelectedPath, TURBIN_STRING + dgvMeasurementResults.Rows[0].Cells[1].Value.ToString().PadLeft(2, '0') + CSV_EXTENTION_STRING);
                    System.IO.File.WriteAllText(path, output, System.Text.Encoding.UTF8);
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

        private void btnSearchEmptyRows_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                DataGridViewRow firstRow = null;
                int firstRowIndex = 0;
                int emptyRowCounter = 0;
                if (isSearchEmptyRowsBtnClick)
                {
                    firstRowIndex = ++dgvMeasurementResults.FirstDisplayedScrollingRowIndex;
                }
                for (int currentRow = firstRowIndex; currentRow < dgvMeasurementResults.Rows.Count; currentRow++)
                {
                    if (dgvMeasurementResults.Rows[currentRow].Cells["X1"].Value != null && (dgvMeasurementResults.Rows[currentRow].Cells["X1"].Value.ToString() == "0" || dgvMeasurementResults.Rows[currentRow].Cells["X1"].Value.ToString() == "99999"))
                    {
                        emptyRowCounter = 0;
                        for (int currentColumn = 3; currentColumn < dgvMeasurementResults.Rows[currentRow].Cells.Count; currentColumn++)
                        {
                            dgvMeasurementResults.Rows[currentRow].Cells[currentColumn].Value = 99999;
                        }
                        dgvMeasurementResults.Rows[currentRow].DefaultCellStyle.BackColor = Color.Yellow;
                        if (firstRow == null)
                        {
                            firstRow = dgvMeasurementResults.Rows[currentRow];
                        }
                        if (isSearchEmptyRowsBtnClick)
                        {
                            break;
                        }
                    }

                }

                if (firstRow != null)
                {
                    FocusOnRow(firstRow.Index);
                }
                isSearchEmptyRowsBtnClick = true;


            }
            catch (Exception ex)
            {
                throw new Exception(ERROR_SEARCH_EMPTY_ROWS + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        
        

        private void btnSearchMissingRows_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                BindingSource bs = new BindingSource();
                BindingSource bsCopy = new BindingSource();
                int emptyRowsCount = 0;
                DateTime[] changingDates = { new DateTime(2012,03,25,2,0,0) , new DateTime(2012,03,25,3,0,0),
                                             new DateTime(2013,03,31,2,0,0) , new DateTime(2013,03,31,3,0,0),
                                             new DateTime(2014,03,30,2,0,0) , new DateTime(2014,03,30,3,0,0)};
                isSearchEmptyRowsBtnClick = false;
                bs.DataSource = bsCopy.DataSource = dgvMeasurementResults.DataSource;
                parentRow = null;
                foreach (var row in bs.List)
                {
                    if (parentRow == null)
                    {
                        if (DateTime.Parse(((DataTable)bs.DataSource).Rows[0].ItemArray[1].ToString()) != new DateTime(2012, 03, 17, 0, 10, 0))
                        {
                            DateTime addedMinutes = new DateTime(2012, 03, 17, 0, 10, 0);
                            while (addedMinutes < ((DateTime)((DataRowView)row).Row.ItemArray[1]))
                            {
                                DateTime universalTime = addedMinutes;
                                if ((universalTime <= changingDates[0] || universalTime > changingDates[1]))
                                {
                                    DataRow newRow;
                                    newRow = ((DataTable)bs.DataSource).NewRow();
                                    newRow[0] = ((DataTable)bs.DataSource).Rows[0].ItemArray[0];
                                    newRow[1] = addedMinutes;
                                    for (int i = 2; i <= 13; i++)
                                        newRow[i] = 0;
                                    ((DataTable)bsCopy.DataSource).Rows.InsertAt(newRow, emptyRowsCount++);
                                    //bsCopy.List.Insert(parentIndex++, newRow);
                                }
                                addedMinutes = addedMinutes.AddMinutes(10);

                            }

                        }
                        parentRow = (DataRowView)row;
                        parentIndex = bs.List.IndexOf(row);
                    }
                    else
                    {
                        DateTime addedMinutes = ((DateTime)parentRow.Row.ItemArray[1]).AddMinutes(10);
                        while (addedMinutes < ((DateTime)((DataRowView)row).Row.ItemArray[1]))
                        {
                            DateTime universalTime = addedMinutes;
                            if ((universalTime < changingDates[0] || universalTime > changingDates[1]) &&
                                (universalTime < changingDates[2] || universalTime > changingDates[3]) &&
                                (universalTime < changingDates[4] || universalTime > changingDates[5]))
                            {
                                DataRow newRow;
                                newRow = ((DataTable)bs.DataSource).NewRow();
                                newRow[0] = parentRow[0];
                                newRow[1] = addedMinutes;
                                for (int i = 2; i <= 13; i++)
                                    newRow[i] = 0;
                                ((DataTable)bsCopy.DataSource).Rows.InsertAt(newRow, ++parentIndex);
                                //bsCopy.List.Insert(parentIndex++, newRow);
                            }
                            addedMinutes = addedMinutes.AddMinutes(10);


                        }
                        parentRow = (DataRowView)row;
                        parentIndex = bs.List.IndexOf(row);
                    }
                }
                if (DateTime.Parse(((DataTable)bs.DataSource).Rows[((DataTable)bs.DataSource).Rows.Count - 1].ItemArray[1].ToString()) != new DateTime(2014, 12, 31, 23, 50, 0))
                {
                    parentIndex++;
                    DateTime addedMinutes = ((DateTime)parentRow.Row.ItemArray[1]).AddMinutes(10);
                    while (addedMinutes <= new DateTime(2014, 12, 31, 23, 50, 0))
                    {
                        DataRow newRow;
                        newRow = ((DataTable)bs.DataSource).NewRow();
                        newRow[0] = ((DataTable)bs.DataSource).Rows[0].ItemArray[0];
                        newRow[1] = addedMinutes;
                        for (int i = 2; i <= 13; i++)
                            newRow[i] = 0;
                        ((DataTable)bsCopy.DataSource).Rows.InsertAt(newRow, parentIndex++);
                        //bsCopy.List.Insert(parentIndex++, newRow);
                        addedMinutes = addedMinutes.AddMinutes(10);
                    }

                }
                dgvMeasurementResults.DataSource = bsCopy.DataSource;
                for (int counter = 0; counter < dgvMeasurementResults.RowCount; counter++)
                {
                    dgvMeasurementResults.Rows[counter].Cells[0].Value = counter + 1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ERROR_SEARCH_MISSING_ROWS, ex);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnSearchTheSameValues_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                DataGridViewRowCollection col = dgvMeasurementResults.Rows;
                BindingSource bs = new BindingSource();
                bs.DataSource = dgvMeasurementResults.DataSource;
                DataTable bsCopy = ((DataTable)bs.DataSource).Copy();
                DataGridViewRow firstRow = null;

                bsCopy.Rows.Clear();
                for (int currentRow = 0; currentRow < dgvMeasurementResults.Rows.Count - 1; currentRow++)
                {
                    DataGridViewRow rowToCompare = dgvMeasurementResults.Rows[currentRow];
                    if (rowToCompare.DefaultCellStyle.BackColor == Color.Red)
                    {
                        if (firstRow != null)
                            FocusOnRow(firstRow.Index);
                        else
                            FocusOnRow(rowToCompare.Index - 1);
                        break;
                    }
                    else
                    {
                        for (int otherRow = currentRow + 1; otherRow < dgvMeasurementResults.Rows.Count; otherRow++)
                        {
                            DataGridViewRow row = dgvMeasurementResults.Rows[otherRow];

                            bool duplicateRow = true;
                            if ((!rowToCompare.Cells["X1"].Value.Equals(row.Cells["X1"].Value) || (double)rowToCompare.Cells["X1"].Value == 0 || (double)rowToCompare.Cells["X1"].Value == 99999)
                                || (!rowToCompare.Cells["X2"].Value.Equals(row.Cells["X2"].Value) || (double)rowToCompare.Cells["X2"].Value == 0 || (double)rowToCompare.Cells["X2"].Value == 99999))
                            {
                                duplicateRow = false;
                                break;
                            }
                            if (duplicateRow)
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                                if (firstRow == null)
                                {
                                    firstRow = row;
                                }
                                //DataRow newRow;
                                //newRow = bsCopy.NewRow();

                                //for (int i = 0; i <= 13; i++)
                                //    newRow[i] = row.Cells[i].Value;

                                //bsCopy.Rows.Add(newRow);
                            }
                        }
                    }
                }
                if (firstRow != null)
                {
                    FocusOnRow(firstRow.Index - 1);
                }
                //dgvMeasurementResults.DataSource = bsCopy;
            }
            catch (Exception ex)
            {
                throw new Exception(ERROR_SAME_ROWS + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (cbDate.Checked)
                {
                    int rowIndex = -1;
                    DateTime date = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, dtpTime.Value.Hour, dtpTime.Value.Minute, 0);
                    foreach (DataGridViewRow row in dgvMeasurementResults.Rows)
                    {
                        if (row.Cells["Data"].Value != null && ((DateTime)(row.Cells["Data"].Value) == date))
                        {
                            rowIndex = row.Index;
                            break;
                        }

                    }
                    FocusOnRow(rowIndex);
                }
                else
                    MessageBox.Show(WARRNING_SELECT_TURBIN);

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

        private void dgvMeasurementResults_DataSourceChanged(object sender, EventArgs e)
        {
            GlobalMeasurements.GlobalDataTable = (DataTable)dgvMeasurementResults.DataSource;
        }


        private void dgvMeasurementResults_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (e.Button == MouseButtons.Right)
                {
                    dgvMeasurementResults.Rows[e.RowIndex].Selected = true;
                    rowIndex = e.RowIndex;
                    dgvMeasurementResults.CurrentCell = dgvMeasurementResults.Rows[e.RowIndex].Cells[2];
                    this.contextMenuStrip1.Show(dgvMeasurementResults, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
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

        private void dgvMeasurementResults_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvMeasurementResults.Rows[e.RowIndex].DefaultCellStyle.BackColor == Color.Red && dgvMeasurementResults.Columns["X1"].Index == e.ColumnIndex)
                {
                    dgvMeasurementResults.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        private void pustyWierszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                for (int currentCell = 3; currentCell < dgvMeasurementResults.Rows[rowIndex].Cells.Count; currentCell++)
                {
                    dgvMeasurementResults.Rows[rowIndex].Cells[currentCell].Value = 99999;
                }
                dgvMeasurementResults.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Yellow;
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

        private void btnSetZeroes_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                for (int currentRow = 0; currentRow < dgvMeasurementResults.Rows.Count - 1; currentRow++)
                {
                    if ((double)dgvMeasurementResults.Rows[currentRow].Cells["X1"].Value < 0)
                    {
                        dgvMeasurementResults.Rows[currentRow].Cells["X1"].Value = 0;
                    }
                    if ((double)dgvMeasurementResults.Rows[currentRow].Cells["X9"].Value < 0)
                    {
                        dgvMeasurementResults.Rows[currentRow].Cells["X9"].Value = 0;
                    }
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

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            cbDate.Checked = true;
        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
            cbDate.Checked = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (msg.Msg == 256)
            {
                if (keyData == (Keys.Control | Keys.S))
                {
                    SaveTempFile();
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //nie używana
        private void btnFiltration_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region metody
        private DataTable GetTableFromTempCsv(string path)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;
                string filePath = path;

                FileStream fileStream = File.Open(filePath, FileMode.Open, FileAccess.Read);
                IExcelDataReader reader;
                if (Path.GetExtension(fileStream.Name)==".csv")
                    reader = ExcelReaderFactory.CreateCsvReader(fileStream);
                else
                    reader = ExcelReaderFactory.CreateOpenXmlReader(fileStream);

                dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                    {
                        UseHeaderRow = true
                    }
                });
                reader.Close();
                DataTable clone = dataSet.Tables[0].Clone();
                for (int currentColumn = 0; currentColumn < dataSet.Tables[0].Columns.Count; currentColumn++)
                {
                    if( dataSet.Tables[0].Columns[currentColumn].ColumnName != "Data")
                        clone.Columns[currentColumn].DataType = typeof(Double);
                    else
                        clone.Columns[currentColumn].DataType = typeof(DateTime);
                }
                for(int currentRow = 0; currentRow < dataSet.Tables[0].Rows.Count; currentRow++)
                {
                    clone.ImportRow(dataSet.Tables[0].Rows[currentRow]);
                }
                //dataSet.Tables[0].Columns.RemoveAt(dataSet.Tables[0].Columns.Count);

                GlobalMeasurements.GlobalDataTable = clone;
                //dgvMeasurementResults.Sort(dgvMeasurementResults.Columns[0], ListSortDirection.Ascending);

                ShowElements();
               

                //flpFilterButtons.Visible = true;
                return clone;
            }
            catch (Exception ex)
            {
                throw new Exception(ERROR_FILE_OPEN + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        
        

        private void AddAutoIncrementColumn()
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.ValueType = System.Type.GetType("System.Int32");
            column.Name = "Lp.";
            dgvMeasurementResults.Columns.Insert(0, column);
            for(int counter = 0;counter < dgvMeasurementResults.RowCount; counter++)
            {
                dgvMeasurementResults.Rows[counter].Cells[0].Value = counter + 1;
            }
        }

        private DataTable AddSumColumn(DataTable dataSource)
        {
            DataColumn dataColumn = new DataColumn(X12);
            dataColumn.DataType = System.Type.GetType("System.Double");
            dataSource.Columns.Add(dataColumn);
            DataTable newTable = dataSource.Clone();
            foreach(DataRow row in dataSource.Rows)
            {
                if ((double)row[0] == (double)nmTrubin.Value && (DateTime)row[1] >= new DateTime(2012, 03, 17, 0, 10, 0))
                {
                    //for(int columnCounter = 2; columnCounter < dataSource.Columns.Count; columnCounter++)
                    //{
                    //    if()
                    //    row.ItemArray[columnCounter] = Math.Round((double)row.ItemArray[columnCounter],3);
                    //}
                    double x6ColumnValue = (double)row[X6];
                    double x8ColumnValue = (double)row[X8];
                    double x12ColumnValue = x6ColumnValue + x8ColumnValue < 360 ? x6ColumnValue + x8ColumnValue : x6ColumnValue + x8ColumnValue - 360;
                    x12ColumnValue = x12ColumnValue >= 0 ? x12ColumnValue : x12ColumnValue + 360;
                    row.SetField(X12, x12ColumnValue);
                    newTable.ImportRow(row);
                }                
            }
           
            return newTable;
        }

        private void FocusOnRow(int indexOfRow)
        {
            if(indexOfRow!=-1)
            {
                dgvMeasurementResults.ClearSelection();
                dgvMeasurementResults.Rows[indexOfRow].Selected = true;
                dgvMeasurementResults.FirstDisplayedScrollingRowIndex = indexOfRow;
                dgvMeasurementResults.Focus();
            }
        }

        private string GenerateCsv(DataTable datatable, char seperator)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < datatable.Columns.Count; i++)
            {
                sb.Append(datatable.Columns[i]);
                if (i < datatable.Columns.Count - 1)
                    sb.Append(seperator);
            }
            sb.AppendLine();
            foreach (DataRow dr in datatable.Rows)
            {
                for (int i = 0; i < datatable.Columns.Count; i++)
                {
                    if (i > 1)
                        sb.Append((Math.Round((double)dr[i],3)).ToString());
                    else
                        sb.Append(dr[i].ToString());

                    if (i < datatable.Columns.Count - 1)
                        sb.Append(seperator);
                }
                sb.AppendLine();
            }
            return sb.ToString();
            
        } 

        private void SaveTempFile()
        {
            try
            {
                if (string.IsNullOrEmpty(tbTempFolderPath.Text) || !Directory.Exists(tbTempFolderPath.Text))
                {
                    if (fbdCsv.ShowDialog() == DialogResult.OK)
                    {
                        tbTempFolderPath.Text = fbdCsv.SelectedPath;
                    }
                }
                this.Cursor = Cursors.WaitCursor;
                string path = Path.Combine(tbTempFolderPath.Text, TURBIN_STRING + dgvMeasurementResults.Rows[0].Cells[1].Value.ToString() + CSV_EXTENTION_STRING);
                string output = GenerateCsv((DataTable)dgvMeasurementResults.DataSource, SEPERATOR);
                System.IO.File.WriteAllText(path, output, System.Text.Encoding.UTF8);

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

        private void ShowElements()
        {
            this.btnGenerateCsv.Visible = this.btnSearchEmptyRows.Visible = this.btnSearchMissingRows.Visible = this.btnSearchTheSameValues.Visible  = this.flowLayoutPanel3.Visible = pnFolderPath.Visible = true;
        }

        private void SetColumnsToThreeDecimalPlaces()
        {
            for (int currentColumn = 3; currentColumn < dgvMeasurementResults.Columns.Count; currentColumn++)
            {
                dgvMeasurementResults.Columns[currentColumn].DefaultCellStyle.Format = "N3";
                dgvMeasurementResults.Columns[currentColumn].DefaultCellStyle.NullValue = 99999;
            }
        }
        #endregion

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace CSAY_UTMLatLongConverter
{
    public partial class FrmLatLongToUTM : Form
    {
        int i, n;
        string path;
        bool CalcZone=false, CalcCM = false;
        /* For Everest Nagarkot 1830 (Nepal)
             a = 6377276.345
             b = 6356075.413
             f = 1/300.8017 */

        /* For WGS 84 
         a = 6378137.0
         b = 6356752.314 
         f = 298.2572201 */

        private void CalculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculateLatLongToXY();
        }
        
             

        public FrmLatLongToUTM()
        {
            InitializeComponent();
        }

        private void TxtFlatening_TextChanged(object sender, EventArgs e)
        {

        }

        private void EXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtLatOrigin.Text = 0.ToString();   //phi0
            TxtCM.Text = 81.ToString();         //lambda0

            TxtSemiMajorAxis.Text = 6371837.ToString();     //a
            TxtFlatening.Text = 298.257223563.ToString();   //1_by_f

            TxtK0.Text = 0.9996.ToString();         //K0
            TxtM0.Text = 0.ToString();              //M0

            TxtFalseE.Text = 500000.ToString();     //X
            TxtFalseN.Text = 0.ToString();          //Y
        }

        private void FrmLatLongToUTM_Load(object sender, EventArgs e)
        {
            AddElementToComboBoxProjection();
            AddElementToComboBoxDatum();
            AddElementToComboBoxCMZone();
            SetGridColorAndFont();
        }

        private void AddElementToComboBoxProjection()
        {
            ComboBoxProjection.Items.Add("Select Projection");

            ComboBoxProjection.Items.Add("UTM");
            //ComboBoxProjection.Items.Add("MUTM");
        }

        private void AddElementToComboBoxDatum()
        {
            ComboBoxDatum.Items.Add("Select Datum");

            ComboBoxDatum.Items.Add("WGS 1984");
            //ComboBoxDatum.Items.Add("Everest Nagarkot 1830");
        }
        private void AddElementToComboBoxCMZone()
        {
            ComboBoxCMZone.Items.Add("Select CM or Zone");
            ComboBoxCMZone.Items.Add("Central Meridian");
            ComboBoxCMZone.Items.Add("Zone");
        }
        public void SetGridColorAndFont()
        {
            this.DataGridViewMusking.DefaultCellStyle.Font = new Font("Comic Sans MS", 12);
            this.DataGridViewMusking.DefaultCellStyle.ForeColor = Color.Black;
            this.DataGridViewMusking.DefaultCellStyle.SelectionForeColor = Color.White;
            this.DataGridViewMusking.DefaultCellStyle.SelectionBackColor = Color.Purple;

        }

        private void TxtNumber_TextChanged(object sender, EventArgs e)
        {
            Generaterows();
        }

        public void Generaterows()
        {
            try
            {
                n = Convert.ToInt32(TxtNumber.Text);
            }
            catch
            {
                //MessageBox.Show("Del_t or N missing !!!");
            }
            DataGridViewMusking.Rows.Clear();

            for (i = 0; i < n; i++)
            {
                i = DataGridViewMusking.Rows.Add();
                DataGridViewMusking.Rows[i].Cells[0].Value = i + 1;

            }
        
        }

        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created in C# \nCreated by Ajay Yadav \nRequirement: Dot Net Framwork 4.5+");
        }

        private void IMPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Filter = "Excel Sheet(*.xlsx)|*.xlsx|Excel Sheet(*.xls)|*.xls|All Files(*.*)|*.*";
            openfiledialog1.FilterIndex = 1;

            if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openfiledialog1.FileName;
            }
            else if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;

            DataGridViewMusking.DataSource = null;

            for (int j = 0; j < DataGridViewMusking.Rows.Count - 1; j++)
            {
                DataGridViewMusking.Rows.RemoveAt(j);
                j--;
                while (DataGridViewMusking.Rows.Count == 0)
                    continue;
            }

            Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbooks workbooks = app.Workbooks;

            Excel.Workbook workbook = workbooks.Open(path);
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            try
            {
                //int rcount = worksheet.UsedRange.Rows.Count;
                int rcount = n;
                int i;

                for (i = 0; i < rcount; i++)
                {
                    DataGridViewMusking.Rows.Add();
                    DataGridViewMusking.Rows[i].Cells["ColSN"].Value = worksheet.Cells[i + 2, 1].value;
                    DataGridViewMusking.Rows[i].Cells["ColLatitude"].Value = worksheet.Cells[i + 2, 2].value;
                    DataGridViewMusking.Rows[i].Cells["ColLongitude"].Value = worksheet.Cells[i + 2, 3].value;
                    
                    //worksheet.cells[rows, column].value; here rows column starts from 1 and rows starts from 1 of excel.
                }

                workbook.Close();
                app.Quit();
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(workbooks);
                Marshal.ReleaseComObject(worksheet);
                // Marshal.ReleaseComObject(rcount);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                workbook.Close();
                app.Quit();
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(workbooks);
                Marshal.ReleaseComObject(worksheet);
            }
            MessageBox.Show("IMPORT COMPLETE !");
        }

        private void CopyAlltoClipboard()
        {
            DataGridViewMusking.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            DataGridViewMusking.MultiSelect = true;
            DataGridViewMusking.SelectAll();
            DataObject dataObj = DataGridViewMusking.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void AllGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CopyAlltoClipboard();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "LatLong To XY in UTM WGS 84 " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                //((Excel.Range)xlWorkSheet.Cells[2, 1]).Value = "Projection system";
                //value of IMS in Cell[1,2]
                //((Excel.Range)xlWorkSheet.Cells[2, 2]).Value = "UTM WGS 84";


                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[3, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                // xlWorkBook.Close();
                //  xlexcel.Quit();
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlWorkSheet);

                MessageBox.Show("Export Completed Sucessfully.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void CopySelectedtoClipboard()
        {
            DataGridViewMusking.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            DataGridViewMusking.MultiSelect = true;
            //dataGridViewMusking.SelectAll();
            DataObject dataObj = DataGridViewMusking.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void SelectedGridOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CopySelectedtoClipboard();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "LatLong To XY in UTM WGS 84 " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                //((Excel.Range)xlWorkSheet.Cells[2, 1]).Value = "Projection system";
                //value of IMS in Cell[1,2]
                //((Excel.Range)xlWorkSheet.Cells[2, 2]).Value = "UTM WGS 84";


                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[3, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                // xlWorkBook.Close();
                //  xlexcel.Quit();
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlWorkSheet);

                MessageBox.Show("Export Completed Sucessfully.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void CopyFromGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CopySelectedtoClipboard();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void PasteToGidCellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridViewMusking.SelectedCells.Count < 1) return;

                string[] lines;

                int row = DataGridViewMusking.SelectedCells[0].RowIndex;
                int col = DataGridViewMusking.SelectedCells[0].ColumnIndex;

                //get copied values
                lines = Clipboard.GetText().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                string[] values;
                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].Split('\t');

                    if (row >= DataGridViewMusking.Rows.Count || DataGridViewMusking.Rows[row].IsNewRow) continue;
                    //if (row >= dataGridViewMusking.Rows.Count || dataGridViewMusking.Rows[row].IsNewRow) dataGridViewMusking.Rows.Add();
                    for (int j = 0; j < values.Length; j++)
                    {
                        if (col + j >= DataGridViewMusking.Columns.Count) continue;
                        DataGridViewMusking.Rows[row].Cells[col + j].Value = values[j];
                    }

                    row++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void RemoveOneSelectedRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int row = DataGridViewMusking.CurrentCell.RowIndex;
                DataGridViewMusking.Rows.RemoveAt(row);
                DataGridViewMusking.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearValueOfSelectedCellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewCell cell in DataGridViewMusking.SelectedCells)
                {
                    string i = "";
                    cell.Value = (object)i;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveAllGridsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewMusking.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Created in C# \nVersion 1.0\nAjay Yadav\nRequirement: Dot Net Framework Required : 4.6.1\nIt is Accurate to about a centimeter at 7° of longitude from the central meridian","About");
        }

        private void ComboBoxProjection_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblProjectionMsg.Text = "Projection:  " + ComboBoxProjection.Text;
            if (ComboBoxProjection.Text == "Select Projection")
            {
                TxtLatOrigin.Text = "";

                TxtK0.Text = "";
                TxtM0.Text = "";

                TxtFalseE.Text = "";
                TxtFalseN.Text = "";
            }

            if (ComboBoxProjection.Text == "UTM")
            {
                TxtLatOrigin.Text = (0).ToString();

                TxtK0.Text = (0.9996).ToString();
                TxtM0.Text = (0).ToString();

                TxtFalseE.Text = (500000).ToString();
                TxtFalseN.Text = (0).ToString();
            }

            if (ComboBoxProjection.Text == "MUTM")
            {
                TxtLatOrigin.Text = (0).ToString();

                TxtK0.Text = (0.9999).ToString();
                TxtM0.Text = (0).ToString();

                TxtFalseE.Text = (500000).ToString();
                TxtFalseN.Text = (0).ToString();
            }

        }

        private void ComboBoxDatum_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblDatumMsg.Text = "Datum:  " + ComboBoxDatum.Text;
            if (ComboBoxDatum.Text == "Select Datum")
            {
                TxtSemiMajorAxis.Text = "";
                TxtFlatening.Text = "";
            }

            if (ComboBoxDatum.Text == "WGS 1984")
            {
                TxtSemiMajorAxis.Text = (6378137.0).ToString();
                TxtFlatening.Text = (298.2572201).ToString();
            }

            if (ComboBoxDatum.Text == "Everest Nagarkot 1830")
            {
                TxtSemiMajorAxis.Text = (6377276.345).ToString();
                TxtFlatening.Text = (300.80).ToString();
            }
        }

        private void DataGridViewMusking_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the Data format of the file(s) can be accepted
            // (we only accept file drops from Windows Explorer, etc.)
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // modify the drag drop effects to Move
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                // no need for any drag drop effect
                e.Effect = DragDropEffects.None;
            }
        }

        private void DataGridViewMusking_DragDrop(object sender, DragEventArgs e)
        {
            // still check if the associated data from the file(s) can be used for this purpose
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Fetch the file(s) names with full path here to be processed
                string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop);
                path = fileList[0];
                // Your desired code goes here to process the file(s) being dropped
                
                DataGridViewMusking.DataSource = null;

                for (int j = 0; j < DataGridViewMusking.Rows.Count - 1; j++)
                {
                    DataGridViewMusking.Rows.RemoveAt(j);
                    j--;
                    while (DataGridViewMusking.Rows.Count == 0)
                        continue;
                }

                Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Excel.Workbooks workbooks = app.Workbooks;

                Excel.Workbook workbook = workbooks.Open(path);
                Excel.Worksheet worksheet = workbook.ActiveSheet;
                try
                {
                    //int rcount = worksheet.UsedRange.Rows.Count;
                    int rcount = n;
                    int i;

                    for (i = 0; i < rcount; i++)
                    {
                        DataGridViewMusking.Rows.Add();
                        DataGridViewMusking.Rows[i].Cells["ColSN"].Value = worksheet.Cells[i + 2, 1].value;
                        DataGridViewMusking.Rows[i].Cells["ColLatitude"].Value = worksheet.Cells[i + 2, 2].value;
                        DataGridViewMusking.Rows[i].Cells["ColLongitude"].Value = worksheet.Cells[i + 2, 3].value;

                        //worksheet.cells[rows, column].value; here rows column starts from 1 and rows starts from 1 of excel.
                    }

                    workbook.Close();
                    app.Quit();
                    Marshal.ReleaseComObject(workbook);
                    Marshal.ReleaseComObject(workbooks);
                    Marshal.ReleaseComObject(worksheet);
                    // Marshal.ReleaseComObject(rcount);

                }
                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    workbook.Close();
                    app.Quit();
                    Marshal.ReleaseComObject(workbook);
                    Marshal.ReleaseComObject(workbooks);
                    Marshal.ReleaseComObject(worksheet);
                }
                MessageBox.Show("IMPORT COMPLETE !");
            }
        }

        private void ComboBoxCMZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxCMZone.Text == "Select CM or Zone")
            {
                TxtCM.ReadOnly = true;
                TxtZone.ReadOnly = true;
                CalcCM = false;
                CalcZone = false;
            }

            if (ComboBoxCMZone.Text == "Central Meridian")
            {
                TxtZone.ReadOnly = true;
                TxtCM.ReadOnly = false;
                CalcZone = true;
                CalcCM = false;
            }

            if(ComboBoxCMZone.Text == "Zone")
            {
                TxtCM.ReadOnly = true;
                TxtZone.ReadOnly = false;
                CalcZone = false;
                CalcCM = true;
            }
        }

        private void TxtZone_TextChanged(object sender, EventArgs e)
        {
            int tempCM, tempZone;
            try
            {
                if(CalcCM == true)
                {
                    tempZone = Convert.ToInt32(TxtZone.Text);
                    tempCM = tempZone * 6 - 180 - 3;
                    TxtCM.Text = tempCM.ToString();
                }
            }
            catch
            {

            }
            
        }

        private void TxtCM_TextChanged(object sender, EventArgs e)
        {
            int tempCM, tempZone;
            try
            {
                if(CalcZone == true)
                {
                    tempCM = Convert.ToInt32(TxtCM.Text);
                    tempZone = (tempCM + 3 + 180) / 6;
                    TxtZone.Text = tempZone.ToString();
                }
            }
            catch
            {

            }
        }

        public void CalculateLatLongToXY()
        {
            try
            {
                var phi0_DD = Convert.ToDouble(TxtLatOrigin.Text);
                var lambda0_DD = Convert.ToDouble(TxtCM.Text);

                var a = Convert.ToDouble(TxtSemiMajorAxis.Text);
                var one_by_f = Convert.ToDouble(TxtFlatening.Text);

                var K0 = Convert.ToDouble(TxtK0.Text);
                var M0 = Convert.ToDouble(TxtM0.Text);

                var false_Easting = Convert.ToDouble(TxtFalseE.Text);
                var false_Northing = Convert.ToDouble(TxtFalseN.Text);

                // conversion
                var f = 1 / one_by_f;
                var phi0 = phi0_DD * Math.PI / 180;
                var lambda0 = lambda0_DD * Math.PI / 180;

                for(i = 0;  i < n; i++)
                {
                    var Phi_DD = Convert.ToDouble(DataGridViewMusking.Rows[i].Cells[1].Value); //latitude column
                    var Phi = Phi_DD * Math.PI / 180;

                    var Lambda_DD = Convert.ToDouble(DataGridViewMusking.Rows[i].Cells[2].Value); //longitude column
                    var Lambda = Lambda_DD * Math.PI / 180;
                    
                    var e2 = 2 * f - f * f; 
                    var e_prime2 = e2 / (1 - e2);
                    var RM = a * (1 - e2) /Math.Pow((1 - e2 * Math.Pow(Math.Sin(Phi),2)),3/2);
                    var RN = a / Math.Sqrt(1 - e2 * Math.Sin(Phi) * Math.Sin(Phi)); 
                    var  T = Math.Tan(Phi) * Math.Tan(Phi);
                    var C = e_prime2 * Math.Cos(Phi) * Math.Cos(Phi);
                    var A1 = (Lambda - lambda0) * Math.Cos(Phi);
                    var M_term1 = (1 - e2 / 4 - 3 * e2 * e2 / 64 - 5 * e2 * e2 * e2 / 256) * Phi;
                    var M_term2 = (3 * e2 / 8 + 3 * e2 * e2 / 32 + 45 * e2 * e2 * e2 / 1024) * Math.Sin(2 * Phi);
                    var M_term3 = (15 * e2 * e2 / 256 + 45 * e2 * e2 * e2 / 1024) * Math.Sin(4 * Phi);
                    var M_term4 = (35 * e2 * e2 * e2 / 3072) * Math.Sin(6 * Phi);
                    var M = a * (M_term1 - M_term2 + M_term3 - M_term4);


                    var X_term1 = (1 - T + C) * A1 * A1 * A1 / 6;
                    var X_term2 = (5 - 18 * T + T * T + 72 * C - 58 * e_prime2) * Math.Pow(A1, 5)/6;

                    var Easting_X = K0 * RN * (A1 + X_term1 + X_term2) + 500000;             //x coordinate

                    var Y_term1 = (5 - T + 9 * C + 4 * C * C) * Math.Pow(A1, 4)/24;
                    
                    //TxtMessage.Text = (Math.Pow(A1, three_by_6)).ToString();
                    //MessageBox.Show(X_term2.ToString());

                    var Y_term2 = (61 - 58 * T + T * T + 600 * C - 330 * e_prime2) *Math.Pow(A1, 6)/720;
                    var Northing_Y = K0 * (M - M0 + RN * Math.Tan(Phi) * (A1 * A1 / 2 + Y_term1 + Y_term2)); // y coordinate

                    DataGridViewMusking.Rows[i].Cells[3].Value = Easting_X.ToString("0.000");
                    DataGridViewMusking.Rows[i].Cells[4].Value = Northing_Y.ToString("0.000");

                }
            }
            catch
            {

            }
        }
    }
}

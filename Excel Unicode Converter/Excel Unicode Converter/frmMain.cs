using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace Excel_Unicode_Converter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            //===========================================================================
            //===========================================================================
            InitializeComponent();
            //===========================================================================
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //===========================================================================
            //===========================================================================
            optNoIncrease.Checked = true;

            nudIncrease.Enabled = false;
            nudDecrease.Enabled = false;

            optNoIncrease.Enabled = false;
            optIncrease.Enabled = false;
            optDecrease.Enabled = false;

            cmdSave.Enabled = false;
            cmdConvert.Enabled = false;
            //===========================================================================
        }

        private void TxtSource_TextChanged(object sender, EventArgs e)
        {
            //===========================================================================
            //===========================================================================
            if (txtSource.Text.Length > 0)
                cmdSave.Enabled = true;
            else
                cmdSave.Enabled = false;
            //===========================================================================
        }

        private void CmdBrowse_Click(object sender, EventArgs e)
        {
            //===========================================================================
            //===========================================================================
            System.Windows.Forms.OpenFileDialog dlgOnpenFile = new OpenFileDialog();
            System.Windows.Forms.OpenFileDialog dlgFileOpen = new System.Windows.Forms.OpenFileDialog();

            dlgFileOpen.Title = "Open Microsoft Excel file";

            dlgFileOpen.RestoreDirectory = true;
            dlgFileOpen.DefaultExt = "xlsx";
            dlgFileOpen.Filter = "Microsoft Excel 2007-2021 Workbooks (*.xlsx)|*xlsx|" +
                                    "Microsoft Excel Macro Enable Workbooks (*.xlsm)|*xlsm|" +
                                    "Microsoft Excel 97-2003 Workbooks (*.xls)|*xls";

            if (dlgFileOpen.ShowDialog() == DialogResult.OK)
                txtSource.Text = dlgFileOpen.FileName;
            else
                txtSource.Text = "";
            //===========================================================================
        }

        private void TxtNewFile_TextChanged(object sender, EventArgs e)
        {
            //===========================================================================
            //===========================================================================
            if (txtNewFile.Text.Length > 0)
            {
                optNoIncrease.Enabled = true;
                optIncrease.Enabled = true;
                optDecrease.Enabled = true;

                cmdConvert.Enabled = true;
            }
            else
            {
                optNoIncrease.Checked = true;

                nudIncrease.Enabled = false;
                nudDecrease.Enabled = false;

                optNoIncrease.Enabled = false;
                optIncrease.Enabled = false;
                optDecrease.Enabled = false;
                
                cmdConvert.Enabled = false;
            }
            //===========================================================================
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            //===========================================================================
            //===========================================================================
            System.Windows.Forms.SaveFileDialog dlgFileSave = new System.Windows.Forms.SaveFileDialog();

            dlgFileSave.RestoreDirectory = true;
            dlgFileSave.Title = "Save as Microsoft Excel Workbooks";
            dlgFileSave.DefaultExt = "xlsx";
            dlgFileSave.Filter = "Microsoft Excel 2007-2021 Workbooks (*.xlsx)|*xlsx|" +
                                    "Microsoft Excel Macro Enable Workbooks (*.xlsm)|*xlsm|" +
                                    "Microsoft Excel 97-2003 Workbooks (*.xls)|*xls";

            if (dlgFileSave.ShowDialog() == DialogResult.OK)
                txtNewFile.Text = dlgFileSave.FileName;
            else
                txtNewFile.Text = "";
            //===========================================================================
        }

        private void OptNoIncrease_CheckedChanged(object sender, EventArgs e)
        {
            //===========================================================================
            //===========================================================================
            nudIncrease.Enabled = false;
            nudDecrease.Enabled = false;
            //===========================================================================
        }

        private void OptIncrease_CheckedChanged(object sender, EventArgs e)
        {
            //===========================================================================
            //===========================================================================
            nudIncrease.Enabled = true;
            nudDecrease.Enabled = false;
            //===========================================================================
        }

        private void OptDecrease_CheckedChanged(object sender, EventArgs e)
        {
            //===========================================================================
            //===========================================================================
            nudIncrease.Enabled = false;
            nudDecrease.Enabled = true;
            //===========================================================================
        }

        private void CmdConvert_Click(object sender, EventArgs e)
        {
            //===========================================================================
            //===========================================================================
            nudIncrease.Enabled = false;
            nudDecrease.Enabled = false;

            optNoIncrease.Enabled = false;
            optIncrease.Enabled = false;
            optDecrease.Enabled = false;

            cmdBrowse.Enabled = false;
            cmdSave.Enabled = false;
            cmdConvert.Enabled = false;
            cmdClose.Enabled = false;

            Convert2Unicode(txtSource.Text, txtNewFile.Text);
            //===========================================================================
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            //===========================================================================
            //===========================================================================
            Application.Exit();
            //===========================================================================
        }

        private void Convert2Unicode(String sourcePathName, String newPathName)
        {
            //===========================================================================
            //===========================================================================
            long counter = 0;
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook sourceWorkbook = excelApp.Workbooks.Open(sourcePathName);
            // Start to show Wait-Cursor
            ShowWaitCursor(true);

            // Loop through all Worksheets
            foreach (Excel.Worksheet sourceWorksheet in sourceWorkbook.Sheets)
            {
                Excel.Range usedRange = sourceWorksheet.UsedRange;
                // Loop through all Cells
                foreach (Excel.Range cell in usedRange)
                { 
                    if (cell.Font.Name == "Zawgyi-One")
                    {
                        // Change Font
                        cell.Font.Name = "Pyidaungsu";
                        // Change Font Size
                        if (optIncrease.Checked)
                            cell.Font.Size = cell.Font.Size + Convert.ToInt16(nudIncrease.Value);
                        else if (optDecrease.Checked)
                            cell.Font.Size = cell.Font.Size - Convert.ToInt16(nudDecrease.Value);
                        // Convert Text from Zawgyi-One to Pyidaungsu
                        cell.Value = UnicodeConverter.ConvertFromZawGyi(Convert.ToString(cell.Value));
                        // Increase converted Cells counter
                        counter++;
                    }
                }
            }
            // Save Workbook wiith new name
            sourceWorkbook.SaveAs(newPathName);
            // Close Workbook and Release Workbook Resources
            sourceWorkbook.Close();
            Marshal.ReleaseComObject(sourceWorkbook);
            // Close Excel Application and Release Application Resources
            excelApp.Quit();
            Marshal.ReleaseComObject(excelApp);
            // Stop showing Wait-Cursor
            ShowWaitCursor(false);

            MessageBox.Show(this, "Conversion from Zawgyi-One to Pyidaungsu was successfully finished./n/n" +
                counter.ToString() + " Cells were converted.",
                Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmdBrowse.Enabled = true;
            cmdClose.Enabled = true;
            //===========================================================================
        }

        private void ShowWaitCursor(Boolean bShow)
        {
            //=================================================================================
            // Set WaitCursor or reset to Default Cursor
            //=================================================================================
            foreach (System.Windows.Forms.Control ctlBuff in this.Controls)
            {
                if (bShow == true)
                {
                    // Change to wait cursor
                    this.Cursor = Cursors.WaitCursor;
                    ctlBuff.Cursor = Cursors.WaitCursor;
                }
                else
                {
                    // Change to default cursor
                    this.Cursor = Cursors.Default;
                    ctlBuff.Cursor = Cursors.Default;
                }
            }
            //=================================================================================
        }
    }
}

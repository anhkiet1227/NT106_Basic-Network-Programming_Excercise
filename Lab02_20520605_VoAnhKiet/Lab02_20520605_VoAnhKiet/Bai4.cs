using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using NsExcel = Microsoft.Office.Interop.Excel;

namespace Lab02_20520605_VoAnhKiet
{
    
    public partial class Bai4 : Form
    {
        
        public Bai4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new getStudentData().Show();
        }
      
        public void ListToExcel(string excelFileName, List<string[]> list)
        {
            var xlApp = new Excel.Application();
            var xlWorkBook = xlApp.Workbooks.Add();
            var xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.Item[1];
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Length; j++)
                {
                    xlWorkSheet.Cells[i + 1, j + 1].Value = list[i][j];
                }
            }
            xlWorkSheet.SaveAs(excelFileName); 
            xlWorkBook.Close(true);
            xlApp.Quit();
        }

        public void ExcelToList(string excelFileName, List<string[]> list)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(excelFileName);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            for (int i = 1; i <= rowCount; i++)
            {
                string[] row = new string[colCount];
                for (int j = 1; j <= colCount; j++)
                {
                    row[j - 1] = xlRange.Cells[i, j].Value2.ToString();
                }
                list.Add(row);
            }

            xlWorkbook.Close();
            xlApp.Quit();

            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            Marshal.ReleaseComObject(xlWorkbook);
            Marshal.ReleaseComObject(xlApp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            string content = sr.ReadToEnd();
            content = content.Substring(0, content.LastIndexOf('\n'));
            string[] subcontent = content.Split('\n');
            List<string[]> dataShow = new List<string[]>();
            for (int i = 0; i < subcontent.Length; i++)
            {
                string repo1 = subcontent[i].ToString();
                string[] repo2 = repo1.Split(';');
                double tb = (Convert.ToDouble(repo2[3]) + Convert.ToDouble(repo2[4])) / 2;
                string tbtext = tb.ToString();
                string tmp = repo1 + ";" + tbtext;
                string[] repo3 = tmp.Split(';');
                dataShow.Add(repo3);
            }
            ListToExcel("C:\\Users\\ACER\\Downloads\\exceltest.xlsx", dataShow);
            sr.Close();
            fs.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string[]> dataFile = new List<string[]>();
            ExcelToList("C:\\Users\\ACER\\Downloads\\exceltest.xlsx", dataFile);
            richTextBox1.Text = "";
            foreach (string[] row in dataFile)
            {
                foreach (string cell in row)
                {
                    richTextBox1.Text += cell + " ";
                }
                richTextBox1.Text += "\n";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using excell= Microsoft.Office.Interop.Excel;

namespace library
{
    public partial class excel : Form
    {
     
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=library.mdb");
        public excel()
        {
            InitializeComponent();
        }

        private void aktar_Click(object sender, EventArgs e)
        {
            //

            //  excell.Application excel = new excell.Application();
            //  excel.Visible = true;
            //  object Missing = Type.Missing;
            //  Workbook workbook = excel.Workbooks.Add(Missing);
            //  Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            //   int StartCol = 1;
            //   int StartRow = 1;
            //  for (int j = 0; j & lt; dataGridView1.Columns.Count; j++)
            //    {
            //       Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
            //     myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            //     }
            //      StartRow++;
            //     for (int i = 0; i & lt; dataGridView1.Rows.Count; i++)
            //     {
            //     for (int j = 0; j & lt; dataGridView1.Columns.Count; j++)
            //         {
            //
            //     Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
            //     myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
            //             myRange.Select();


            // }
            //  }



        }

        private void excel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.kitaplar' table. You can move, or remove it, as needed.
            this.kitaplarTableAdapter.Fill(this.libraryDataSet.kitaplar);
           

        }
    }
}

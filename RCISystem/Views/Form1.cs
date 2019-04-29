using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCISystem.Views
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Add(false, "1");
            //dataGridView1.Rows.Add(true, "2");

            {
               // dataGridView1.ColumnCount = 1;
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                dataGridView1.Columns.Add(chk);
                chk.HeaderText = "Check Data";
                chk.Name = "chk";

                dataGridView1.Columns.Add("column1", "column1");
                dataGridView1.Columns.Add("column2", "column2");
                dataGridView1.Columns.Add("column3", "column3");
                //dataGridView1.Rows[2].Cells[3].Value = true;
                DataGridViewCheckBoxColumn chk1 = new DataGridViewCheckBoxColumn();
                dataGridView1.Columns.Add(chk1);
                chk1.HeaderText = "Check Data";
                chk1.Name = "chk1";
                dataGridView1.Rows.Add(true , "1");
                dataGridView1.Rows.Add(false, "2");

                ////dataGridView1.ColumnCount = 3;
                //dataGridView1.Columns[1].Name = "Product ID";
                //dataGridView1.Columns[2].Name = "Product Name";
                //dataGridView1.Columns[3].Name = "Product Price";

                //string[] row = new string[] { "", "1", "Product 1", "1000" };
                //dataGridView1.Rows.Add(row);
                //row = new string[] { "", "2", "Product 2", "2000" };
                //dataGridView1.Rows.Add(row);
                //row = new string[] { "", "3", "Product 3", "3000" };
                //dataGridView1.Rows.Add(row);
                //row = new string[] { "", "4", "Product 4", "4000" };
                //dataGridView1.Rows.Add(row);


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

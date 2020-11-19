using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRINTER_CENTER
{
    public partial class InkForm : Form
    {
        const string ConnectionString = @"Data Source=TANIA;Initial Catalog=Printing;Integrated Security=True";
        private bool edit = true;
        public InkForm()
        {
            InitializeComponent();
            dataGridViewInk.DataSource = inkBindingSource;
            textBox1.Text = "";
            textBox2.Text = "";
            toolStripTextBox4.Text = "";
        }

        private void InkForm_Load(object sender, EventArgs e)
        {
            dataGridViewInk.DataSource = inkBindingSource;
            textBox1.Text = "";
            textBox2.Text = "";
            toolStripTextBox4.Text = "";
            // TODO: This line of code loads data into the 'printingDataSet.Ink' table. You can move, or remove it, as needed.
            this.inkTableAdapter.Fill(this.printingDataSet.Ink);

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var edt = new InkEdit();
            edt.ShowDialog();
            dataGridViewInk.DataSource = inkBindingSource;
            textBox1.Text = "";
            textBox2.Text = "";
            toolStripTextBox4.Text = "";
            inkTableAdapter.Fill(printingDataSet.Ink);
            printingDataSet.AcceptChanges();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var st = new PrintingDataSet.InkDataTable();
            inkTableAdapter.FillBy(st,
            Convert.ToInt32(dataGridViewInk.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var edt = new InkEdit(
            Convert.ToInt32(row[0]),
            row[1].ToString(),
            Convert.ToDecimal(row[2])
            );
            edt.ShowDialog();
            dataGridViewInk.DataSource = inkBindingSource;
            textBox1.Text = "";
            textBox2.Text = "";
            toolStripTextBox4.Text = "";
            inkTableAdapter.Fill(printingDataSet.Ink);
            printingDataSet.AcceptChanges();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this?", "Delete Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                string s = String.Format("select CASE WHEN sum(books.bookid) is not NULL THEN " +
                    "sum(books.bookid) Else 0 END from books " +
                    "inner join ink on ink.inkid = books.inkid where ink.inkid = {0}", 
                    dataGridViewInk.SelectedRows[0].Cells[0].Value);
                SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                //dataGridViewInk.DataSource = dt;
                
                sqlconn.Close();
                if (Convert.ToInt32(dt.Rows[0][0]) == 0)
                {

                    if (!edit) return;
                    inkTableAdapter.DeleteQuery(
                    Convert.ToInt32(dataGridViewInk.SelectedRows[0].Cells[0].Value)
                    );
                    dataGridViewInk.DataSource = inkBindingSource;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    toolStripTextBox4.Text = "";
                    inkTableAdapter.Fill(printingDataSet.Ink);
                    printingDataSet.AcceptChanges();
                }
                else
                {
                    MessageBox.Show("This ink is used in books, change the value " +
                        "of ink type in all books to delete this item", "Impossible " +
                        "operation", MessageBoxButtons.OK);
                }
            }
        }
        bool CheckIfNumber(string s)
        {
            if (s == "") return false;
            int k1 = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                if ((s[i] > '9' || s[i] < '0') && (s[i] != '.'))
                    return false;
                if (s[i] == '.')
                    k1++;
            }
            if (k1 > 1)
                return false;
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckIfNumber(textBox1.Text) == false ||
                CheckIfNumber(textBox2.Text) == false)
            {
                MessageBox.Show("Enter valid price", "Invalid data", MessageBoxButtons.OK);
            }
            else
            {
            Decimal x1 = Convert.ToDecimal(textBox1.Text);
            Decimal x2 = Convert.ToDecimal(textBox2.Text);
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select * from ink where ink.price >= {0} and ink.price <= {1}", x1, x2);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridViewInk.DataSource = dt;
            sqlconn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewInk.DataSource = inkBindingSource;
            this.inkTableAdapter.Fill(this.printingDataSet.Ink);
        }

        private void toolStripTextBox4_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string x = toolStripTextBox4.Text;
            string s = String.Format("select * from ink where ink.inkname like '{0}%'", x);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridViewInk.DataSource = dt;
            sqlconn.Close();
            // this.inkBindingSource.Filter = "CONVERT(InkName, 'System.String') LIKE '%" +
            //    toolStripTextBox4.Text + "%'";
        }

        private void byInkIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select * from ink order by ink.inkid");
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridViewInk.DataSource = dt;
            sqlconn.Close();
            //dataGridViewInk.Sort(dataGridViewInk.Columns[0], ListSortDirection.Ascending);
        }

        private void byPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select * from ink order by ink.price");
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridViewInk.DataSource = dt;
            sqlconn.Close();
        }
    }
}

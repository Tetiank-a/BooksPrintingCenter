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
    public partial class PaperForm : Form
    {
        const string ConnectionString = @"Data Source=TANIA;Initial Catalog=Printing;Integrated Security=True";
        private bool edit = true;
        public PaperForm()
        {
            InitializeComponent();
            dataGridViewPaper.DataSource = paperBindingSource;
            Ziro();
        }

        private void Ziro()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            toolStripTextBox4.Text = "";
            toolStripTextBox1.Text = "";
        }

        private void PaperForm_Load(object sender, EventArgs e)
        {
            dataGridViewPaper.DataSource = paperBindingSource;
            Ziro();
            // TODO: This line of code loads data into the 'printingDataSet.Paper' table. You can move, or remove it, as needed.
            this.paperTableAdapter.Fill(this.printingDataSet.Paper);

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var edt = new PaperEdit();
            edt.ShowDialog();
            dataGridViewPaper.DataSource = paperBindingSource;
            Ziro();
            paperTableAdapter.Fill(printingDataSet.Paper);
            printingDataSet.AcceptChanges();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var st = new PrintingDataSet.PaperDataTable();
            paperTableAdapter.FillBy(st,
            Convert.ToInt32(dataGridViewPaper.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var edt = new PaperEdit(
            Convert.ToInt32(row[0]),
            row[1].ToString(),
            row[2].ToString(),
            Convert.ToDecimal(row[3])
            );
            edt.ShowDialog();
            dataGridViewPaper.DataSource = paperBindingSource;
            Ziro();
            paperTableAdapter.Fill(printingDataSet.Paper);
            printingDataSet.AcceptChanges();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this?", "Delete Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                string s = String.Format("select count(books.bookid) from paper left " +
                    "join books on books.PaperId = Paper.PaperId group by Paper.PaperId " +
                    "having Paper.PaperId = {0}",
                    dataGridViewPaper.SelectedRows[0].Cells[0].Value);
                SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                //dataGridViewInk.DataSource = dt;

                sqlconn.Close();
                if (Convert.ToInt32(dt.Rows[0][0]) == 0)
                {
                    if (!edit) return;
                    paperTableAdapter.DeleteQuery(
                    Convert.ToInt32(dataGridViewPaper.SelectedRows[0].Cells[0].Value)
                    );
                    dataGridViewPaper.DataSource = paperBindingSource;
                    Ziro();
                    paperTableAdapter.Fill(printingDataSet.Paper);
                    printingDataSet.AcceptChanges();
                }
                else
                {
                    MessageBox.Show("This paper is used in books, change the value " +
                        "of paper type in all books to delete this item", "Impossible " +
                        "operation", MessageBoxButtons.OK);
                }
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string x = toolStripTextBox1.Text;
            string y = toolStripTextBox4.Text;
            string s = String.Format("select * from paper where paper.size like '%{0}%' and paper.papername like '%{1}%'", x, y);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridViewPaper.DataSource = dt;
            sqlconn.Close();
        }

        private void toolStripTextBox4_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string x = toolStripTextBox1.Text;
            string y = toolStripTextBox4.Text;
            string s = String.Format("select * from paper where paper.size like '%{0}%' and paper.papername like '%{1}%'", x, y);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridViewPaper.DataSource = dt;
            sqlconn.Close();
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
                string s = String.Format("select * from paper where paper.price >= {0} and paper.price <= {1}", x1, x2);
                SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridViewPaper.DataSource = dt;
                sqlconn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ziro();
            dataGridViewPaper.DataSource = paperBindingSource;
            this.paperTableAdapter.Fill(this.printingDataSet.Paper);
        }

        private void byPaperIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ziro();
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select * from paper order by paper.paperid");
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridViewPaper.DataSource = dt;
            sqlconn.Close();
        }

        private void bySizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ziro();
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select * from paper order by paper.size");
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridViewPaper.DataSource = dt;
            sqlconn.Close();
        }

        private void byPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ziro();
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select * from paper order by paper.price");
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridViewPaper.DataSource = dt;
            sqlconn.Close();
        }
    }
}

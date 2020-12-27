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

namespace PRINTER_CENTER.Forms_Edit
{
    public partial class BooksEdit : Form
    {
        const string ConnectionString = @"Data Source=TANIA;Initial Catalog=Printing;Integrated Security=True";
        private readonly int id;
        readonly bool edit;
        int OrderIdx;
        public BooksEdit()
        {
            InitializeComponent();

            this.booksTableAdapter.Fill(this.printingDataSet.Books);
            this.ordersTableAdapter.FillBy1(this.printingDataSet.Orders, OrderIdx);
            this.designTableAdapter.Fill(this.printingDataSet.Design);
            this.inkTableAdapter.Fill(this.printingDataSet.Ink);
            this.paperTableAdapter.Fill(this.printingDataSet.Paper);
            edit = false;
        }

        public BooksEdit(int BookId, string BookName, string Author,
            int PaperId, int InkId, int Size, int DesignId, int OrderId,
            int NumberOfPages, int AmountOfInk) : this()
        {
            OrderIdx = OrderId;
            this.booksTableAdapter.Fill(this.printingDataSet.Books);
            this.ordersTableAdapter.FillBy1(this.printingDataSet.Orders, OrderIdx);
            this.designTableAdapter.Fill(this.printingDataSet.Design);
            this.inkTableAdapter.Fill(this.printingDataSet.Ink);
            this.paperTableAdapter.Fill(this.printingDataSet.Paper);
            edit = true;
            this.id = BookId;
            textBox1.Text = BookName;
            textBox2.Text = Author;
            comboBox2.SelectedValue = PaperId;
            comboBox1.SelectedValue = InkId;
            textBox3.Text = Size.ToString();
            comboBox3.SelectedValue = DesignId;
            comboBox4.SelectedValue = OrderId;
            textBox4.Text = NumberOfPages.ToString();
            textBox5.Text = AmountOfInk.ToString();
        }

        private void BooksEdit_Load(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.printingDataSet.Books);
        }
        bool CheckIfNumber(string s)
        {
            if (s == "" || s[0] == '0')
                return false;
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] > '9' || s[i] < '0')
                    return false;
            }
            return true;
        }
        bool Check_valid(string s)
        {
            if (s == "")
                return false;
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Check_valid(textBox1.Text) == false || Check_valid(textBox2.Text) == false)
            {
                MessageBox.Show("Not all fields are filled", "Invalid data", MessageBoxButtons.OK);
            }
            else
            {
                if (CheckIfNumber(textBox3.Text) == false || CheckIfNumber(textBox4.Text) == false || CheckIfNumber(textBox5.Text) == false)
                {
                    MessageBox.Show("Enter valid numbers", "Invalid data", MessageBoxButtons.OK);
                }
                else
                {
                    if (edit)
                    {
                        booksTableAdapter.UpdateQuery(textBox1.Text, textBox2.Text,
                            Convert.ToInt32(comboBox2.SelectedValue),
                            Convert.ToInt32(comboBox1.SelectedValue),
                            Convert.ToInt32(textBox3.Text),
                            Convert.ToInt32(comboBox3.SelectedValue),
                            Convert.ToInt32(comboBox4.SelectedValue),
                            Convert.ToInt32(textBox4.Text),
                            Convert.ToInt32(textBox5.Text),
                            id);
                    }
                    else
                    {
                        booksTableAdapter.Insert(textBox1.Text, textBox2.Text,
                            Convert.ToInt32(comboBox2.SelectedValue),
                            Convert.ToInt32(comboBox1.SelectedValue),
                            Convert.ToInt32(textBox3.Text),
                            Convert.ToInt32(comboBox3.SelectedValue),
                            Convert.ToInt32(comboBox4.SelectedValue),
                            Convert.ToInt32(textBox4.Text),
                            Convert.ToInt32(textBox5.Text));
                    }
                    Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select * from paper where paper.paperid = {0}", Convert.ToInt32(comboBox2.SelectedValue));
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select * from ink where ink.inkid = {0}", Convert.ToInt32(comboBox1.SelectedValue));
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView2.DataSource = dt;
            sqlconn.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select * from design where design.designid = {0}", Convert.ToInt32(comboBox3.SelectedValue));
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView3.DataSource = dt;
            sqlconn.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select orders.orderid, customers.c_name, customers.c_surname, " +
                "orders.circulation, orders.orderdate from orders inner join customers on " +
                "customers.customerid = orders.customerid where orders.orderid = {0}", Convert.ToInt32(comboBox4.SelectedValue));
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView4.DataSource = dt;
            sqlconn.Close();
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select * from paper where paper.paperid = {0}", Convert.ToInt32(comboBox2.SelectedValue));
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select * from ink where ink.inkid = {0}", Convert.ToInt32(comboBox1.SelectedValue));
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView2.DataSource = dt;
            sqlconn.Close();
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select * from design where design.designid = {0}", Convert.ToInt32(comboBox3.SelectedValue));
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView3.DataSource = dt;
            sqlconn.Close();
        }

        private void comboBox4_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select orders.orderid, customers.c_name, customers.c_surname, " +
                "orders.circulation, orders.orderdate from orders inner join customers on " +
                "customers.customerid = orders.customerid where orders.orderid = {0}", Convert.ToInt32(comboBox4.SelectedValue));
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView4.DataSource = dt;
            sqlconn.Close();
        }
    }
}

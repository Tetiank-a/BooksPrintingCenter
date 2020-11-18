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

namespace PRINTER_CENTER.Forms_Main
{
    public partial class Auto : Form
    {
        string Receiptx;
        int bookidx, circulationx, orderidx, booksizex;
        string papersizex;
        const string ConnectionString = @"Data Source=TANIA;Initial Catalog=Printing;Integrated Security=True";
        public Auto()
        {
            InitializeComponent();
        }

        public Auto(int orderid)
        {
            InitializeComponent();
            orderidx = orderid;
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select books.bookid, books.size from books where books.orderid = {0}", orderid);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            textBox1.Text = dt.Rows[0][0].ToString();
            bookidx = Convert.ToInt32(dt.Rows[0][0]);
            booksizex = Convert.ToInt32(dt.Rows[0][1]);

            s = String.Format("select orders.circulation from orders where orders.orderid = {0}", orderid);
            oda = new SqlDataAdapter(s, sqlconn);
            dt = new DataTable();
            oda.Fill(dt);
            textBox2.Text = dt.Rows[0][0].ToString();
            circulationx = Convert.ToInt32(dt.Rows[0][0]);

            s = String.Format("select paper.size from paper inner join books on books.paperid = " +
                "paper.paperid inner join orders on orders.orderid = books.orderid where " +
                "orders.orderid = {0}", orderid);
            oda = new SqlDataAdapter(s, sqlconn);
            dt = new DataTable();
            oda.Fill(dt);
            textBox3.Text = dt.Rows[0][0].ToString();
            papersizex = dt.Rows[0][0].ToString();

            s = String.Format("select * from printings where printings.papersize = '{0}' " +
                "order by printings.[common time] + printings.speed * {1}", papersizex, booksizex);
            oda = new SqlDataAdapter(s, sqlconn);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            for (int i = 0; i < circulationx; ++i)
            {
                s = String.Format("select count(printings.printerid) from printings where printings.papersize = '{0}'", papersizex);
                oda = new SqlDataAdapter(s, sqlconn);
                dt = new DataTable();
                oda.Fill(dt);
                int x = Convert.ToInt32(dt.Rows[0][0]);
                if (x == 0)
                {
                    MessageBox.Show("No appropriate printers", "Invalid data", MessageBoxButtons.OK);
                    break;
                }
                s = String.Format("select * from printings where printings.papersize = '{0}' " +
                "order by printings.[common time] + printings.speed * {1}", papersizex, booksizex);
                oda = new SqlDataAdapter(s, sqlconn);
                dt = new DataTable();
                oda.Fill(dt);
                int newprinter = Convert.ToInt32(dt.Rows[0][0]);
                int newspeed = Convert.ToInt32(dt.Rows[0][2]);

                s = String.Format("insert into process([PrinterId], [BookId], [Quantity], " +
                    "[TimeNeeded]) values({0}, {1}, {2}, {3})", newprinter, bookidx, 1, 
                    newspeed * booksizex);
                oda = new SqlDataAdapter(s, sqlconn);
                dt = new DataTable();
                oda.Fill(dt);
            }
            sqlconn.Close();
            MessageBox.Show("Your order has been added to the process", "Information", MessageBoxButtons.OK);
        }

        private void Auto_Load(object sender, EventArgs e)
        {

        }
    }
}

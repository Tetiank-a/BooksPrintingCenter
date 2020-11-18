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
        int bookidx, circulationx, orderidx;
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
            string s = String.Format("select books.bookid from books where books.orderid = {0}", orderid);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            textBox1.Text = dt.Rows[0][0].ToString();
            bookidx = Convert.ToInt32(dt.Rows[0][0]);

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

            s = String.Format("select * from printersbusy where printersbusy.papersize = '{0}' " +
                "order by printersbusy.[common time]", papersizex);
            oda = new SqlDataAdapter(s, sqlconn);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void Auto_Load(object sender, EventArgs e)
        {

        }
    }
}

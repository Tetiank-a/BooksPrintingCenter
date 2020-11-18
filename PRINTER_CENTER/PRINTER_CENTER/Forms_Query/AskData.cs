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

namespace PRINTER_CENTER.Forms_Query
{
    public partial class AskData : Form
    {
        string Receiptx;
        const string ConnectionString = @"Data Source=TANIA;Initial Catalog=Printing;Integrated Security=True";
        public AskData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select paper.paperid, paper.papername," +
                "sum(books.numberofpages * orders.circulation) as 'Common number of pages' " +
                "from paper inner join books on books.paperid = paper.paperid inner join orders " +
                "on orders.orderid = books.orderid group by paper.paperid, paper.papername");
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select ink.inkid, ink.inkname, sum(books.amountofink) " +
                "as 'Common amount of ink' from ink inner join books on books.inkid = " +
                "ink.inkid group by ink.inkid, ink.inkname");
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select process.printerid as 'PRINTER ID', process.bookid as 'BOOK ID', books.bookname as 'BOOK NAME', " +
                "books.paperid as 'PAPER ID', paper.papername as 'PAPER NAME', books.inkid as 'INK ID', ink.inkname as 'INK NAME' " +
                "from process inner join books on books.bookid = process.bookid inner join " +
                "paper on paper.paperid = books.paperid inner join ink on ink.inkid = books.inkid " +
                "inner join orders on orders.orderid = books.orderid order by orders.orderdate asc;");
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            int bookid = Convert.ToInt32(comboBox1.SelectedValue);
            string s = String.Format("select books.bookid, paper.paperid, paper.papername, " +
                "paper.price * books.numberofpages as 'Paper price', ink.inkid, ink.inkname, " +
                "ink.price * books.amountofink as 'Ink price', design.designid, design.designname, " +
                "design.price as 'Design price', paper.price * books.numberofpages + ink.price * " +
                "books.amountofink + design.price as 'Common price' from books, paper, ink, design " +
                "where books.bookid = {0} order by paper.price * books.numberofpages + ink.price * " +
                "books.amountofink + design.price asc;", bookid);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void AskData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printingDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.printingDataSet.Books);
        }

        bool CheckIfNumber(string s)
        {
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
    }
}

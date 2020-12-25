using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace PRINTER_CENTER.Forms_Query
{
    public partial class Receipt : Form
    {
        string Receiptx;
        const string ConnectionString = @"Data Source=TANIA;Initial Catalog=Printing;Integrated Security=True";

        public Receipt()
        {
            InitializeComponent();
        }
        public Receipt(int OrderId) : this()
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select c1.c_name, c1.c_surname, o1.orderdate, b1.bookname," +
                "o1.circulation, p1.price * b1.numberofpages as 'Paper price for 1 book', " +
                "i1.price * b1.amountofink as 'Ink price for 1 book', d1.price as 'Design price', " +
                "p1.price * b1.numberofpages + i1.price * b1.amountofink + d1.price as 'Sum for 1 book', " +
                "p1.price * b1.numberofpages * o1.circulation + i1.price * b1.amountofink * o1.circulation + " +
                "d1.price as 'Result Sum' from customers c1 inner join orders o1 on o1.customerid = " +
                "c1.customerid inner join books b1 on b1.orderid = o1.orderid inner join paper p1 on " +
                "p1.paperid = b1.paperid inner join ink i1 on i1.inkid = b1.inkid inner join design d1 on " +
                "d1.designid = b1.designid where o1.OrderId = {0}", OrderId);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            string x1 = (dataGridView1.Rows[0].Cells[0].Value).ToString();
            string x2 = (dataGridView1.Rows[0].Cells[1].Value).ToString();

            string x3 = (dataGridView1.Rows[0].Cells[2].Value).ToString();
            string x4 = (dataGridView1.Rows[0].Cells[3].Value).ToString();
            string x5 = (dataGridView1.Rows[0].Cells[4].Value).ToString();
            string x6 = (dataGridView1.Rows[0].Cells[5].Value).ToString();
            string x7 = (dataGridView1.Rows[0].Cells[6].Value).ToString();
            string x8 = (dataGridView1.Rows[0].Cells[7].Value).ToString();

            string x9 = (dataGridView1.Rows[0].Cells[8].Value).ToString();
            string x10 = (dataGridView1.Rows[0].Cells[9].Value).ToString();
            DateTime dateTime = DateTime.UtcNow.Date;
            Receiptx =
                "Name:                          " + x1 + "\n" +
                "Surname:                       " + x2 + "\n" +
                "Order date:                    " + x3 + "\n" +
                "Book name:                     " + x4 + "\n" +
                "Circulation:                   " + x5 + "\n" +
                "Paper price for 1 book:        " + x6 + "\n" +
                "Ink price for 1 book:          " + x7 + "\n" +
                "Design price:                  " + x8 + "\n" +
                "Sum for 1 book:                " + x9 + "\n" +
                "Result Sum:                    " + x10 + "\n" +
                dateTime.ToString("dd/MM/yyyy");
            label1.Text = Receiptx;
            sqlconn.Close();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Word.Application objWord = new Word.Application();
            objWord.Visible = true;
            objWord.WindowState = Word.WdWindowState.wdWindowStateNormal;

            Word.Document objDoc = objWord.Documents.Add();

            Word.Paragraph objPara;
            objPara = objDoc.Paragraphs.Add();
            objPara.Range.Text = Receiptx;
        }
    }
}

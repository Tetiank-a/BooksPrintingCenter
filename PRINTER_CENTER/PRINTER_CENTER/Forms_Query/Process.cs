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

namespace PRINTER_CENTER.Forms_Query
{
    public partial class Process : Form
    {
        string Receiptx;
        const string ConnectionString = @"Data Source=TANIA;Initial Catalog=Printing;Integrated Security=True";

        public Process()
        {
            InitializeComponent();
        }
        public Process(int PrinterId) : this()
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select process.bookid," +
                "process.quantity, process.timeneeded from process inner join " +
                "books on books.bookid = process.bookid inner join orders on " +
                "orders.orderid = books.orderid where process.printerid = {0} order by orders.orderdate asc", PrinterId);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;

            Receiptx = "       PRINTER ID: " + PrinterId + "\n" + "\n";

            for (int x = 0; x < dataGridView1.Rows.Count - 1; x++)
            {
                Receiptx += (x + 1).ToString() + "." + "\n";
                string x1 = (dataGridView1.Rows[x].Cells[0].Value).ToString();
                string x2 = (dataGridView1.Rows[x].Cells[1].Value).ToString();
                string x3 = (dataGridView1.Rows[x].Cells[2].Value).ToString();

                Receiptx +=
                "Book id:                             " + x1 + "\n" +
                "Quantity:                            " + x2 + "\n" +
                "Time needed:                         " + x3 + "\n" + "\n" + "\n";
            }
            label1.Text = "PRINTER #" + PrinterId.ToString();
            sqlconn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog1.FileName.ToString());
                file.WriteLine(Receiptx);
                file.Close();
            }
        }
    }
}

using PRINTER_CENTER.Forms_Main;
using PRINTER_CENTER.Forms_Query;
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
    public partial class OrdersForm : Form
    {
        const string ConnectionString = @"Data Source=TANIA;Initial Catalog=Printing;Integrated Security=True";
        private bool edit = true;
        //1
        public OrdersForm()
        {
            InitializeComponent();
            Ziro();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            dataGridViewOrders.DataSource = ordersBindingSource;
            Ziro();
            // TODO: This line of code loads data into the 'printingDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.printingDataSet.Orders);

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var edt = new OrdersEdit();
            edt.ShowDialog();
            dataGridViewOrders.DataSource = ordersBindingSource;
            Ziro();
            ordersTableAdapter.Fill(printingDataSet.Orders);
            printingDataSet.AcceptChanges();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var st = new PrintingDataSet.OrdersDataTable();
            ordersTableAdapter.FillBy(st,
            Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var edt = new OrdersEdit(
            Convert.ToInt32(row[0]),
            Convert.ToInt32(row[1]),
            Convert.ToInt32(row[2]),
            Convert.ToDateTime(row[3]),
            Convert.ToBoolean(row[4])
            );
            edt.ShowDialog();
            dataGridViewOrders.DataSource = ordersBindingSource;
            Ziro();
            ordersTableAdapter.Fill(printingDataSet.Orders);
            printingDataSet.AcceptChanges();
        }

        private void Ziro()
        {
            toolStripTextBox4.Text = "";
            toolStripTextBox1.Text = "";
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this?", "Delete Data",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!edit) return;
                ordersTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells[0].Value)
                );
                dataGridViewOrders.DataSource = ordersBindingSource;
                Ziro();
                ordersTableAdapter.Fill(printingDataSet.Orders);
                printingDataSet.AcceptChanges();
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string x = toolStripTextBox1.Text;
            string y = toolStripTextBox4.Text;
            string s = String.Format("select * from orders where orders.customerid like '%{0}%' and orders.orderid like '%{1}%'", x, y);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridViewOrders.DataSource = dt;
            sqlconn.Close();
        }

        private void byDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ziro();
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select * from orders order by orders.orderdate");
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridViewOrders.DataSource = dt;
            sqlconn.Close();
        }

        private void byOrderIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ziro();
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select * from orders order by orders.orderid");
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridViewOrders.DataSource = dt;
            sqlconn.Close();
        }

        private void toolStripTextBox4_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string x = toolStripTextBox1.Text;
            string y = toolStripTextBox4.Text;
            string s = String.Format("select * from orders where orders.customerid like '%{0}%' and orders.orderid like '%{1}%'", x, y);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridViewOrders.DataSource = dt;
            sqlconn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ziro();
            DateTime x1 = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime x2 = Convert.ToDateTime(dateTimePicker2.Value);
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select * from orders where orders.orderdate >= '{0}' and orders.orderdate <= '{1}'", x1, x2);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridViewOrders.DataSource = dt;
            sqlconn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ziro();
            dataGridViewOrders.DataSource = ordersBindingSource;
            ordersTableAdapter.Fill(printingDataSet.Orders);
        }

        private void orederReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var edt = new Receipt(Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells[0].Value));
            edt.ShowDialog();
        }

        private void findPrinterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int orderidx = Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells[0].Value);
            bool condx = Convert.ToBoolean(dataGridViewOrders.SelectedRows[0].Cells[4].Value);
            if (condx == true)
            {
                MessageBox.Show("Your order has been already added to the process. " +
                    "You can delete all processes and change a condition to false", "Error", 
                    MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                string s = String.Format("select count(books.bookid) from " +
                    "orders left join books on orders.orderid = books.orderid " +
                    "group by orders.orderid having orders.OrderId = {0}",
                        orderidx);
                SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                if (Convert.ToInt32(dt.Rows[0][0]) == 0)
                {
                    MessageBox.Show("Add an information about book firstly", "Impossible " +
                           "operation", MessageBoxButtons.OK);
                }
                else
                {
                    var edt = new Auto(Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells[0].Value));
                    edt.ShowDialog();
                    dataGridViewOrders.DataSource = ordersBindingSource;
                    Ziro();
                    ordersTableAdapter.Fill(printingDataSet.Orders);
                    printingDataSet.AcceptChanges();
                }
            }
        }

        private void OrdersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var x = new MenuForm();
            x.Show();
        }
    }
}

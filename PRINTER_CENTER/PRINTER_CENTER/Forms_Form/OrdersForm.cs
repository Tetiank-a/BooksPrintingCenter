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
        bool state = false;
        string sorting = "orders.orderid";
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
                //Ziro();
                ordersTableAdapter.Fill(printingDataSet.Orders);
                printingDataSet.AcceptChanges();
            }
            Filter();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void byDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sorted.Text = "Sorted by OrderDate";
            sorting = "orders.orderdate";
            Filter();
        }

        private void byOrderIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sorted.Text = "Sorted by OrderId";
            sorting = "orders.orderid";
            Filter();
        }

        private void toolStripTextBox4_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }
        void Filter()
        {
            if (state == true)
            {
                bool c1, c2, c3;
                DateTime x1, x2;
                c1 = checkBox2.Checked;
                c2 = checkBox3.Checked;
                c3 = checkBox4.Checked;
                if (c2 == false)
                {
                    x1 = Convert.ToDateTime("11.11.1000");
                }
                else
                    x1 = Convert.ToDateTime(dateTimePicker1.Value);
                if (c3 == false)
                {
                    x2 = Convert.ToDateTime("11.11.6000");
                }
                else
                    x2 = Convert.ToDateTime(dateTimePicker2.Value);
                bool xxx = false;
                if (checkBox1.Checked == true)
                    xxx = true;

                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                string x = toolStripTextBox1.Text;
                string y = toolStripTextBox4.Text;
                string s;
                if (c1 == true)
                    s = String.Format("select * from orders where orders.customerid like '%{0}%' and orders.orderid like '%{1}%' and orders.orderdate >= '{2}' and orders.orderdate <= '{3}' and orders.condition = '{4}' order by {5}", x, y, x1, x2, xxx, sorting);
                else
                    s = String.Format("select * from orders where orders.customerid like '%{0}%' and orders.orderid like '%{1}%' and orders.orderdate >= '{2}' and orders.orderdate <= '{3}' order by {4}", x, y, x1, x2, sorting);
                SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridViewOrders.DataSource = dt;
                sqlconn.Close();
            }
            else
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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            state = true;
            Filter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ziro();
            state = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox1.Checked = false;
            sorted.Text = "Sorted by OrderId";
            sorting = "orders.orderid";
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

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press button FIND PRINTER after choosing an item to make system automatically distridute this order on printers. To create a receipt press ORDER RECEIPT", "Help", MessageBoxButtons.OK);
        }
    }
}

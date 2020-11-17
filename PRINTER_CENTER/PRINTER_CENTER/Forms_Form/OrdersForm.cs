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
        private bool edit = true;
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printingDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.printingDataSet.Orders);

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var edt = new OrdersEdit();
            edt.ShowDialog();
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
            ordersTableAdapter.Fill(printingDataSet.Orders);
            printingDataSet.AcceptChanges();
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
                ordersTableAdapter.Fill(printingDataSet.Orders);
                printingDataSet.AcceptChanges();
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.ordersBindingSource.Filter = "CONVERT(OrderId, 'System.String') LIKE '%" +
                toolStripTextBox4.Text + "%' and CONVERT(CustomerId, 'System.String') LIKE '%" +
                toolStripTextBox1.Text + "%'";
        }

        private void byDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewOrders.Sort(dataGridViewOrders.Columns[3], ListSortDirection.Ascending);
        }

        private void byOrderIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewOrders.Sort(dataGridViewOrders.Columns[0], ListSortDirection.Ascending);
        }

        private void toolStripTextBox4_TextChanged(object sender, EventArgs e)
        {
            this.ordersBindingSource.Filter = "CONVERT(OrderId, 'System.String') LIKE '%" +
                toolStripTextBox4.Text + "%' and CONVERT(CustomerId, 'System.String') LIKE '%" +
                toolStripTextBox1.Text + "%'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ordersBindingSource.Filter = "(OrderDate >= #" +
                Convert.ToDateTime(dateTimePicker1.Text).ToString("MM/dd/yyyy") +
                "# and OrderDate <= #" + Convert.ToDateTime(dateTimePicker2.Text).ToString("MM/dd/yyyy") + "#)";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ordersBindingSource.Filter = "";
        }

        private void orederReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var edt = new Receipt(Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells[0].Value));
            edt.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRINTER_CENTER
{
    public partial class CustomersForm : Form
    {
        private bool edit = true;
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printingDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.printingDataSet.Customers);

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var st = new PrintingDataSet.CustomersDataTable();
            customersTableAdapter.FillBy(st,
            Convert.ToInt32(dataGridViewCustomers.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var edt = new CustomersEdit(
            Convert.ToInt32(row[0]),
            row[1].ToString(),
            row[2].ToString(),
            row[3].ToString(),
            row[4].ToString()
            );
            edt.ShowDialog();
            customersTableAdapter.Fill(printingDataSet.Customers);
            printingDataSet.AcceptChanges();

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var edt = new CustomersEdit();
            edt.ShowDialog();
            customersTableAdapter.Fill(printingDataSet.Customers);
            printingDataSet.AcceptChanges();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this?", "Delete Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!edit) return;
                customersTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridViewCustomers.SelectedRows[0].Cells[0].Value)
                );
                customersTableAdapter.Fill(printingDataSet.Customers);
                printingDataSet.AcceptChanges();
            }
        }

        private void CustomersForm_FormClosing(object sender, FormClosingEventArgs e)
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

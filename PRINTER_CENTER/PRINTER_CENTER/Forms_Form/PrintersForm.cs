using PRINTER_CENTER.Forms_Edit;
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

namespace PRINTER_CENTER.Forms_Form
{
    public partial class PrintersForm : Form
    {
        const string ConnectionString = @"Data Source=TANIA;Initial Catalog=Printing;Integrated Security=True";
        private bool edit = true;
        public PrintersForm()
        {
            InitializeComponent();
        }

        private void PrintersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printingDataSet.PrintingMachines' table. You can move, or remove it, as needed.
            this.printingMachinesTableAdapter.Fill(this.printingDataSet.PrintingMachines);

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var edt = new PrintersEdit();
            edt.ShowDialog();
            printingMachinesTableAdapter.Fill(printingDataSet.PrintingMachines);
            printingDataSet.AcceptChanges();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var st = new PrintingDataSet.PrintingMachinesDataTable();
            printingMachinesTableAdapter.FillBy(st,
            Convert.ToInt32(dataGridViewPrinters.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var edt = new PrintersEdit(
            Convert.ToInt32(row[0]),
            row[1].ToString(),
            Convert.ToInt32(row[2]),
            Convert.ToBoolean(row[3])
            );
            edt.ShowDialog();
            printingMachinesTableAdapter.Fill(printingDataSet.PrintingMachines);
            printingDataSet.AcceptChanges();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show("Do you really want to delete this?", "Delete Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!edit) return;
                printingMachinesTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridViewPrinters.SelectedRows[0].Cells[0].Value)
                );
                printingMachinesTableAdapter.Fill(printingDataSet.PrintingMachines);
                printingDataSet.AcceptChanges();
            }*/
            if (MessageBox.Show("Do you really want to delete this?", "Delete Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                string s = String.Format("select count(process.printerid) from process where process.printerid = {0}",
                    dataGridViewPrinters.SelectedRows[0].Cells[0].Value);
                SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                //dataGridViewInk.DataSource = dt;

                sqlconn.Close();
                if (Convert.ToInt32(dt.Rows[0][0]) == 0)
                {
                    if (!edit) return;
                    printingMachinesTableAdapter.DeleteQuery(
                    Convert.ToInt32(dataGridViewPrinters.SelectedRows[0].Cells[0].Value)
                    );
                    printingMachinesTableAdapter.Fill(printingDataSet.PrintingMachines);
                    printingDataSet.AcceptChanges();
                }
                else
                {
                    MessageBox.Show("This printing machine is used in processes, delete all processes " +
                        "with this value to delete this item", "Impossible " +
                        "operation", MessageBoxButtons.OK);
                }
            }
        }

        private void getProcessesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var edt = new Process(Convert.ToInt32(dataGridViewPrinters.SelectedRows[0].Cells[0].Value));
            edt.ShowDialog();
        }

        private void PrintersForm_FormClosing(object sender, FormClosingEventArgs e)
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

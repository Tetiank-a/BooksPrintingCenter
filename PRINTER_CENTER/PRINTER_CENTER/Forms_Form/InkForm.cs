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
    public partial class InkForm : Form
    {
        private bool edit = true;
        public InkForm()
        {
            InitializeComponent();
        }

        private void InkForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printingDataSet.Ink' table. You can move, or remove it, as needed.
            this.inkTableAdapter.Fill(this.printingDataSet.Ink);

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var edt = new InkEdit();
            edt.ShowDialog();
            inkTableAdapter.Fill(printingDataSet.Ink);
            printingDataSet.AcceptChanges();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var st = new PrintingDataSet.InkDataTable();
            inkTableAdapter.FillBy(st,
            Convert.ToInt32(dataGridViewInk.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var edt = new InkEdit(
            Convert.ToInt32(row[0]),
            row[1].ToString(),
            Convert.ToDecimal(row[2])
            );
            edt.ShowDialog();
            inkTableAdapter.Fill(printingDataSet.Ink);
            printingDataSet.AcceptChanges();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this?", "Delete Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!edit) return;
                inkTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridViewInk.SelectedRows[0].Cells[0].Value)
                );
                inkTableAdapter.Fill(printingDataSet.Ink);
                printingDataSet.AcceptChanges();
            }
        }
    }
}

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
    public partial class PaperForm : Form
    {
        private bool edit = true;
        public PaperForm()
        {
            InitializeComponent();
        }

        private void PaperForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printingDataSet.Paper' table. You can move, or remove it, as needed.
            this.paperTableAdapter.Fill(this.printingDataSet.Paper);

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var edt = new PaperEdit();
            edt.ShowDialog();
            paperTableAdapter.Fill(printingDataSet.Paper);
            printingDataSet.AcceptChanges();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var st = new PrintingDataSet.PaperDataTable();
            paperTableAdapter.FillBy(st,
            Convert.ToInt32(dataGridViewPaper.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var edt = new PaperEdit(
            Convert.ToInt32(row[0]),
            row[1].ToString(),
            row[2].ToString(),
            Convert.ToDecimal(row[3])
            );
            edt.ShowDialog();
            paperTableAdapter.Fill(printingDataSet.Paper);
            printingDataSet.AcceptChanges();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this?", "Delete Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!edit) return;
                paperTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridViewPaper.SelectedRows[0].Cells[0].Value)
                );
                paperTableAdapter.Fill(printingDataSet.Paper);
                printingDataSet.AcceptChanges();
            }
        }
    }
}

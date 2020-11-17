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

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.paperBindingSource.Filter = "CONVERT(Size, 'System.String') LIKE '%" +
                toolStripTextBox1.Text + "%' and CONVERT(PaperName, 'System.String') LIKE '%" +
                toolStripTextBox4.Text + "%'";
        }

        private void toolStripTextBox4_TextChanged(object sender, EventArgs e)
        {
            this.paperBindingSource.Filter = "CONVERT(Size, 'System.String') LIKE '%" +
                toolStripTextBox1.Text + "%' and CONVERT(PaperName, 'System.String') LIKE '%" +
                toolStripTextBox4.Text + "%'";
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckIfNumber(textBox1.Text) == false ||
                CheckIfNumber(textBox2.Text) == false)
            {
                MessageBox.Show("Enter valid price", "Invalid data", MessageBoxButtons.OK);
            }
            else
            {
                Decimal x1 = Convert.ToDecimal(textBox1.Text);
                Decimal x2 = Convert.ToDecimal(textBox2.Text);
                this.paperBindingSource.Filter = String.Format("[Price] >= {0} AND [Price] <= {1}", x1, x2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.paperBindingSource.Filter = "";
        }

        private void byPaperIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewPaper.Sort(dataGridViewPaper.Columns[0], ListSortDirection.Ascending);
        }

        private void bySizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewPaper.Sort(dataGridViewPaper.Columns[2], ListSortDirection.Ascending);
        }

        private void byPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewPaper.Sort(dataGridViewPaper.Columns[3], ListSortDirection.Ascending);
        }
    }
}

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
                this.inkBindingSource.Filter = String.Format("[Price] >= {0} AND [Price] <= {1}", x1, x2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.inkBindingSource.Filter = "";
        }

        private void toolStripTextBox4_TextChanged(object sender, EventArgs e)
        {
            this.inkBindingSource.Filter = "CONVERT(InkName, 'System.String') LIKE '%" +
                toolStripTextBox4.Text + "%'";
        }

        private void byInkIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewInk.Sort(dataGridViewInk.Columns[0], ListSortDirection.Ascending);
        }

        private void byPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewInk.Sort(dataGridViewInk.Columns[2], ListSortDirection.Ascending);
        }
    }
}

using PRINTER_CENTER.Forms_Edit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRINTER_CENTER.Forms_Form
{
    public partial class BooksForm : Form
    {
        private bool edit = true;
        public BooksForm()
        {
            InitializeComponent();
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printingDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.printingDataSet.Books);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var edt = new BooksEdit();
            edt.ShowDialog();
            booksTableAdapter.Fill(printingDataSet.Books);
            printingDataSet.AcceptChanges();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var st = new PrintingDataSet.BooksDataTable();
            booksTableAdapter.FillBy(st,
            Convert.ToInt32(dataGridViewBooks.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var edt = new BooksEdit(
            Convert.ToInt32(row[0]),
            row[1].ToString(),
            row[2].ToString(),
            Convert.ToInt32(row[3]),
            Convert.ToInt32(row[4]),
            Convert.ToInt32(row[5]),
            Convert.ToInt32(row[6]),
            Convert.ToInt32(row[7]),
            Convert.ToInt32(row[8]),
            Convert.ToInt32(row[9])
            );
            edt.ShowDialog();
            booksTableAdapter.Fill(printingDataSet.Books);
            printingDataSet.AcceptChanges();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this?", "Delete Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!edit) return;
                booksTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridViewBooks.SelectedRows[0].Cells[0].Value)
                );
                booksTableAdapter.Fill(printingDataSet.Books);
                printingDataSet.AcceptChanges();
            }
        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewBooks.Sort(dataGridViewBooks.Columns[1], ListSortDirection.Ascending);
        }

        private void byIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewBooks.Sort(dataGridViewBooks.Columns[0], ListSortDirection.Ascending);
        }


        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            this.booksBindingSource.Filter = "CONVERT(BookName, 'System.String') LIKE '" + toolStripTextBox2.Text + "%'";
        }

        private void BooksForm_FormClosing(object sender, FormClosingEventArgs e)
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
            MessageBox.Show("Choose an item and do any action in the menu", "Help", MessageBoxButtons.OK);
        }
    }
}

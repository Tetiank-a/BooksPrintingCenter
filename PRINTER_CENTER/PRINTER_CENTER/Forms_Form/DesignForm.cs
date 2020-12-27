using PRINTER_CENTER.Forms_Edit;
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
    public partial class DesignForm : Form
    {
        const string ConnectionString = @"Data Source=TANIA;Initial Catalog=Printing;Integrated Security=True";
        private bool edit = true;
        public DesignForm()
        {
            InitializeComponent();
            dataGridViewDesign.DataSource = designBindingSource;
        }

        private void DesignForm_Load(object sender, EventArgs e)
        {
            dataGridViewDesign.DataSource = designBindingSource;
            // TODO: This line of code loads data into the 'printingDataSet.Design' table. You can move, or remove it, as needed.
            this.designTableAdapter.Fill(this.printingDataSet.Design);

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var edt = new DesignEdit();
            edt.ShowDialog();
            designTableAdapter.Fill(printingDataSet.Design);
            printingDataSet.AcceptChanges();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var st = new PrintingDataSet.DesignDataTable();
            designTableAdapter.FillBy(st,
            Convert.ToInt32(dataGridViewDesign.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var edt = new DesignEdit(
            Convert.ToInt32(row[0]),
            row[1].ToString(),
            Convert.ToDecimal(row[2])
            );
            edt.ShowDialog();
            dataGridViewDesign.DataSource = designBindingSource;
            designTableAdapter.Fill(printingDataSet.Design);
            printingDataSet.AcceptChanges();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this?", "Delete Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                string s = String.Format("select count(books.bookid) from design left " +
                    "join books on books.designid = design.designid group by design.designid " +
                    "having design.designid = {0}",
                    dataGridViewDesign.SelectedRows[0].Cells[0].Value);
                SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                //dataGridViewInk.DataSource = dt;

                sqlconn.Close();
                if (Convert.ToInt32(dt.Rows[0][0]) == 0)
                {
                    if (!edit) return;
                    designTableAdapter.DeleteQuery(
                    Convert.ToInt32(dataGridViewDesign.SelectedRows[0].Cells[0].Value)
                    );
                    dataGridViewDesign.DataSource = designBindingSource;
                    designTableAdapter.Fill(printingDataSet.Design);
                    printingDataSet.AcceptChanges();
                }
                else
                {
                    MessageBox.Show("This design is used in books, change the value " +
                        "of design type in all books to delete this item", "Impossible " +
                        "operation", MessageBoxButtons.OK);
                }
                /*if (!edit) return;
                designTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridViewDesign.SelectedRows[0].Cells[0].Value)
                );
                designTableAdapter.Fill(printingDataSet.Design);
                printingDataSet.AcceptChanges();*/
            }
        }

        private void DesignForm_FormClosing(object sender, FormClosingEventArgs e)
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

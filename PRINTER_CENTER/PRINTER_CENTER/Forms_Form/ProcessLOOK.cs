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
    public partial class ProcessLOOK : Form
    {
        public ProcessLOOK()
        {
            InitializeComponent();
        }

        private void ProcessLOOK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printingDataSet.Process' table. You can move, or remove it, as needed.
            this.processTableAdapter.Fill(this.printingDataSet.Process);

        }


        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this?", "Delete Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                processTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridViewProcess.SelectedRows[0].Cells[0].Value)
                );
                processTableAdapter.Fill(printingDataSet.Process);
                printingDataSet.AcceptChanges();
            }
        }

        private void ProcessLOOK_FormClosing(object sender, FormClosingEventArgs e)
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

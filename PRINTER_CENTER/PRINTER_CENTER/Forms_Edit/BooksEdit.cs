using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRINTER_CENTER.Forms_Edit
{
    public partial class BooksEdit : Form
    {
        public BooksEdit()
        {
            InitializeComponent();
        }

        private void BooksEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printingDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.printingDataSet.Orders);
            // TODO: This line of code loads data into the 'printingDataSet.Design' table. You can move, or remove it, as needed.
            this.designTableAdapter.Fill(this.printingDataSet.Design);
            // TODO: This line of code loads data into the 'printingDataSet.Ink' table. You can move, or remove it, as needed.
            this.inkTableAdapter.Fill(this.printingDataSet.Ink);
            // TODO: This line of code loads data into the 'printingDataSet.Paper' table. You can move, or remove it, as needed.
            this.paperTableAdapter.Fill(this.printingDataSet.Paper);

        }
    }
}

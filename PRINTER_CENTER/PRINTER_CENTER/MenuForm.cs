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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = new CustomersForm();
            x.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var x = new QueryEdit();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = new OrdersForm();
            x.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var x = new PaperForm();
            x.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var x = new InkForm();
            x.Show();
        }
    }
}

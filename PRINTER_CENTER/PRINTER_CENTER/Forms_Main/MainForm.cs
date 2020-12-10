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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "root" && textBox2.Text == "123")
            {
                this.Hide();
                var x = new MenuForm();
                x.Show();
            }
            else
            {
                MessageBox.Show("Incorrect password or login", "Failed to login", MessageBoxButtons.OK);
            }
        }
    }
}

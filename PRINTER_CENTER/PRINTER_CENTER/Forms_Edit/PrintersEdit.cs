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
    public partial class PrintersEdit : Form
    {
        private readonly int id;
        readonly bool edit;
        public PrintersEdit()
        {
            InitializeComponent();
            this.printingMachinesTableAdapter.Fill(this.printingDataSet.PrintingMachines);
        }

        public PrintersEdit(int PrinterId, string PaperSize, int Speed, bool Condition) : this()
        {
            this.printingMachinesTableAdapter.Fill(this.printingDataSet.PrintingMachines);
            edit = true;
            this.id = PrinterId;
            textBox2.Text = PaperSize;
            textBox1.Text = Speed.ToString();
            string x = "Not ready";
            if (Condition == true)
                x = "Ready";
            comboBox1.Text = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool x = false;
            if (comboBox1.Text == "Ready")
                x = true;
            if (edit)
            {
                printingMachinesTableAdapter.UpdateQuery(textBox2.Text, Convert.ToInt32(textBox1.Text), x, id);
            }
            else
            {
                printingMachinesTableAdapter.Insert(textBox2.Text, Convert.ToInt32(textBox1.Text), x);
            }
            Close();
        }

        private void PrintersEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printingDataSet.PrintingMachines' table. You can move, or remove it, as needed.
            this.printingMachinesTableAdapter.Fill(this.printingDataSet.PrintingMachines);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

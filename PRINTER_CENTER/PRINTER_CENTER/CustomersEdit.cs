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
    public partial class CustomersEdit : Form
    {
        private readonly int id;
        readonly bool edit;
        public CustomersEdit()
        {
            InitializeComponent();
            this.customersTableAdapter.Fill(this.printingDataSet.Customers);
            edit = false;
        }
        public CustomersEdit(int CustomersId, string C_Name, string C_Surname, string C_phone, string C_email) : this()
        {
            this.customersTableAdapter.Fill(this.printingDataSet.Customers);
            textBox1.Text = C_Name;
            textBox2.Text = C_Surname;
            textBox3.Text = C_phone;
            textBox4.Text = C_email;
            this.edit = true;
            this.id = CustomersId;
        }

        private void CustomersEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printingDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.printingDataSet.Customers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                customersTableAdapter.UpdateQuery(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, id);
            }
            else
            {
                customersTableAdapter.Insert(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

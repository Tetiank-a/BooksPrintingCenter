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
    public partial class OrdersEdit : Form
    {
        private readonly int id;
        readonly bool edit;
        public OrdersEdit()
        {
            InitializeComponent();
            this.ordersTableAdapter.Fill(this.printingDataSet.Orders);
            this.customersTableAdapter.Fill(this.printingDataSet.Customers);
            edit = false;
        }

        public OrdersEdit(int OrderId, int CustomerId, int Circulation, DateTime OrderDate, bool Condition) : this()
        {
            this.ordersTableAdapter.Fill(this.printingDataSet.Orders);
            this.customersTableAdapter.Fill(this.printingDataSet.Customers);
            comboBox2.SelectedValue = CustomerId;
            edit = true;
            this.id = OrderId;
            textBox2.Text = Circulation.ToString();
            //dateTimePicker1.Text = OrderDate.ToString();
            dateTimePicker1.Value = OrderDate;
            string x = "No";
            if (Condition == true)
                x = "Yes";
            comboBox1.Text = x;
        }

        private void OrdersEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printingDataSet.Customers' table. You can move, or remove it, as needed.
            //this.customersTableAdapter.Fill(this.printingDataSet.Customers);
            // TODO: This line of code loads data into the 'printingDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.printingDataSet.Orders);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool x = false;
            if (comboBox1.Text == "Yes")
                x = true;
            if (edit)
            {
                ordersTableAdapter.UpdateQuery(Convert.ToInt32(comboBox2.Text), Convert.ToInt32(textBox2.Text), dateTimePicker1.Text, x, id);
            }
            else
            {
                ordersTableAdapter.Insert(Convert.ToInt32(comboBox2.Text), Convert.ToInt32(textBox2.Text), Convert.ToDateTime(dateTimePicker1.Text), x);
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

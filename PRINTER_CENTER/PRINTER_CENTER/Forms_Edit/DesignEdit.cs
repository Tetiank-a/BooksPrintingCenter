using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRINTER_CENTER.Forms_Edit
{
    public partial class DesignEdit : Form
    {
        private readonly int id;
        readonly bool edit;
        public DesignEdit()
        {
            InitializeComponent();
            this.designTableAdapter.Fill(this.printingDataSet.Design);
            edit = false;
        }

        public DesignEdit(int DesignId, string DesignName, SqlMoney Price) : this()
        {
            this.designTableAdapter.Fill(this.printingDataSet.Design);
            textBox1.Text = DesignName;
            textBox3.Text = Price.ToString();
            this.edit = true;
            this.id = DesignId;
        }

        private void DesignEdit_Load(object sender, EventArgs e)
        {
            this.designTableAdapter.Fill(this.printingDataSet.Design);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                designTableAdapter.UpdateQuery(textBox1.Text, Convert.ToDecimal(textBox3.Text), id);
            }
            else
            {
                designTableAdapter.Insert(textBox1.Text, Convert.ToDecimal(textBox3.Text));
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

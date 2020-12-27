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
            int i = DesignName.Length - 1;
            while (DesignName[i] == ' ')
            {
                if (i <= 0)
                    break;
                --i;
            }
            string sss = "";
            for (int j = 0; j <= i; ++j)
                sss += DesignName[j];
            textBox1.Text = sss;
            textBox3.Text = Price.ToString();
            this.edit = true;
            this.id = DesignId;
        }

        private void DesignEdit_Load(object sender, EventArgs e)
        {
            this.designTableAdapter.Fill(this.printingDataSet.Design);
        }
        bool Check_valid(string s)
        {
            if (s == "")
                return false;
            return true;
        }
        bool CheckIfNumber(string s)
        {
            int k1 = 0;
            if (s == "" || s[0] == '.' || s[s.Length - 1] == '.')
                return false;
            for (int i = 0; i < s.Length; ++i)
            {
                if ((s[i] > '9' || s[i] < '0') && (s[i] != '.'))
                    return false;
                if (s[i] == '.')
                    k1++;
            }
            if (k1 > 1)
                return false;
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Check_valid(textBox1.Text) == false || Check_valid(textBox3.Text) == false || CheckIfNumber(textBox3.Text) == false)
            {
                MessageBox.Show("Not all fields are filled or invalid data is entered", "Invalid data", MessageBoxButtons.OK);
            }
            else
            {
                string d = textBox1.Text;
                int i = d.Length - 1;
                while (d[i] == ' ')
                {
                    if (i <= 0)
                        break;
                    --i;
                }
                string sss = "";
                for (int j = 0; j <= i; ++j)
                    sss += d[j];
                if (edit)
                {
                    designTableAdapter.UpdateQuery(d, Convert.ToDecimal(textBox3.Text), id);
                }
                else
                {
                    designTableAdapter.Insert(d, Convert.ToDecimal(textBox3.Text));
                }
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

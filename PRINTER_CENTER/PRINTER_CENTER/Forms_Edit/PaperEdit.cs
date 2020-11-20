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

namespace PRINTER_CENTER
{
    public partial class PaperEdit : Form
    {
        private readonly int id;
        readonly bool edit;
        public PaperEdit()
        {
            InitializeComponent();
            this.paperTableAdapter.Fill(this.printingDataSet.Paper);
            edit = false;
        }

        public PaperEdit(int PaperId, string PaperName, string Size, SqlMoney Price) : this()
        {
            this.paperTableAdapter.Fill(this.printingDataSet.Paper);
            textBox1.Text = PaperName;
            textBox2.Text = Size;
            textBox3.Text = Price.ToString();
            this.edit = true;
            this.id = PaperId;
        }
        bool CheckIfNumber(string s)
        {
            if (s == "") return false;
            int k1 = 0;
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
        bool Check_valid(string s)
        {
            if (s == "")
                return false;
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Check_valid(textBox2.Text) == false || Check_valid(textBox1.Text) == false)
            {
                MessageBox.Show("Not all fields are filled", "Invalid data", MessageBoxButtons.OK);
            }
            else
            {
                if (CheckIfNumber(textBox3.Text) == false)
                {
                    MessageBox.Show("Enter valid numbers", "Invalid data", MessageBoxButtons.OK);
                }
                else
                {
                    if (edit)
                    {
                        paperTableAdapter.UpdateQuery(textBox1.Text, textBox2.Text, Convert.ToDecimal(textBox3.Text), id);
                    }
                    else
                    {
                        paperTableAdapter.Insert(textBox1.Text, textBox2.Text, Convert.ToDecimal(textBox3.Text));
                    }
                    Close();
                }
            }
        }

        private void PaperEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printingDataSet.Paper' table. You can move, or remove it, as needed.
            this.paperTableAdapter.Fill(this.printingDataSet.Paper);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

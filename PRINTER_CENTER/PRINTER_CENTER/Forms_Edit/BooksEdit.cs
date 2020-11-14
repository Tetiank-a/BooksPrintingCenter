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
        private readonly int id;
        readonly bool edit;
        public BooksEdit()
        {
            InitializeComponent();
            this.booksTableAdapter.Fill(this.printingDataSet.Books);
            this.ordersTableAdapter.Fill(this.printingDataSet.Orders);
            this.designTableAdapter.Fill(this.printingDataSet.Design);
            this.inkTableAdapter.Fill(this.printingDataSet.Ink);
            this.paperTableAdapter.Fill(this.printingDataSet.Paper);
            edit = false;
        }

        public BooksEdit(int BookId, string BookName, string Author,
            int PaperId, int InkId, int Size, int DesignId, int OrderId,
            int NumberOfPages, int AmountOfInk) : this()
        {
            this.booksTableAdapter.Fill(this.printingDataSet.Books);
            this.ordersTableAdapter.Fill(this.printingDataSet.Orders);
            this.designTableAdapter.Fill(this.printingDataSet.Design);
            this.inkTableAdapter.Fill(this.printingDataSet.Ink);
            this.paperTableAdapter.Fill(this.printingDataSet.Paper);
            edit = true;
            this.id = BookId;
            textBox1.Text = BookName;
            textBox2.Text = Author;
            comboBox2.SelectedValue = PaperId;
            comboBox1.SelectedValue = InkId;
            textBox3.Text = Size.ToString();
            comboBox3.SelectedValue = DesignId;
            comboBox4.SelectedValue = OrderId;
            textBox4.Text = NumberOfPages.ToString();
            textBox5.Text = AmountOfInk.ToString();
        }

        private void BooksEdit_Load(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.printingDataSet.Books);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                booksTableAdapter.UpdateQuery(textBox1.Text, textBox2.Text,
                    Convert.ToInt32(comboBox2.SelectedValue),
                    Convert.ToInt32(comboBox1.SelectedValue),
                    Convert.ToInt32(textBox3.Text),
                    Convert.ToInt32(comboBox3.SelectedValue),
                    Convert.ToInt32(comboBox4.SelectedValue),
                    Convert.ToInt32(textBox4.Text),
                    Convert.ToInt32(textBox5.Text),
                    id);
            }
            else
            {
                booksTableAdapter.Insert(textBox1.Text, textBox2.Text,
                    Convert.ToInt32(comboBox2.SelectedValue),
                    Convert.ToInt32(comboBox1.SelectedValue),
                    Convert.ToInt32(textBox3.Text),
                    Convert.ToInt32(comboBox3.SelectedValue),
                    Convert.ToInt32(comboBox4.SelectedValue),
                    Convert.ToInt32(textBox4.Text),
                    Convert.ToInt32(textBox5.Text));
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

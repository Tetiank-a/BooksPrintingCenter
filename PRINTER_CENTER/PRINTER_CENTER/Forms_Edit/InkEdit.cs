﻿using System;
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
    public partial class InkEdit : Form
    {
        private readonly int id;
        readonly bool edit;
        public InkEdit()
        {
            InitializeComponent();
            this.inkTableAdapter.Fill(this.printingDataSet.Ink);
            edit = false;
        }

        public InkEdit(int InkId, string InkName, SqlMoney Price) : this()
        {
            this.inkTableAdapter.Fill(this.printingDataSet.Ink);
            textBox1.Text = InkName;
            textBox3.Text = Price.ToString();
            this.edit = true;
            this.id = InkId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                inkTableAdapter.UpdateQuery(textBox1.Text, Convert.ToDecimal(textBox3.Text), id);
            }
            else
            {
                inkTableAdapter.Insert(textBox1.Text, Convert.ToDecimal(textBox3.Text));
            }
            Close();
        }

        private void InkEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printingDataSet.Ink' table. You can move, or remove it, as needed.
            this.inkTableAdapter.Fill(this.printingDataSet.Ink);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
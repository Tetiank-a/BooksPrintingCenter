﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRINTER_CENTER.Forms_Form
{
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printingDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.printingDataSet.Books);

        }
    }
}

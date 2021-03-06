﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRINTER_CENTER.Forms_Main
{
    public partial class Auto : Form
    {
        string Receiptx;
        bool check = false;
        int bookidx, circulationx, orderidx, booksizex;
        string papersizex;
        const string ConnectionString = @"Data Source=TANIA;Initial Catalog=Printing;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                MessageBox.Show("Has already been added", "Error", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                for (int i = 0; i < circulationx; ++i)
                {
                    string s = String.Format("select count(printings.printerid) from printings where printings.papersize = '{0}'", papersizex);
                    SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    int x = Convert.ToInt32(dt.Rows[0][0]);
                    if (x == 0)
                    {
                        MessageBox.Show("No appropriate printers", "Invalid data", MessageBoxButtons.OK);
                        return;
                        break;
                    } 
                    s = String.Format("select * from printings where printings.papersize = '{0}' " +
                    "order by printings.[common time] + printings.speed * {1}", papersizex, booksizex);
                    oda = new SqlDataAdapter(s, sqlconn);
                    dt = new DataTable();
                    oda.Fill(dt);
                    int newprinter = Convert.ToInt32(dt.Rows[0][0]);
                    int newspeed = Convert.ToInt32(dt.Rows[0][2]);

                    s = String.Format("insert into process([PrinterId], [BookId], [Quantity], " +
                        "[TimeNeeded]) values({0}, {1}, {2}, {3})", newprinter, bookidx, 1,
                        newspeed * booksizex);
                    oda = new SqlDataAdapter(s, sqlconn);
                    dt = new DataTable();
                    oda.Fill(dt);
                }
                sqlconn.Close();
                MessageBox.Show("Your order has been added to the process", "Information", MessageBoxButtons.OK);
                sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                string s1 = String.Format("update orders set orders.Condition = 1 where orders.OrderId = {0}", orderidx);
                SqlDataAdapter oda1 = new SqlDataAdapter(s1, sqlconn);
                DataTable dt1 = new DataTable();
                oda1.Fill(dt1);
                sqlconn.Close();
                check = true;
            }
        }

        private void Auto_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var x = new MenuForm();
            x.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press FIND PRINTERS button to make system automaticaly distribute books on machines for printing", "Help", MessageBoxButtons.OK);
        }

        public Auto()
        {
            InitializeComponent();
        }

        public Auto(int orderid)
        {
            InitializeComponent();
            orderidx = orderid;
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            string s = String.Format("select books.bookid, books.size from books where books.orderid = {0}", orderid);
            SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            textBox1.Text = dt.Rows[0][0].ToString();
            bookidx = Convert.ToInt32(dt.Rows[0][0]);
            booksizex = Convert.ToInt32(dt.Rows[0][1]);

            s = String.Format("select orders.circulation from orders where orders.orderid = {0}", orderid);
            oda = new SqlDataAdapter(s, sqlconn);
            dt = new DataTable();
            oda.Fill(dt);
            textBox2.Text = dt.Rows[0][0].ToString();
            circulationx = Convert.ToInt32(dt.Rows[0][0]);

            s = String.Format("select paper.size from paper inner join books on books.paperid = " +
                "paper.paperid inner join orders on orders.orderid = books.orderid where " +
                "orders.orderid = {0}", orderid);
            oda = new SqlDataAdapter(s, sqlconn);
            dt = new DataTable();
            oda.Fill(dt);
            textBox3.Text = dt.Rows[0][0].ToString();
            papersizex = dt.Rows[0][0].ToString();

            s = String.Format("select * from printings where printings.papersize = '{0}' " +
                "order by printings.[common time] + printings.speed * {1}", papersizex, booksizex);
            oda = new SqlDataAdapter(s, sqlconn);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt; /*
            for (int i = 0; i < circulationx; ++i)
            {
                s = String.Format("select count(printings.printerid) from printings where printings.papersize = '{0}'", papersizex);
                oda = new SqlDataAdapter(s, sqlconn);
                dt = new DataTable();
                oda.Fill(dt);
                int x = Convert.ToInt32(dt.Rows[0][0]);
                if (x == 0)
                {
                    MessageBox.Show("No appropriate printers", "Invalid data", MessageBoxButtons.OK);
                    break;
                }
                s = String.Format("select * from printings where printings.papersize = '{0}' " +
                "order by printings.[common time] + printings.speed * {1}", papersizex, booksizex);
                oda = new SqlDataAdapter(s, sqlconn);
                dt = new DataTable();
                oda.Fill(dt);
                int newprinter = Convert.ToInt32(dt.Rows[0][0]);
                int newspeed = Convert.ToInt32(dt.Rows[0][2]);

                s = String.Format("insert into process([PrinterId], [BookId], [Quantity], " +
                    "[TimeNeeded]) values({0}, {1}, {2}, {3})", newprinter, bookidx, 1, 
                    newspeed * booksizex);
                oda = new SqlDataAdapter(s, sqlconn);
                dt = new DataTable();
                oda.Fill(dt);
            }*/
            sqlconn.Close();
        }

        private void Auto_Load(object sender, EventArgs e)
        {

        }
    }
}

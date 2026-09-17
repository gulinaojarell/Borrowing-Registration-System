using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BorrowingRegistrationSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkPass.Checked)
            {
                TxtPass.UseSystemPasswordChar = true;
            }
            else
            {
                TxtPass.UseSystemPasswordChar = false;
            }

        }

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChkCPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkCPass.Checked)
            {
                TxtCpass.UseSystemPasswordChar = true;
            }
            else
            {
                TxtCpass.UseSystemPasswordChar = false;
            }
        }
    }
}

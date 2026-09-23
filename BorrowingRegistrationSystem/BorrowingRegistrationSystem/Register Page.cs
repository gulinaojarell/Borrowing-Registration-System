using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            string connStr =
        "server=127.0.0.1;port=3306;database=borrowing_db;uid=root;pwd=J@rell123;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string query =
                "INSERT INTO users(Full_Name, LRN, EMAIL_ADDRESS, EMAIL_PASSWORD) " +
                "VALUES(@fullname,@lrn,@email,@password)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@fullname", TxtFullName.Text);
                cmd.Parameters.AddWithValue("@lrn", TxtLrn.Text);
                cmd.Parameters.AddWithValue("@email", TxtEmailAdd.Text);
                cmd.Parameters.AddWithValue("@password", TxtPass.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Registered Successfully!");
            }
        }

        private void ChkSame_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSame.Checked)
            {
                TxtCpass.Text = TxtPass.Text;
            }
        }
    }
}

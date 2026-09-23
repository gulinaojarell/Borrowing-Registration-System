using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace BorrowingRegistrationSystem
{
    public partial class DASHBOARD : Form
    {


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string search = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("Please enter an equipment name.",
                                "Search",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            if (search.Contains("microscope"))
            {
                MessageBox.Show("Microscope is available.\n Category: STEM - Laboratory",
                                "Search Result",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else if (search.Contains("sewing") || search.Contains("sewing machine"))
            {
                MessageBox.Show("Sewing Machine is available.\nCategory: TVL - HE",
                                "Search Result",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No equipment found matching your search.",
                                "Search Result",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }


        }
    }
}

 
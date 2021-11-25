using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracing_Form_OOP
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        string gender;
        string lbl_q1;
        string lbl_q2;
        string lbl_q3;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                    }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnl1.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (rbyes2.Checked == true)
            {
                lbl_q2 = "yes";
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (rbyes2.Checked == true)
            {
                lbl_q2 = "no";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {
            pnl1.BackColor = Color.Transparent;
        }

        private void pnl2_Paint(object sender, PaintEventArgs e)
        {
            pnl2.BackColor = Color.Transparent;
        }

        private void pnl3_Paint(object sender, PaintEventArgs e)
        {
            pnl3.BackColor = Color.Transparent;
        }

        private void pnl4_Paint(object sender, PaintEventArgs e)
        {
            pnl4.BackColor = Color.Transparent;
        }

        private void pnl5_Paint(object sender, PaintEventArgs e)
        {
            pnl5.BackColor = Color.Transparent;
        }

        private void pnl6_Paint(object sender, PaintEventArgs e)
        {
            pnl6.BackColor = Color.Transparent;
        }

        private void pnl7_Paint(object sender, PaintEventArgs e)
        {
            pnl7.BackColor = Color.Transparent;
        }

        private void pnl8_Paint(object sender, PaintEventArgs e)
        {
            pnl8.BackColor = Color.Transparent;
        }

        private void pnl9_Paint(object sender, PaintEventArgs e)
        {
            pnl9.BackColor = Color.Transparent;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"ct.txt");
            sw.WriteLine("Name:" + tbFN);
            sw.WriteLine("Age:" + tbAge);
            sw.WriteLine("Phone Number:" + tbPN);
            sw.WriteLine("Address:" + tbAddr);
            sw.WriteLine("Gender:" + gender);
            sw.WriteLine("Have you traveled around the country anytime?:" + lbl_q1);
            sw.WriteLine("Have you come into close contact with anyone who has Covid - 19?:" + lbl_q2);
            sw.WriteLine("Do you currently have any of the following conditions during this time ?: " + lbl_q3);

            sw.Close();
            MessageBox.Show("Information have been submitted.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);


            tbFN.Text = "";
            tbAge.Text = "";
            tbPN.Text = "";
            tbAddr.Text = "";
            rbMale.Checked = false;
            rbfemale.Checked = false;
            rbnotsay.Checked = false;
            rbyes1.Checked = false;
            rbyes2.Checked = false;
            rbno1.Checked = false;
            rbno2.Checked = false;
            rbfvr.Checked = false;
            rbcgh.Checked = false;
            rbdob.Checked = false;
            rbnon.Checked = false;

        }

        private void rbyes1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbyes1.Checked == true)
            {
                lbl_q1 = "yes";
            }
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked == true)
            {
                gender = "Male";
            }
        }

        private void rbfemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbfemale.Checked == true)
            {
                gender = "Female";
            }
        }

        private void rbnotsay_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnotsay.Checked == true)
            {
                gender = "I prefer not to say";
            }
        }

        private void rbno1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbyes1.Checked == true)
            {
                lbl_q1 = "no";
            }
        }

        private void rbfvr_CheckedChanged(object sender, EventArgs e)
        {
            if (rbfvr.Checked == true)
            {
                lbl_q3 = "fever";
            }
        }

        private void rbcgh_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcgh.Checked == true)
            {
                lbl_q3 = "cough";
            }
        }

        private void rbdob_CheckedChanged(object sender, EventArgs e)
        {
            if (rbdob.Checked == true)
            {
                lbl_q3 = "difficulty of breathing";
            }
        }

        private void rbnon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnon.Checked == true)
            {
                lbl_q3 = "none";
            }
        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFN_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbAddr_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbPN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}

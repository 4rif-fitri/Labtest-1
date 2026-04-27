using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inpCard.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inpName.Text)) {
                MessageBox.Show("Enter Name");
                return;
            }
            else if (string.IsNullOrWhiteSpace(inpAddress.Text)) {
                MessageBox.Show("Enter Address");
                return;
            }
            else if (string.IsNullOrWhiteSpace(inpPhone.Text))
            {
                MessageBox.Show("Enter Phone Number");
                return;
            }

            if (checkBox1.Checked)
            {
                if (string.IsNullOrWhiteSpace(inpCard.Text))
                {
                    MessageBox.Show("Enter Member Card number");
                    return;
                }
            }

            double discount = checkBox1.Checked ? 0.15 : 0;
            string address = inpAddress.Text;

            this.Visible = false;
            var form2 = new Form2(address, discount);
            form2.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (inpCard.Visible == false) inpCard.Visible = true;
            else inpCard.Visible = false;
        }
    }
}

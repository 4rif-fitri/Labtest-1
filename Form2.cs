using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
        private string[] listName = {
            "Kasut Kasut",
            "Cawan Cawan",
            "Garpu Garpu",
            "Controller"
        };

        private double[] listHarga = {5,10,15,20};
        private int idx = 0;
    
        private double harga = 0;
        private double discount = 0;
        private double bil = 1;

        private DateTime dateStart;
        private DateTime dateEnd;

        public Form2(string address, double discount)
        {
            InitializeComponent();
            richTextBox1.Text = address;
            
            harga = listHarga[idx];
            this.discount = discount;

            label2.Text = listName[idx];
            pictureBox1.Image = imageList1.Images[idx];
            label11.Text = $"RM{harga}";
            label12.Text = bil.ToString();
            label13.Text = $"{discount * 100}%";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idx == imageList1.Images.Count - 1) idx = 0;
            idx++;
            render();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idx == 0) idx = imageList1.Images.Count;
            idx--;
            render();
        }
        private void render()
        {
            harga = listHarga[idx];

            pictureBox1.Image = imageList1.Images[idx];
            label2.Text = listName[idx];
            label11.Text = $"RM{harga}";
            label12.Text = bil.ToString();
            label13.Text = $"{discount * 100}%";
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            dateStart = dateTimePicker1.Value;
            dateEnd = dateTimePicker2.Value;
            bil =  dateEnd.Day - dateStart.Day;
            label12.Text = bil.ToString();
            string total = (harga * bil * (1 - discount)).ToString();
            label10.Text = $"RM{total}";
        }

    }
}

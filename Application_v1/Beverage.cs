using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Application_v1
{
    public partial class Beverage : Form
    {
        public static string item1;
        public static string item2;
        public static string item3;
        public static string item4;
        public static string item5;
        public static string item6;
        public static string bname;
        public Beverage()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (label4.Text == "+1" || label5.Text == "+1" || label8.Text == "+1" || label11.Text == "+1" || label14.Text == "+1" || label17.Text == "+1")
            {
                MessageBox.Show("Your selection maybe cancelled");
                label4.Text = "";
                label5.Text = "";
                label8.Text = "";
                label11.Text = "";
                label14.Text = "";
                label17.Text = "";
            }
            else
            {
                Homepage h = new Homepage();
                h.Show();
                this.Hide();
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "+1";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "+1";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label8.Text = "+1";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            label11.Text = "+1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label14.Text = "+1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label17.Text = "+1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(label4.Text == "" && label5.Text==""&&label8.Text==""&&label11.Text==""&&label14.Text==""&&label17.Text=="")
            {
                MessageBox.Show("Cannot order! Select anything");
            }
            else
            {
                MessageBox.Show("Ordered");
            }
        }
    }
}

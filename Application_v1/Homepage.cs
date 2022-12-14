using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_v1
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.name;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Beverage b = new Beverage();
            b.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Burger b = new Burger();
            b.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fries f = new Fries();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HappyMeal hm = new HappyMeal();
            hm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            McCafe mc = new McCafe();  
            mc.Show();
            this.Hide();
        }
    }
}

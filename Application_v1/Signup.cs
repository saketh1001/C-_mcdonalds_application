using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Application_v1
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            string phone = textBox3.Text;   
            string address = textBox4.Text;
            string pass;
            if (textBox5.Text == textBox6.Text)
            {
                if(textBox1.Text == "" || textBox2.Text == ""||textBox3.Text==""||textBox4.Text==""||textBox5.Text==""|| textBox6.Text=="") 
                {
                    MessageBox.Show("Unable to signup");
                    
                }
                else
                {
                    pass = textBox5.Text;
                    string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\psake\source\repos\Application_v1\Application_v1\signup.mdf;Integrated Security=True";
                    SqlConnection con = new SqlConnection(connection);
                    string query = "Insert into signup1 (username,email,phone,address,password) values('" + name + "','" + email + "','" + phone + "','" + address + "','" + pass + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    Form1 f = new Form1();
                    f.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Password fields do not match");
                textBox5.Focus();
            }
            
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Application_v1
{
    public partial class Form1 : Form
    {
        public static string name;
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup s = new Signup();
            s.Show();
            this.Hide();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\psake\source\repos\Application_v1\Application_v1\Signup.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("select username,password from signup1 where username=@username", con);
            cmd.Parameters.AddWithValue("username", textBox1.Text);
            cmd.Parameters.AddWithValue("password", textBox2.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Homepage h =new Homepage();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You either don't have an account or you entered wrong credentials");
            }
           
        }
    }
}

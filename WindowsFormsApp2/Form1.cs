using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 
     

       

        private void button2_Click(object sender, EventArgs e)
        {
            register reg = new register();
            reg.Show();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {


            string oradb = "Data Source=localhost:1521/XE;User Id = ADMIN!; Password = 08092002; ";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            string userid = textBox1.Text;
            string password = textBox2.Text;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Enter your User Name and Passowrd");
            }
            else
            {
                cmd.CommandText = "select * from BANK where username='" + userid + "' and password = '" + password + "'";
                cmd.Connection = conn;

                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    
                    dashboard ds = new dashboard();
                   
                    
                   
                    ds.value = textBox1.Text;
                    ds.Show();
                    
                   
                }
                else
                {
                    MessageBox.Show("Invalid Login");
                }

            }
            conn.Dispose();
        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            register reg = new register();
            reg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
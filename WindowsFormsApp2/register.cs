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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string oradb = "Data Source=localhost:1521/XE;User Id = ADMIN!; Password = 08092002; ";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();

            {
                cmd.CommandText = "insert into BANK (username,password,balance) values('" + textBox1.Text + "','" + textBox2.Text + "','" + 0 + "')";


                cmd.Connection = conn;

                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated == 0)
                {
                    MessageBox.Show("Record not inserted");
                }
                else
                {
                    MessageBox.Show("Success!");
                  
                    Form1 login = new Form1();
                    login.Show();
                }
                conn.Dispose();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class deposite : Form
    {
        public deposite()
        {
            InitializeComponent();
            label2.Text = Values;
            
        }
        public string Values { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            int c = int.Parse(textBox1.Text);
            string a;
            int ab;
            string oradb = "Data Source=localhost:1521/XE;User Id = ADMIN!; Password = 08092002; ";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            
            {
                cmd.CommandText = "select balance from BANK where username='" + Values + "'";
                cmd.Connection = conn;

                OracleDataReader dr = cmd.ExecuteReader();

                  dr.Read();  
                  a = dr["balance"].ToString();
                  ab = int.Parse(a);
               
            }
            conn.Dispose();

            OracleConnection con = new OracleConnection(oradb);
            con.Open();

            try
            {
                string sqlQuery = "UPDATE BANK SET balance='" + (ab+c) + "' where username = '" + Values+ "'";
                OracleCommand cma = new OracleCommand();
                cma.Connection = con;
                cma.CommandText = sqlQuery;
                cma.ExecuteNonQuery();

                MessageBox.Show("Transection Successfull");
                dashboard ds = new dashboard();
                ds.value = Values;
                ds.Show();
                this.Close();


                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            con.Dispose();

        }

        private void deposite_Load(object sender, EventArgs e)
        {
            label2.Text = Values;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashboard ds = new dashboard();
            ds.value = Values;
            ds.Show();
        }
    }
}

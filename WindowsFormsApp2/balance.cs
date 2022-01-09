using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp2
{
    public partial class balance : Form
    {

        public string Values { get; set; }

        public balance()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void balance_Load(object sender, EventArgs e)
        {
            
            string a;
            
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
                label2.Text = a; 

            }
            conn.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard ds = new dashboard();
            ds.value = Values;
            ds.Show();
            this.Close();
        }
    }
}

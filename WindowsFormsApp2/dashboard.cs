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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            label2.Text = value;

        }

        public string value { get; set; }

        private void dashboard_Load(object sender, EventArgs e)
        {
            label2.Text = value;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            deposite dp = new deposite();
            dp.Values = label2.Text;
            dp.Show();
            
            this.Hide();
        
   
        }

        private void button4_Click(object sender, EventArgs eh)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            withdraw withdraw =  new withdraw();
            withdraw.Values = label2.Text;
            withdraw.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            balance bs = new balance();
            bs.Values = label2.Text;
            bs.Show();
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            transfer transfer = new transfer();
            transfer.Values = label2.Text;
            transfer.Show();
            this.Close();
        }
    }
}

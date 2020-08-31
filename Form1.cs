using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace DATABASEPHASE2
{
    public partial class Form1 : Form
    {
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 fstaff = new Form2();
            fstaff.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fdonor = new Form3();
            fdonor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 fvolunter = new Form4();
            fvolunter.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 freport = new Form5();
            freport.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 ffieldreport = new Form6();
            ffieldreport.Show();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
    public partial class Form2 : Form
    {
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public Form2()
        {
            InitializeComponent();
            panel5.Height = button1.Height;
            panel5.Top = button1.Top;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select SSN from staff";
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_ssnstaff.Items.Add(dr[0]);
            }
            dr.Close();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            panel5.Height = button1.Height;
            panel5.Top = button1.Top;
            // show data
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from staff where SSN=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", cmb_ssnstaff.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                txt_namestaff.Text = dr[1].ToString();
                txt_salarystaff.Text = dr[2].ToString();
                txt_birthdatestaff.Text = dr[3].ToString();
                txt_addressstaff.Text = dr[4].ToString();
                txt_chname.Text = dr[5].ToString();
            }
            dr.Close();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            panel5.Height = button2.Height;
            panel5.Top = button2.Top;

            // insert worker
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into staff values (:ssn,:name,:salary,:birthdate,:address,:charityname)";
            cmd.Parameters.Add("ssn", cmb_ssnstaff.Text);
            cmd.Parameters.Add("name", txt_namestaff.Text);
            cmd.Parameters.Add("salary", txt_salarystaff.Text);
            cmd.Parameters.Add("birthdate", txt_birthdatestaff.Text);
            cmd.Parameters.Add("address", txt_addressstaff.Text);
            cmd.Parameters.Add("charityname", txt_chname.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                cmb_ssnstaff.Items.Add(cmb_ssnstaff.Text);
                MessageBox.Show("New worker is added");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel5.Height = button3.Height;
            panel5.Top = button3.Top;

            //update  name and salary
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "update staff set Name=:name, salary=:salary where SSN =:ssn";

            c.Parameters.Add("name", txt_namestaff.Text);
            c.Parameters.Add("salary", txt_salarystaff.Text);
            c.Parameters.Add("ssn", cmb_ssnstaff.SelectedItem.ToString());
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("worker modified");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel5.Height = button4.Height;
            panel5.Top = button4.Top;


            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "Delete from staff where SSN=:ssn";
            c.Parameters.Add("ssn", cmb_ssnstaff.Text);
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("worker deleted");
                cmb_ssnstaff.Items.RemoveAt(cmb_ssnstaff.SelectedIndex);
                txt_namestaff.Text = "";
                txt_salarystaff.Text = "";
                txt_birthdatestaff.Text = "";
                txt_addressstaff.Text = "";
                txt_chname.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            

            

        }



        private void formclose(object sender, FormClosingEventArgs e)
        {
            
        }

        private void cmb_ssnstaff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

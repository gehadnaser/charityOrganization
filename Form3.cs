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
    public partial class Form3 : Form
    {
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select SSN from donor";
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_ssndonor.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            panel5.Height = button1.Height;
            panel5.Top = button1.Top;
            //m4 s8ala

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DONOR_DATA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("SSN", int.Parse(cmb_ssndonor.Text));
            cmd.Parameters.Add("FNAME", OracleDbType.Varchar2, ParameterDirection.Output);
            cmd.Parameters.Add("MNAME", OracleDbType.Varchar2, ParameterDirection.Output);
            cmd.Parameters.Add("LNAME", OracleDbType.Varchar2, ParameterDirection.Output);
            cmd.Parameters.Add("DADDRESS", OracleDbType.Varchar2, ParameterDirection.Output);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch { MessageBox.Show("error in execute"); }
            try
            {
                cmb_ssndonor.Text = cmd.Parameters["SSN"].Value.ToString();
                txt_fnamedonor.Text = cmd.Parameters["FNAME"].Value.ToString();
                txt_mnamedonor.Text = cmd.Parameters["MNAME"].Value.ToString();
                txt_lnamedonor.Text = cmd.Parameters["LNAME"].Value.ToString();
                txt_addressdonor.Text = cmd.Parameters["DADDRESS"].Value.ToString();
            }
            catch { MessageBox.Show("WE"); }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel5.Height = button2.Height;
            panel5.Top = button2.Top;
            
            //insert donor
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Insert_DONOR";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("SSN", int.Parse(cmb_ssndonor.Text));
            cmd.Parameters.Add("FNAME", txt_fnamedonor.Text);
            cmd.Parameters.Add("MNAME", txt_mnamedonor.Text);
            cmd.Parameters.Add("LNAME", txt_lnamedonor.Text);
            cmd.Parameters.Add("ADDRESS", txt_addressdonor.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("New Donor is added");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            panel5.Height = button3.Height;
            panel5.Top = button3.Top;
            
            //update address donor
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update_Donor";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("SSN", cmb_ssndonor.SelectedItem.ToString());
            cmd.Parameters.Add("ADDRESS", txt_addressdonor.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Donor is updated");
        }

        private void button4_Click(object sender, EventArgs e)
        {



            panel5.Height = button4.Height;
            panel5.Top = button4.Top;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Delete_Donor";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("SSN", cmb_ssndonor.SelectedItem.ToString());
            cmd.ExecuteNonQuery();
            cmb_ssndonor.Text = "";
            txt_fnamedonor.Text = "";
            txt_mnamedonor.Text = "";
            txt_lnamedonor.Text = "";
            txt_addressdonor.Text = "";
            
            MessageBox.Show(" Donor is deleted");
        }

        private void formclose(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GET_charity_PHONE";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("CHARITY NAME",txt_phone.Text);
            cmd.Parameters.Add("PHONE", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                cmb_phone.Items.Add(dr[0]);
                cmb_phone.Text = "";
            }
            dr.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

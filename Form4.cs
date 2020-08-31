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
    public partial class Form4 : Form
    {
        OracleDataAdapter adapter,adapter2;
        OracleCommandBuilder builder;
        DataSet ds;
         
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl;User Id=scott;Password=tiger;";
            string cmdstr = "select * from volunter";
            adapter = new OracleDataAdapter(cmdstr,constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dgvshowall.DataSource = ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl;User Id=scott;Password=tiger;";
            string cmdstr = @"select * from volunter where ADDRESS=:ad ";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("ad", txt_address.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            dgvshowall.DataSource = ds.Tables[0];

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl;User Id=scott;Password=tiger;";
            adapter = new OracleDataAdapter("select * from donorphone", constr);
            adapter2 = new OracleDataAdapter("select * from donor ", constr);
            ds = new DataSet();
            adapter.Fill(ds, "phone");
            adapter2.Fill(ds, "donor");
            DataRelation r = new DataRelation("fk", ds.Tables[0].Columns["DSSN"],
                                                  ds.Tables[1].Columns["SSN"]);
            ds.Relations.Add(r);
            BindingSource bs_master = new BindingSource(ds, "phone");
            BindingSource bs_child = new BindingSource(bs_master, "fk");
            dgv_phone.DataSource = bs_master;
            dgv_donor.DataSource = bs_child;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect_1 = 
                new SqlConnection("server=ROMANI\\SQL_2012; database=Shekveta; Integrated Security = True");
            connect_1.Open();
            SqlDataAdapter adap_Pers = new SqlDataAdapter("SELECT * FROM Personali", connect_1);
            SqlDataAdapter adap_Shemk = new SqlDataAdapter("SELECT * FROM Shemkveti", connect_1);
            DataSet ds_1 = new DataSet();
            adap_Pers.Fill(ds_1, "Personali");
            adap_Shemk.Fill(ds_1, "Shemkveti");
            connect_1.Close();
            dataGridView1.DataSource = ds_1;
            dataGridView1.DataMember = "Personali";
            dataGridView2.DataSource = ds_1;
            dataGridView2.DataMember = "Shemkveti";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connect_1 =
                new SqlConnection("server=ROMANI\\SQL_2012; database=Shekveta; Integrated Security = True");
            connect_1.Open();
            SqlDataAdapter adap_Pers = new SqlDataAdapter("SELECT * FROM Personali", connect_1);
            DataSet ds_1 = new DataSet();
            adap_Pers.Fill(ds_1, "Personali");
            connect_1.Close();
            DataView dv_1 = new DataView(ds_1.Tables["Personali"]);
            dv_1.RowFilter = "ganyofileba = 'სავაჭრო' AND asaki > 30";
            //dv_1.RowFilter = "tarigi_dabadebis >= '01.01.1980'"; // >= dateTimePicker1.Text;
            //dv_1.RowFilter = textBox1.Text;
            dataGridView1.DataSource = dv_1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connect_1 =
                new SqlConnection("server=ROMANI\\SQL_2012; database=Shekveta; Integrated Security = True");
            connect_1.Open();
            SqlDataAdapter adap_Pers = new SqlDataAdapter("SELECT * FROM Personali", connect_1);
            DataSet ds_1 = new DataSet();
            adap_Pers.Fill(ds_1, "Personali");
            connect_1.Close();
            DataView dv_1 = new DataView(ds_1.Tables["Personali"]);
            dv_1.RowFilter = "";  //  = textBox1.Text;
            dataGridView1.DataSource = dv_1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection connect_1 =
                new SqlConnection("server=ROMANI\\SQL_2012; database=Shekveta; Integrated Security = True");
            connect_1.Open();
            SqlDataAdapter adap_Pers = new SqlDataAdapter("SELECT * FROM Personali", connect_1);
            DataSet ds_1 = new DataSet();
            adap_Pers.Fill(ds_1, "Personali");
            connect_1.Close();
            DataView dv_1 = new DataView(ds_1.Tables["Personali"]);
            //dv_1.Sort = "gvari";
            //dv_1.Sort = "gvari DESC"; // კლებადობით
            dv_1.Sort = "gvari, qalaqi DESC";
            //dv_1.RowFilter = textBox1.Text;
            dataGridView1.DataSource = dv_1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection connect_1 =
                new SqlConnection("server=ROMANI\\SQL_2012; database=Shekveta; Integrated Security = True");
            connect_1.Open();
            SqlDataAdapter adap_Pers = new SqlDataAdapter("SELECT * FROM Personali", connect_1);
            DataSet ds_1 = new DataSet();
            adap_Pers.Fill(ds_1, "Personali");
            connect_1.Close();
            DataView dv_1 = new DataView(ds_1.Tables["Personali"]);
            dv_1.Sort = "";  //  = textBox1.Text;
            dataGridView1.DataSource = dv_1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection connect_1 =
                new SqlConnection("server=ROMANI\\SQL_2012; database=Shekveta; Integrated Security = True");
            connect_1.Open();
            SqlDataAdapter adap_Pers = new SqlDataAdapter("SELECT * FROM Personali", connect_1);
            DataSet ds_1 = new DataSet();
            adap_Pers.Fill(ds_1, "Personali");
            connect_1.Close();
            //object count_pers = ds_1.Tables["Personali"].Compute("COUNT(gvari)", "");
            object count_pers = ds_1.Tables["Personali"].Compute("COUNT(gvari)", "qalaqi = 'თბილისი'");
            object sum_pers = ds_1.Tables["Personali"].Compute("SUM(xelfasi)", "");
            object avg_pers = ds_1.Tables["Personali"].Compute("AVG(staji)", "asaki > 40");
            object max_pers = ds_1.Tables["Personali"].Compute("MAX(asaki)", "");
            object min_pers = ds_1.Tables["Personali"].Compute("MIN(asaki)", "");
            label1.Text = count_pers.ToString();
            label2.Text = sum_pers.ToString();
            label3.Text = avg_pers.ToString();
            label4.Text = max_pers.ToString();
            label5.Text = min_pers.ToString();
        }
        

        private void button8_Click(object sender, EventArgs e)
        {
            int primary_key = int.Parse(textBox1.Text);
            SqlConnection connect_1 =
                new SqlConnection("server=ROMANI\\SQL_2012; database=Shekveta; Integrated Security = True");
            connect_1.Open();
            SqlDataAdapter adap_Pers = new SqlDataAdapter("SELECT * FROM Personali", connect_1);
            DataSet ds_1 = new DataSet();
            adap_Pers.Fill(ds_1, "Personali");
            connect_1.Close();
            DataColumn[] keys = new DataColumn[1];
            keys[0] = ds_1.Tables["Personali"].Columns["personaliID"];
            ds_1.Tables["Personali"].PrimaryKey = keys;
            DataRow find_row = ds_1.Tables["Personali"].Rows.Find(primary_key);
            if (find_row != null)
                label1.Text = find_row["gvari"] + "  " + find_row["asaki"].ToString();
            else label1.Text = "ვერ მოიძებნა";
            connect_1.Close();
        }
    }
}

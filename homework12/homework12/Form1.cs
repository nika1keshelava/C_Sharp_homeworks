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

namespace ADO_2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con_1 = new 
                SqlConnection("server=ROMANI\\SQL_2012; database=Shekveta; Integrated Security=true");
            con_1.Open();
            SqlDataAdapter adapt_personali = new SqlDataAdapter("SELECT * FROM Personali", con_1);
            SqlCommandBuilder builder_1 = new SqlCommandBuilder(adapt_personali);
            DataSet ds_1 = new DataSet();
            adapt_personali.Fill(ds_1, "Personali");
            label1.Text = ds_1.Tables["Personali"].Rows[3]["xelfasi"].ToString();
            ds_1.Tables["Personali"].Rows[3]["xelfasi"] = double.Parse(textBox1.Text);
            //ds_1.Tables["Personali"].Rows[3]["qalaqi"] = double.Parse(textBox2.Text);
            adapt_personali.Update(ds_1, "Personali");
            con_1.Close();
            label2.Text = ds_1.Tables["Personali"].Rows[3]["xelfasi"].ToString();
            dataGridView1.DataSource = ds_1;
            dataGridView1.DataMember = "Personali";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con_1 = new
                SqlConnection("server=ROMANI\\SQL_2012; database=Shekveta; Integrated Security=true");
            con_1.Open();
            SqlDataAdapter adapt_personali = new SqlDataAdapter("SELECT * FROM Personali", con_1);
            SqlCommandBuilder builder_1 = new SqlCommandBuilder(adapt_personali);
            DataSet ds_1 = new DataSet();
            adapt_personali.Fill(ds_1, "Personali");
            label1.Text = ds_1.Tables["Personali"].Rows.Count.ToString();
            DataRow dr_1 = ds_1.Tables["Personali"].NewRow();
            dr_1["gvari"] = textBox1.Text;
            dr_1["staji"] = textBox2.Text;
            dr_1["xelfasi"] = textBox3.Text;
            dr_1["tarigi_dabadebis"] = dateTimePicker1.Text;
            ds_1.Tables["Personali"].Rows.Add(dr_1);
            label2.Text = ds_1.Tables["Personali"].Rows.Count.ToString();
            adapt_personali.Update(ds_1, "Personali");
            con_1.Close();
            dataGridView1.DataSource = ds_1;
            dataGridView1.DataMember = "Personali";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pr_key = int.Parse(textBox1.Text);
            SqlConnection con_1 = new SqlConnection("server=ROMANI\\SQL_2012; database=Shekveta; Integrated Security=true");
            con_1.Open();
            SqlDataAdapter adapt_personali = new SqlDataAdapter("SELECT * FROM Personali", con_1);
            SqlCommandBuilder builder_1 = new SqlCommandBuilder(adapt_personali);
            DataSet ds_1 = new DataSet();
            adapt_personali.Fill(ds_1, "Personali");
            //
            DataColumn[] keys = new DataColumn[1];
            keys[0] = ds_1.Tables["Personali"].Columns["personaliID"];
            ds_1.Tables["Personali"].PrimaryKey = keys;
            //
            label2.Text = ds_1.Tables["Personali"].Rows.Count.ToString() + "    ";
            DataRow dr_1 = ds_1.Tables["Personali"].Rows.Find(pr_key);
            if ( dr_1 != null )
            {
                dr_1.Delete();
                adapt_personali.Update(ds_1, "Personali");
                label1.Text = "სტრიქონი წარმატებით წაიშალა";
            }
            else label1.Text = "სტრიქონი არ წაიშალა";
            con_1.Close();
            label2.Text += ds_1.Tables["Personali"].Rows.Count.ToString();
            dataGridView1.DataSource = ds_1;
            dataGridView1.DataMember = "Personali";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con_1 = new SqlConnection("server=ROMANI\\SQL_2012; database=Shekveta; Integrated Security=true");
            con_1.Open();
            SqlDataAdapter adapt_personali = new SqlDataAdapter("SELECT * FROM Personali", con_1);
            SqlDataAdapter adapt_shemkveti = new SqlDataAdapter("SELECT * FROM Shemkveti", con_1);
            DataSet ds_1 = new DataSet();
            adapt_personali.Fill(ds_1, "Personali");
            adapt_shemkveti.Fill(ds_1, "Shemkveti");
            DataRelation rel_pers_shem_1 = ds_1.Relations.Add("Personali_Shemkveti", 
                ds_1.Tables["Personali"].Columns["personaliID"], 
                ds_1.Tables["Shemkveti"].Columns["personaliID"]);
            con_1.Close();
            BindingSource bind_personli = new BindingSource(ds_1, "Personali");
            BindingSource bind_shemkveti = new BindingSource(ds_1, "Shemkveti");
            bind_shemkveti.DataSource = bind_personli;
            bind_shemkveti.DataMember = "Personali_Shemkveti";
            dataGridView1.DataSource = bind_personli;
            dataGridView2.DataSource = bind_shemkveti;
        }
    }
}

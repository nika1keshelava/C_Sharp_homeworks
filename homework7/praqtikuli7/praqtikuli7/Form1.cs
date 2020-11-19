using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace praqtikuli7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string striqoni = textBox1.Text;
            FileStream file_out = new FileStream("text1.txt", FileMode.Create);

            StreamWriter file_stream_out = new StreamWriter(file_out);
            file_stream_out.Write(striqoni);
            file_stream_out.Close();
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            string striqoni;

            FileStream file_in = new FileStream("text1.txt", FileMode.Open);
            StreamReader stream_file_in = new StreamReader(file_in);
            for (; (striqoni = stream_file_in.ReadLine()) != null;)
            {
                label1.Text += striqoni + "\n";
                stream_file_in.Close();
            }



        }
    }
}

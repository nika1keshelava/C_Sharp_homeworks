using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tviseba_Indexsatori_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 obj_1 = new Class1();
            int ricxvi = int.Parse(textBox1.Text);

            label1.Text = obj_1.Tviseba_1.ToString();
            obj_1.Tviseba_1 = ricxvi;
            label2.Text = obj_1.Tviseba_1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            Class2 obj_1 = new Class2();
            int i;

            for (i = 0; i < 3; i++)
                obj_1[i] = i + 5.5;

            for (i = 0; i < 3; i++)
                label1.Text += obj_1[i].ToString() + "  ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            Class3 obj_1 = new Class3();
            int i;

            for (i = 0; i < 3; i++)
                obj_1[i] = "ჯგუფი - " + i.ToString();

            for (i = 0; i < 3; i++)
                label1.Text += obj_1[i].ToString() + "\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            Class4 obj_1 = new Class4();
            int i;
            char str = char.Parse(textBox1.Text);

            for (i = 0; i < 3; i++)
                obj_1[i] = (char)(str + i);

            for (i = 0; i < 3; i++)
                label1.Text += obj_1[i].ToString() + "\n";
        }
    }
}

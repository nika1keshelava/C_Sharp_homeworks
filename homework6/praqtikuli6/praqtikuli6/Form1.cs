using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praqtikuli6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int arg1, arg2, arg3, arg4, arg5, arg6;

            arg1 = int.Parse(textBox1.Text);
            arg2 = int.Parse(textBox2.Text);
            arg3 = int.Parse(textBox3.Text);

            arg4 = int.Parse(textBox4.Text);
            arg5 = int.Parse(textBox5.Text);
            arg6 = int.Parse(textBox6.Text);


            Samkutxedi obieqti1 = new Samkutxedi(arg1, arg2, arg3);
            Samkutxedi obieqti2 = new Samkutxedi(arg4, arg5, arg6);

            label1.Text = obieqti1.Perimetri(obieqti1).ToString();
            label2.Text = obieqti1.Perimetri(obieqti2).ToString();

            label3.Text =  obieqti2.Perimetri(obieqti1).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int arg1, arg2, arg3, arg4;

            arg1 = int.Parse(textBox7.Text);
            arg2 = int.Parse(textBox8.Text);
            arg3 = int.Parse(textBox9.Text);
            arg4 = int.Parse(textBox10.Text);


            Martkutxedi obieqti1 = new Martkutxedi(arg1, arg2);
            Martkutxedi obieqti2 = new Martkutxedi(arg3, arg4);

            label1.Text = obieqti1.Fartobi(obieqti1).ToString();
            label2.Text = obieqti1.Fartobi(obieqti2).ToString();
            label3.Text = obieqti2.Fartobi(obieqti1).ToString();

        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] arg1 = new int[] { 10, 20, 30, 25, 999 };
            int[] arg2 = new int[] { 30, 20, 30, 25, 999 };
            int[] arg3 = new int[] { 50, 20, 30, 25, 999 };
            
            Klasi4 obieqti1 = new Klasi4(arg1);
            Klasi4 obieqti2 = new Klasi4(arg2);
            Klasi4 obieqti3 = new Klasi4(arg3);

            label1.Text = obieqti1.Jami(obieqti1).ToString();
            label2.Text = obieqti1.Jami(obieqti2).ToString();
            label3.Text = obieqti2.Jami(obieqti1).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class_2 obieqti = new Class_2();
            int[] masivi = new int[] { 8, 1, 11, 13, 16, 30, 50 };
            

            label4.Text = obieqti.Metodi_1(masivi).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Class__2 obieqti = new Class__2();
            int[,] masivi = new int[,] { { 8, 1, 11, 13, 16, 20, 24, 30, 50 },
                                     { 8, 1, 11, 13, 16, 20, 24, 30, 50 } };

            label5.Text = obieqti.Metodi_1(masivi).ToString();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praqtikuli1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            Studentebi1 nishani = new Studentebi1();
            int[] nishnebi = { 10, 9, 5, 6, 1, 5, 8, 9, 10, 9 };
            double sashualo = nishani.Metodi1(nishnebi);
            label2.Text = sashualo.ToString();
            textBox1.Text = sashualo.ToString();

            Studentebi2 minicheba = new Studentebi2();
            minicheba.Method1();
            minicheba.Print(label_saxeli,label_gvari, label_asaki);

            Matarebeli starti = new Matarebeli();
            starti.Minicheba();

            starti.Print(label_vagonebi, label_mgzavrebi, label_biletebisFasi,
                label_biletebisRaodenoba);
            textBox2.Text = starti.Method3().ToString();

            label_savarjisho.Text = textBox1.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_asaki_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

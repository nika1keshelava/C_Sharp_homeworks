using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChemiKlasi obieqti = new ChemiKlasi();
            Delegati delegati_mimartva;

            Delegati Shecvla_obieqti = new Delegati(obieqti.Shecvla);
            Delegati Washla_obieqti = new Delegati(obieqti.Washla);
            Delegati Shebruneba_obieqti = new Delegati(obieqti.Shebruneba);

            string striqoni = "metodebis mushaobis shemowmeba";

            label1.Text = striqoni;

            delegati_mimartva = Shecvla_obieqti;
            delegati_mimartva += Shebruneba_obieqti;

            delegati_mimartva(ref striqoni);
            label2.Text = striqoni;

            delegati_mimartva -= Shecvla_obieqti;
            delegati_mimartva += Washla_obieqti;
            striqoni = "metodebis mushaobis shemowmeba222";

            delegati_mimartva(ref striqoni);
            label3.Text = striqoni;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Savarjisho1 obieqti = new Savarjisho1();
            Delegati1 delegati_mimartva;

            Delegati1 kentebis_obieqti = new Delegati1(obieqti.Kentebi);
            Delegati1 luwebis_obieqti = new Delegati1(obieqti.Luwebi);
            Delegati1 kvelas_obieqti = new Delegati1(obieqti.Kvela);

            int[] masivi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            

            delegati_mimartva = kentebis_obieqti;
            delegati_mimartva += luwebis_obieqti;
            delegati_mimartva(ref masivi);

            delegati_mimartva -= kentebis_obieqti;
            delegati_mimartva += kvelas_obieqti;
            delegati_mimartva(ref masivi);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Savarjisho4 obieqti = new Savarjisho4();
            Delegati4 delegati_mimartva;

            Delegati4 kentebis_obieqti = new Delegati4(obieqti.Kentebi);
            Delegati4 luwebis_obieqti = new Delegati4(obieqti.Luwebi);
            Delegati4 kvelas_obieqti = new Delegati4(obieqti.Kvela);
            Delegati4 shemcirebis_obieqti = new Delegati4(obieqti.Shemcireba);

            int[,] masivi = {{1, 2, 3 },
                             {4, 5, 6 }};

            delegati_mimartva = kentebis_obieqti;
            delegati_mimartva += luwebis_obieqti;
            delegati_mimartva += kvelas_obieqti;
            delegati_mimartva(ref masivi);

            delegati_mimartva -= kentebis_obieqti;
            delegati_mimartva -= luwebis_obieqti;
            delegati_mimartva += shemcirebis_obieqti;
            delegati_mimartva(ref masivi);
            Console.WriteLine(masivi);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int ricxvi1 = int.Parse(textBox1.Text);
            int ricxvi2 = int.Parse(textBox2.Text);

            Movlenebi1 obieqti_movlena = new Movlenebi1();

            Delegati2_1 delegati2_1 = new Delegati2_1(obieqti_movlena.Movlena1Damamushavebeli);
            obieqti_movlena.Movlena1 += delegati2_1;

            obieqti_movlena.Metodi1(ricxvi1, ricxvi2, label1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int ricxvi1 = int.Parse(textBox3.Text);
            int ricxvi2 = int.Parse(textBox4.Text);

            Movlenebi2 obieqti_movlena = new Movlenebi2();

            Delegati2_2 delegati2_2 = new Delegati2_2(obieqti_movlena.Movlena2Damamushavebeli);
            obieqti_movlena.Movlena2 += delegati2_2;

            obieqti_movlena.Metodi2(ricxvi1, ricxvi2, label2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praqtikuli6
{
    class Kvadrati_1
    {
        private int gverdi, fartobi, perimetri;

        public Kvadrati_1(int par1, int par2, int par3)
        {
            gverdi = par1;
            fartobi = par2;
            perimetri = par3;
        }

        public void gamotana(System.Windows.Forms.Label label1, System.Windows.Forms.Label label2, System.Windows.Forms.Label label3)
        {
            label1.Text = gverdi.ToString();
            label2.Text = fartobi.ToString();
            label3.Text = perimetri.ToString();

        }
    }

    class Klasi_1
    {
        public int Metodi_1(Kvadrati_1 gverdi)
        {
            return 1;
        }
    }



    //mesame davaleba


    class Class_1
    {
        public int jami;

        public Class_1(int par1)
        {
            jami = par1;
        }
    }

    class Class_2
    {
        int[] masivi = new int[] { 8, 1, 11, 13, 16, 30, 50 };
        int jami;
        public int Metodi_1(int[] masivi)
        {
            foreach(int element in masivi)
            {
                if(element>10 & element < 20)
                {
                    jami += element;
                }
            }
            return jami;
        }
    }



    //meotxe davaleba


    class Class__1
    {
        public int jami;

        public Class__1(int par1)
        {
            jami = par1;
        }
    }

    class Class__2
    {
        int[,] masivi = new int[,] { { 8, 1, 11, 13, 16, 20, 24, 30, 50 }, 
                                     { 8, 1, 11, 13, 16, 20, 24, 30, 50 } };
        int jami;
        public int Metodi_1(int[,] masivi)
        {
            for(int i=0; i<2; i++)
            {
                for(int j=0; j < 9; j++)
                {
                    if(masivi[i,j]>10 & masivi[i, j] < 25)
                    {
                        jami += masivi[i, j];
                    }
                }
            }
            return jami;

        }
    }
}

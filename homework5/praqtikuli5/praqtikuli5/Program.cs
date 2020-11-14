using System;

namespace praqtikuli5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");            
        }
    }


    class Otxkutxedi
    {
        public static int gverdi1, gverdi2, gverdi3, gverdi4, perimetri;

        public Otxkutxedi(int par1, int par2, int par3, int par4)
        {
            gverdi1 = par1;
            gverdi2 = par2;
            gverdi3 = par3;
            gverdi4 = par4;
        }

        public void Perimetri()
        {
            perimetri = gverdi1 + gverdi2 + gverdi3 + gverdi4;

        }

        public static void Metodi(Otxkutxedi obieqti)
        {
            obieqti.Perimetri();
        }
    }


    class ChemiKlasi
    {
        public static int[] sia;
        public int jami = 0;
        public ChemiKlasi(int[] par1)
        {
            sia = par1;

        }

        public void KentebisJami()
        {
            foreach(int element in sia)
            {
                if (element % 2 == 1)
                {
                    jami += element;
                }
            }
            Console.WriteLine(jami);
        }
        public static void Methodi(ChemiKlasi obieqti)
        {
            obieqti.KentebisJami();

        }
    }

    class ChemiKlasi_2
    {
        public static int[][] sia;
        public int jami = 0;
        public ChemiKlasi_2(int[][] par1)
        {
            sia = par1;

        }

        public int KentebisJami()
        {
            foreach (int[] xazi in sia)
            {
                foreach (int element in xazi)
                {
                    if (element % 2 == 1)
                    {
                        jami += element;
                    }
                }
            }
            return jami;
        }
        public static void Methodi(ChemiKlasi_2 obieqti)
        {
            Console.WriteLine(obieqti.KentebisJami()); 

        }
    }

}

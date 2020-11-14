using System;
using System.Linq;

namespace praqtikuli2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("პრაქტიკული 2");
        }
    }


    class Tvitmfrinavi
    {
        private double tevadoba, mandzili;

        public Tvitmfrinavi(double par1, double par2)
        {
            tevadoba = par1;
            mandzili = par2;
        }

        public void Method2()
        {
            Console.WriteLine(tevadoba);
            Console.WriteLine(mandzili);
        }

        public double Method3()
        {
            return tevadoba * mandzili;
        }
    }


    class Samkutxedi
    {
        public double gverdi1, gverdi2, gverdi3;
        private double perimetri, fartobi;
        public Samkutxedi(double par1, double par2, double par3, 
            double par4, double par5)
        {
            gverdi1 = par1;
            gverdi2 = par2;
            gverdi3 = par3;
            perimetri = par4;
            fartobi = par5;

        }

        public void Method2()
        {
            Console.WriteLine(perimetri);
            Console.WriteLine(fartobi);
        }
    }


    class Avtomanqana
    {
        private string manqanisFeri;
        private int karebisRaodenoba;
        public string gvari, firma;

        public Avtomanqana(string par1,int par2,string par3, string par4)
        {
            manqanisFeri = par1;
            karebisRaodenoba = par2;
            gvari = par3;
            firma = par4;
        }

        public void Method2()
        {
            Console.WriteLine(manqanisFeri);
            Console.WriteLine(karebisRaodenoba);
            Console.WriteLine(gvari);
            Console.WriteLine(firma);
        }
    }

    //this სიტყვა

    class Klasi1
    {
        public int a, b, c;
        public int Method1(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            return this.a + this.b + this.c; 
        }
    }

    class Klasi2
    {
        public int a, b, c;
        public int Method1(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            return this.a * this.b * this.c;
        }
    }

    class Klasi3
    {
        public int[] sia;

        public int Method1(int[] sia)
        {
            this.sia = sia;
            foreach(int element in this.sia)
            {
                if (element < 0)
                {
                    return element;
                }
            }
            return 0;
        }
    }


    class Klasi4
    {
        public int[] sia;

        public int Method1(int[] sia)
        {
            this.sia = sia;
            return sia.Min();
        }
    }

}


//სახელების სივრცე 1
namespace Sivrce1
{
    class Samkutxedi
    {
        public int gverdi1, gverdi2, gverdi3;

        public int Fartobi()
        {
            return gverdi1 * gverdi2 /2;
        }
    }
}

namespace Sivrce2
{
    class Samkutxedi
    {
        public int gverdi1, gverdi2, gverdi3;

        public int Perimetri()
        {
            return gverdi1 + gverdi2 + gverdi3;
        }
    }
}

//სახელების სივრცე 2

namespace Sivrce_1
{
    class Otxkutxedi
    {
        public int gverdi1, gverdi2;

        public int Fartobi()
        {
            return gverdi1 * gverdi2;
        }
    }
}

namespace Sivrce_2
{
    class Otxkutxedi
    {
        public int gverdi1, gverdi2, gverdi3, gverdi4;

        public int Perimetri()
        {
            return gverdi1 + gverdi2 + gverdi3+ gverdi4;
        }
    }
}


//სივრცე3

namespace sivrce__1
{
    class Masivi
    {
        public int[] sia = {-1,-5,10, 15, 20, -13, 20, -3};
        public int sum = 0;
        public int Metodi1()
        {
            foreach (int item in sia)
            {
                if (item > 0){
                    sum += item;
                    
                }
            }
            return sum;
        }
    }
}


namespace sivrce__2
{
    class Masivi
    {
        public int[] sia = { -1, -5, 10, 15, 20, -13, 20, -3 };
        public int sum = 0;
        public int Metodi1()
        {
            foreach (int item in sia)
            {
                if (item < 0)
                {
                    sum += item;

                }
            }
            return sum;
        }
    }
}
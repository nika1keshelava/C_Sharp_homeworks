using System;

namespace praqtikuli4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("პრაქტიკული 4!:");
        }
    }


    class Samkutxedi
    {
        protected int gverdi1, gverdi2, gverdi3;

    }

    class SamkutxedisMemkvidre : Samkutxedi
    {
        private int perimetri;

        public int Fartobi()
        {
            return gverdi1 * gverdi2 / 2;
        }

        public void Perimetri()
        {
            Console.WriteLine(gverdi1 + gverdi2 + gverdi3);
        }
    }




    class Martkutxedi
    {
        protected int fudze;
    }

    class MartkutxedisMemkvidre : Martkutxedi
    {
        private int simagle;

        public int Fartobi()
        {
            return simagle * fudze;
        }
    }


}


//base საკვანძო სიტყვა
namespace base_sityva
{
    class Figura
    {
        public Figura(int par1)
        {

        }

        public Figura()
        {

        }

    }

    class Samkutxedi : Figura
    {
        public int perimetri;
        public int gverdi1, gverdi2, gverdi3;
        public Samkutxedi(int par1, int par2, int par3):base(par1)
        {
            gverdi1 = par1;
            gverdi2 = par2;
            gverdi3 = par3;
            perimetri = par1;
        }

        public int Perimetri()
        {
            return gverdi3 + gverdi2 + gverdi1;
        }
    }

    class Kvadrati: Figura
    {
        public int fartobi;
        public Kvadrati(int par1) : base(par1)
        {
            fartobi = par1*par1;
        }
    }//გავიჭედე, ვერ ვაკეთებ სამწუხაროდ



    //4

    class Pirovneba
    {
        protected int asaki;
        protected string saxeli, gvari;

        public Pirovneba(int par1, string par2, string par3)
        {
            asaki = par1;
            saxeli = par2;
            gvari = par3;
        }

        public void Gamotana()
        {
            Console.WriteLine(asaki.ToString(),gvari,saxeli);
        }
    }

    class Eqimi : Pirovneba
    {
        public int eqimis_asaki, saavadmyofos_N, staji;
        public string ganyofileba, tanamdeboba;


    }
}



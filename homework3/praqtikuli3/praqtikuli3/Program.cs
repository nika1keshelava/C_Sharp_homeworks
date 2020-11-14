using System;

namespace praqtikuli3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("praqtikuli 3:");
            //task 1 გაშვება
            Samkutxedi martkutxa_samkutxedi = new Samkutxedi();
            Console.WriteLine("fartobi " + martkutxa_samkutxedi.Metodi(5, 20));

            Samkutxedi chveulebrivi_samkutxedi = new Samkutxedi();
            Console.WriteLine("perimetri " + chveulebrivi_samkutxedi.Metodi(5, 20, 10));

            //task 2 გაშვება
            Avtomobili manqana1 = new Avtomobili();
            Console.WriteLine(manqana1.Metodi(100, 200));

            Avtomobili manqana2 = new Avtomobili();
            Console.WriteLine(manqana2.Metodi(240, 50));

            //task 3 გაშვება
            Matarebeli matarebeli1 = new Matarebeli();
            Console.WriteLine(matarebeli1.Metodi(100, 200));

            Matarebeli matarebeli2 = new Matarebeli();
            Console.WriteLine(matarebeli2.Metodi(5.6, 300));

            
            Kvadrati obj1 = new Kvadrati(5); // int
            Kvadrati obj2 = new Kvadrati();  //
            Kvadrati obj3 = new Kvadrati(obj1); // kvadrati
        }
    }

    //მეთოდის გადატვირთვა1

    class Samkutxedi
    {
        public int Metodi(int simagle, int fudze)
        {
            return simagle * fudze / 2;
        }

        public int Metodi(int gverdi1, int gverdi2, int gverdi3)
        {
            return gverdi1 + gverdi2 + gverdi3;
        }
    }

    //მეთოდის გადატვირთვა2

    class Avtomobili
    {
        public int Metodi(int bakis_tevadoba, int mandzili)
        {
            return bakis_tevadoba * mandzili;
        }

        public double Metodi(double max_speed, double time)
        {
            return max_speed * time;
        }
    }


    //მეთოდის გადატვირთვა3

    class Matarebeli
    {
        public int Metodi(int vagonebis_raodenoba, int mgzavrebis_raodenoba)
        {
            return vagonebis_raodenoba * mgzavrebis_raodenoba;
        }

        public double Metodi(double eleqtroenergia, double mandzili)
        {
            return eleqtroenergia * mandzili;
        }
    }

    //კონსტრუქტორის გადატვირთვა1


    class MinMax
    {
        public int min_max;
        int[] sia = { 10, 30, 40, 100 };
        double[] sia2 = { 5.6, 10.2, 20.3, 40.1 };
        public MinMax(int[] masivi)
        {
            min_max = sia[0];
        }

        public MinMax(double[] masivi)
        {
            min_max = (int)sia2[3];
        }

    }

    //კონსტრუქტორის გადატვირთვა2

    class Figura
    {
        public int gverdi1, gverdi2, gverdi3, perimetri, fartobi;

        public Figura(int parametri)
        {
            perimetri = 4 * gverdi1;
            fartobi = gverdi1 * gverdi1;
        }

        public Figura(int parametri1, int parametri2)
        {
            perimetri = 2 * (gverdi1 + gverdi2);
            fartobi = gverdi2 * gverdi1;
        }

        public Figura(int parametri1, int parametri2, int parametri3)
        {
            perimetri = gverdi1 + gverdi2 + gverdi3;
            fartobi = gverdi1 * gverdi2 / 2;
        }
    }

    //გადატვირთვადი კონსტრუქტორის გამოძახება this სიტყვის გამოყენებით1

    class Kvadrati
    { 

        int cvladi, perimetri;
        public Kvadrati(int parametri)
        {
            cvladi = parametri;
        }

        public Kvadrati():
            this(0)
        {
            perimetri = cvladi * 4;
        }

        public Kvadrati(Kvadrati raghaca):
            this(raghaca.cvladi)
        {
            perimetri = cvladi * 4;
        }
    }

}




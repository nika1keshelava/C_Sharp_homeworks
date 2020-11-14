using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace praqtikuli1
{
    class TvitmfrinavisKlasi
    {
        private int bakisTevadoba;
        private int mandzili;
        public int mgzavrebisRaodenoba;
        public int gayiduliBiletebisRaodenoba;

    }

    class StudentisKlasi
    {
        private string gvari, saxeli;
        private int asaki;
        public int kursi;
        public string universiteti;

    }

    class MatareblisKlasi
    {
        private int vagonebisRaodenoba, mgzavrebisRaodenoba;
        public int biletebisFasi, gayiduliBiletebisRaodenoba;
    }

    class MartkutxedisKlasi
    {
        private int perimetri, fartobi;
        public int gverdi1, gverdi2;
    }

    class AvtomanqanisKlasi
    {
        private string manqanisFeri;
        private int karebisRaodenoba;
        public string mflobelisGvari, gamomshvebiFirma;
    }


    //methodebi:


    class Studentebi1
    {
        public double Metodi1(int[] mas) {
            double sum = 0; 
            foreach  (int nishani in mas)
            {
                sum += nishani;
            }

            return sum / mas.Length;
        }

    }


    class Studentebi2
    {
        private string saxeli, gvari;
        private int asaki;

        private void Minicheba(string saxeli, string gvari, int asaki)
        {
            this.saxeli = saxeli;
            this.gvari = gvari;
            this.asaki = asaki;
        }

        public void Method1()
        {
            Minicheba("nika", "keshelava", 20);
        }

        public void Print(System.Windows.Forms.Label label_saxeli,                      System.Windows.Forms.Label label_gvari, 
           System.Windows.Forms.Label label_asaki)
        {
            label_saxeli.Text = saxeli;
            label_gvari.Text = gvari;
            label_asaki.Text = asaki.ToString();
        }
    }



    class Matarebeli
    {
        private int vagonebisRaodenoba, mgzavrebisRaodenoba;
        public int biletebisFasi, gayiduliBiletebiRaodenoba;

        public void Minicheba()
        {
            vagonebisRaodenoba = 10;
            mgzavrebisRaodenoba = 20;
            biletebisFasi = 30;
            gayiduliBiletebiRaodenoba = 40;
        }

        public void Print(System.Windows.Forms.Label label_vagonebi, System.Windows.Forms.Label label_mgzavrebi,
           System.Windows.Forms.Label label_biletebisFasi,
           System.Windows.Forms.Label label_biletebisRaodenoba)
        {
            label_vagonebi.Text = vagonebisRaodenoba.ToString();
            label_biletebisFasi.Text = biletebisFasi.ToString();
            label_mgzavrebi.Text = mgzavrebisRaodenoba.ToString();
            label_biletebisRaodenoba.Text = gayiduliBiletebiRaodenoba.ToString();
        }

        public int Method3()
        {
            return vagonebisRaodenoba * mgzavrebisRaodenoba 
                * biletebisFasi * gayiduliBiletebiRaodenoba;
        }
    }



    class Tvitmfrinavi
    {
        public double bakisTevadoba, mandzili;

        public void Minicheba()
        {
            bakisTevadoba = 5000;
            mandzili = 0.5;

        }

        public double Gamotana()
        {
            return bakisTevadoba;
        }

        public double Gamotvla()
        {
            return bakisTevadoba * mandzili;
        }
    }




}

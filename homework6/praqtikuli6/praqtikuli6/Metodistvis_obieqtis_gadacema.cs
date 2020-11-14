using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praqtikuli6
{
    class Samkutxedi
    {
        private int gverdi1, gverdi2, gverdi3, perimetri;

        public Samkutxedi(int par1, int par2, int par3)
        {
            gverdi1 = par1;
            gverdi2 = par2;
            gverdi3 = par3;
        }

        public int Perimetri(Samkutxedi sam1)
        {
            return sam1.gverdi1 + sam1.gverdi2 + sam1.gverdi3;
        }
    }


    class Martkutxedi
    {
        private int gverdi1, gverdi2, fartobi;

        public Martkutxedi(int par1, int par2)
        {
            gverdi1 = par1;
            gverdi2 = par2;

        }

        public int Fartobi(Martkutxedi mart1)
        {
            return mart1.gverdi1 * mart1.gverdi2;
        }
    }
    
    //me-4 davaleba

    class Klasi4
    {
        private int[] masivi;
        private int jami;

        public Klasi4(int[] par1)
        {
            masivi = par1;
        }

        public int Jami(Klasi4 masivi1)
        {
            foreach(int element in masivi)
            {
                if (element % 2 == 0)
                {
                    jami += element;
                }
            }
            return jami;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework8
{
    delegate void Delegati2_1(Label lab);
    class Movlenebi1
    {
        public event Delegati2_1 Movlena1;
        
        public void Metodi1(int par1, int par2, Label lab)
        {
            if (par1 >= par2) Movlena1(lab);
            
        }

        public void Movlena1Damamushavebeli(Label lab)
        {
            lab.Text = "აღიძრა მოვლენა, პირველი რიცხვი მეტია მეორეზე";
        }
    }


    delegate void Delegati2_2(Label lab);

    class Movlenebi2
    {
        public event Delegati2_2 Movlena2;

        public void Metodi2(int par1, int par2, Label lab)
        {
            if (par1%2==0 & par2%2==0)
            {
                Movlena2(lab);
            }

        }

        public void Movlena2Damamushavebeli(Label lab)
        {
            lab.Text = "აღიძრა მოვლენა, ორივე რიცხვი ლუწია";
        }
    }




}

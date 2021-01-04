using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tviseba_Indexsatori_5
{
    class Class2
    {
        double ricxvi1;
        double ricxvi2;
        double ricxvi3;
        public double this[int indexi]
        {
            get
            {
                switch (indexi)
                {
                    case 0: return ricxvi1;
                    case 1: return ricxvi2;
                    case 2: return ricxvi3;
                    default : return 0;
                }
            }
            set
            {
                switch (indexi)
                {
                    case 0: this.ricxvi1 = value; break;
                    case 1: this.ricxvi2 = value; break;
                    case 2: this.ricxvi3 = value; break;
                }
            }
        }
    }
}

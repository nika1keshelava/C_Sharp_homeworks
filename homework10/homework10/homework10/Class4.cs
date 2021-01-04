using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tviseba_Indexsatori_5
{
    class Class4
    {
        char char1;
        char char2;
        char char3;
        public char this[int indexi]
        {
            get
            {
                switch (indexi)
                {
                    case 0: return char1;
                    case 1: return char2;
                    case 2: return char3;
                    default: return '\0';
                }
            }
            set
            {
                switch (indexi)
                {
                    case 0: this.char1 = value; break;
                    case 1: this.char2 = value; break;
                    case 2: this.char3 = value; break;
                }
            }
        }
    }
}

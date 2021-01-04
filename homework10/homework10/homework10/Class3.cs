using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tviseba_Indexsatori_5
{
    class Class3
    {
        string str1;
        string str2;
        string str3;
        public string this[int indexi]
        {
            get
            {
                switch (indexi)
                {
                    case 0: return str1;
                    case 1: return str2;
                    case 2: return str3;
                    default: return "";
                }
            }
            set
            {
                switch (indexi)
                {
                    case 0: this.str1 = value; break;
                    case 1: this.str2 = value; break;
                    case 2: this.str3 = value; break;
                }
            }
        }
    }
}

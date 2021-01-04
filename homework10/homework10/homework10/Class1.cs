using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tviseba_Indexsatori_5
{
    class Class1
    {
        int ricxvi;
        public Class1()
        {
            ricxvi = 0;
        }
        public int Tviseba_1
        {
            get 
            {
                return ricxvi;
            }
            set 
            {
                if (value % 2 == 0) ricxvi = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework8
{
    delegate void Delegati(ref string striqoni1);

    class ChemiKlasi
    {
        public void Shecvla(ref string striqoni2)
        {
            striqoni2.Replace(' ', '-');
        }

        public void Washla(ref string striqoni2)
        {
            string temp = "";
            int i;

            for(i = 0; i<striqoni2.Length; i++)
            {
                if (striqoni2[i] != ' ')
                {
                    temp += striqoni2[i];
                }
            }
            ;
        }

        public void Shebruneba(ref string striqoni2)
        {
            string temp = "";
            int i;

            for(i=striqoni2.Length-1; i>=0; i--)
            {
                temp += striqoni2[i];
            }
            striqoni2 = temp;
        }

    }



    delegate void Delegati1(ref int[] masivi1);
    class Savarjisho1
    {
        
        public void Kentebi(ref int[] masivi2)
        {
            int i = 0;
            
            foreach (int element in masivi2)
            {
                if (element % 2 == 1)
                {
                    masivi2[i] = element * 3;
                    
                }
                i += 1;
            }
        }

        public void Luwebi(ref int[] masivi2)
        {
            int i = 0;
            
            foreach (int element in masivi2)
            {
                if (element % 2 == 0)
                {
                    masivi2[i] = element * 2;
                    
                }
                i += 1;
            }
        }


        public void Kvela(ref int[] masivi2)
        {
            int i = 0;
            foreach (int element in masivi2)
            {
                masivi2[i] = element * 2;
                i += 1;
            }
        }

    }

    delegate void Delegati4(ref int[,] masivi1);
    class Savarjisho4
    {
        public void Kentebi(ref int[,] masivi2)
        {
            for(int i = 0; i< masivi2.GetLength(0); i++)
            {
                for(int j = 0; j < masivi2.GetLength(1); j++)
                {
                    if(masivi2[i,j] % 2 == 1)
                    {
                        masivi2[i, j] = masivi2[i, j] * 7;
                    }
                }
            }
        }

        public void Luwebi(ref int[,] masivi2)
        {
            for (int i = 0; i < masivi2.GetLength(0); i++)
            {
                for (int j = 0; j < masivi2.GetLength(1); j++)
                {
                    if (masivi2[i, j] % 2 == 0)
                    {
                        masivi2[i, j] = masivi2[i, j] * 4;
                    }
                }
            }
        }

        public void Kvela(ref int[,] masivi2)
        {
            for (int i = 0; i < masivi2.GetLength(0); i++)
            {
                for (int j = 0; j < masivi2.GetLength(1); j++)
                {
                   masivi2[i, j] = masivi2[i, j] * 20;                 
                }
            }
        }

        public void Shemcireba(ref int[,] masivi2)
        {
            for (int i = 0; i < masivi2.GetLength(0); i++)
            {
                for (int j = 0; j < masivi2.GetLength(1); j++)
                {
                    masivi2[i, j] = masivi2[i, j] - 5;
                }
            }
        }
    }




}

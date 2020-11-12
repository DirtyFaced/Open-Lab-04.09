using System;
using System.Security.Principal;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                for (int ii = i + 1; ii < strings.Length; ii++)
                {
                    if (strings[i] == strings[ii])
                    {
                        strings[ii] = null;
                    }
                }
            }
            int a = 0;
            int b;
            for (int y = 0; y < strings.Length; y++)
            {
                if (strings[y] != null)
                {
                    string temp = strings[y];
                    strings[y] = null;
                    strings[a] = temp;
                    a = a + 1;
                }
            }
            string[] vysledok = new string[a];
            for (int yy = 0; yy < a; yy++)
            {
                vysledok[yy] = strings[yy];
            }
            return vysledok;
       }       
    }
}

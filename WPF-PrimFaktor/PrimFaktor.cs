using System;
using System.Collections.Generic;

namespace WPF_PrimFaktor
{
    class PrimFaktor
    {
        int prufZahl;
        int teiler = 3;
        public List<String> primFaktoren = new List<String>();

        public string Zerlegung(int eingabe)
        {
            prufZahl = eingabe;

            while (eingabe % 2 == 0)
            {
                primFaktoren.Add("2");
                eingabe /= 2;
            }

            while (eingabe > 1)
            {
                while (eingabe % teiler == 0)
                {
                    primFaktoren.Add(teiler.ToString());
                    eingabe /= teiler;
                }
                teiler += 2;
            }

            if (primFaktoren.Count == 1)
            {
                return prufZahl.ToString() + " ist eine Primzahl";
            }
            else
            {
                string output = string.Join("-", primFaktoren);
                return "Die Zerlegung ist " + output;
            }

            
        }
    }
}

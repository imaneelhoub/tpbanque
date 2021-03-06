using System;
using System.Collections.Generic;
using System.Text;

namespace TPAtelier1_banque
{
    class MAD
    {
        private double valeur;
        public MAD(double v)
        {
            this.valeur = v;
        }
        public MAD ajouter(MAD val)
        {
            valeur += val.valeur;
            return this;
        }
        public MAD debiter(MAD val)
        {
                valeur -= val.valeur;
            return this;
        }
       
        public int comparedouble(double s)
        {

            if (this.valeur >= s)
            {
                return 1;
            }
            else if (this.valeur <= s)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public int comparer(MAD val)
        {
            if (valeur>=val.valeur)
            {
                return 1;
            }
            return 0;
        }
        public string showVal()
        {

          string s= valeur.ToString();
            return s;
           
        }
    }
}

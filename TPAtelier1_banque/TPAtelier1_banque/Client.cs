using System;
using System.Collections.Generic;
using System.Text;

namespace TPAtelier1_banque
{
    class Client
    {
        private string nom;
        private string prenom;
        private string adresse;

        public Client(string n, string p,string a)
        {
            this.nom = n;
            this.prenom = p;
            this.adresse = a;
        }

        public string afficher()
        {
            string s;
             s = nom.ToString()+"    "+ prenom.ToString()+"    "+adresse.ToString();
            return s;
        }
    }
}

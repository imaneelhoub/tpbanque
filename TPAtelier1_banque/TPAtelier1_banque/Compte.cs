using System;
using System.Collections.Generic;
using System.Text;

namespace TPAtelier1_banque
{
    class Compte
    {
        private readonly int Numcompt;
        private static int cpt=0;
        private readonly Client titulaire;
        private MAD solde;
        private static MAD plafond = new MAD(5000);

        public Compte( Client t,MAD s)
        {
            this.Numcompt = ++cpt;
            this.titulaire = t;
            this.solde = s;
        }
        public bool Crediter(MAD somme)
        {
            if (somme.comparedouble(0)>=0)
            {
                solde = solde.ajouter(somme);
                Console.WriteLine("la somme crédité : " + somme.showVal());

                return true;
            }
            Console.WriteLine("erreur");
            return false;
        }
        public bool Debiter(MAD somme)
        {
            if (plafond.comparer(somme)==1 && solde.comparer(somme)==1)
            {
                solde = solde.debiter(somme);
                Console.WriteLine("la somme debité : " + somme.showVal());

                return true;
            }
            else
            {
                Console.WriteLine("solde insuffisant ou bien vous atteignez votre plafond : " + plafond.showVal());
                return false;
            }
        }
        public bool verser(MAD somme,Compte c)
        {
            if (this.solde.comparer(somme)==1 && somme.comparer(plafond)==0)
            {
                Debiter(somme);
                c.Crediter(somme);
                Console.WriteLine(somme.showVal() + "DH , versement effectue par :  " + this.Numcompt + titulaire.afficher()+"  " + "le solde du compte " + c.solde.showVal());
                return true;
            }
            else
            {
                Console.WriteLine("solde insuffisant ou bien vous atteignez votre plafond : " + plafond.showVal());
                return false;
            }
        }
        public void showcom()
        {
            Console.WriteLine("le num_compt : " + this.Numcompt + "  " + this.titulaire.afficher() + "   montant: " + this.solde.showVal());

        }

    }
}

using System;

namespace TPAtelier1_banque
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cl1 = new Client("elhoub", "imane", "adresse");
            Client cl2 = new Client("alaoui", "mohamed", "adresse");
            Console.WriteLine("le client 1:"+cl1.afficher());
            Console.WriteLine("le client 2:"+cl2.afficher());
            MAD M1 = new MAD(10000);
            MAD m2 = new MAD(1000);
            Console.WriteLine("le montant du compte1:"+M1.showVal());
            Console.WriteLine("le montant du compte2:" + m2.showVal());
            Compte c1 = new Compte(cl1,M1);
            Compte c2 = new Compte(cl2,m2);
            //c2.showcom();
            c1.Crediter(m2);
            c1.showcom();
             c1.Debiter(m2);
            c1.showcom();
            c1.verser(m2, c2);
            c1.showcom();
            Console.Read();
        }
    }
}

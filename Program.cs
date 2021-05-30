using System;
using System.Collections;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            CompteCourant nicolasCompteCourant = new CompteCourant(0, "Nicolas", new ArrayList(), 100F);
            CompteEpargne nicolasCompteEpargne = new CompteEpargne(0, "Nicolas", new ArrayList(), 0.08F);
            CompteCourant jeremieCompteCourant = new CompteCourant(0, "Jemine", new ArrayList(), 900);

            nicolasCompteCourant.crediter(800);
            nicolasCompteCourant.debiter(10);
            nicolasCompteCourant.crediter(280);
            nicolasCompteCourant.debiter(90);


            nicolasCompteEpargne.crediter(40);
            nicolasCompteEpargne.debiter(10);

            jeremieCompteCourant.debiter(100);
            jeremieCompteCourant.debiter(65, nicolasCompteCourant);

            Console.WriteLine("solde compte courant Nicolas: " + nicolasCompteCourant.solde);
            Console.WriteLine("solde compte épargne Nicolas: " + nicolasCompteEpargne.solde);
            Console.WriteLine("solde compte courant Jéremie: " + jeremieCompteCourant.solde);

            nicolasCompteCourant.afficher();
            nicolasCompteEpargne.afficher();
        }
    }
}

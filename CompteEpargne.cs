using System;
using System.Collections;

namespace TP1
{
    public class CompteEpargne : Compte
    {
        float taux;
        public CompteEpargne(float solde, string nomProp, ArrayList op, float taux) : base(solde, nomProp, op)
        {
            this.taux = taux;
        }
        public override void afficher()
        {
            Console.WriteLine("Résumé du compte de " + base.nomProp);
            Console.WriteLine("--------------");
            Console.WriteLine("Compte Courant de" + base.nomProp);
            Console.WriteLine("Solde: " + base.solde);
            Console.WriteLine("Taux: " + this.taux);
            Console.WriteLine();
            Console.WriteLine("Opérations: ");
            base.afficher();

        }
        public override void crediter(float somme)
        {
            base.solde += somme + somme * taux;
            base.operations.Add("+" + somme);
        }
        public override void crediter(float somme, Compte compte)
        {
            base.solde += somme + somme * taux;
            compte.solde -= somme;
            base.operations.Add("+" + somme);
            compte.operations.Add("-" + somme);
        }
    }
}

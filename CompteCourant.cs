using System;
using System.Collections;

namespace TP1
{
    public class CompteCourant : Compte
    {
        float decouvert;
        public CompteCourant(float solde, string nomProp, ArrayList op, float decouvert) : base(solde, nomProp, op)
        {
            this.decouvert = decouvert;
        }
        public override void afficher()
        {
            Console.WriteLine("Résumé du compte de " + base.nomProp);
            Console.WriteLine("--------------");
            Console.WriteLine("Compte Courant de" + base.nomProp);
            Console.WriteLine("Solde : " + base.solde);
            Console.WriteLine("Découvert autotisé : " + this.decouvert);
            Console.WriteLine();
            Console.WriteLine("Opérations : ");
            base.afficher();

        }
    }
}
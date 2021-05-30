using System;
using System.Collections;

namespace TP1
{
    public class Compte
    {
        public float solde;
        public string nomProp;
        public ArrayList operations;
        public Compte(float s, string nom, ArrayList op)
        {
            solde = s;
            nomProp = nom;
            operations = op;
        }
        public virtual void crediter(float somme)
        {
            this.solde += somme;
            operations.Add("+" + somme);
        }
        public virtual void crediter(float somme, Compte compte)
        {
            this.solde += somme;
            compte.solde -= somme;
            operations.Add("+" + somme);
            compte.operations.Add("-" + somme);
        }
        public void debiter(float somme)
        {
            this.solde -= somme;
            operations.Add("-" + somme);
        }
        public void debiter(float somme, Compte compte)
        {
            this.solde -= somme;
            compte.solde += somme;
            operations.Add("-" + somme);
            compte.operations.Add("+" + somme);
        }
        public virtual void afficher()
        {
            foreach (string op in operations)
            {
                Console.WriteLine(op);
            }
            Console.WriteLine("-------------------");
        }
    }
}
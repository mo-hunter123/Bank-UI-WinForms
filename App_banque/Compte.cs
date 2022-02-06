using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_banque
{
    public class Compte
    {
        public int numCompte;
        private static int num = 0;
        private Client titulaire;
        public float solde; 
        private static int plafond = 1000;
        private List<Operation> operations; 


        static Compte()
        {
            plafond = 1000; 
        }

        public Compte(Client c, float solde)
        {
            this.titulaire = c;
            this.numCompte = num++;
            if (0 <= solde && solde <= plafond)
                this.solde = solde;
            else
                this.solde = 0; 
            operations = new List<Operation>(); 
        }

        public void crediter(float somme)
        {
            this.solde = this.solde + somme;
            this.operations.Add(new OperationV(somme, this)); 
        }

        public bool debiter(float somme)
        {
            if(this.solde >= somme && somme <= plafond)
            {
                this.solde -= somme;
                this.operations.Add(new OperationR(somme, this)); 

                return true; 
            }
            return false; 
        }

        public bool verser(float somme, Compte c)
        {
            if (this.debiter(somme))
            {
                c.crediter(somme);
                return true; 
            }

            return false; 
        }

        public override string ToString()
        {
            return "Num: " + this.numCompte + " Solde: " + this.solde;
        }
    }
}

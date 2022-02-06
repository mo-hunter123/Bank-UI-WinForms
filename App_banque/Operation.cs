using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_banque
{
    public abstract class Operation
    {
        private static int num = 0;
        private int ID;
        private float solde;
        private DateTime dateOp;
        private Compte c;

        public Operation(float solde, Compte c)
        {
            this.c = c;
            this.solde = solde;
            dateOp = DateTime.UtcNow;
            this.ID = num++; 
        }

        public abstract string showOperation();

        public override string ToString()
        {
            return "Compte: " + this.c + " Date: "+this.dateOp + " Solde: " + this.solde;
        }
    }
}

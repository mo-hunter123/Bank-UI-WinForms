using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_banque
{
    class OperationR: Operation
    {
        public static string libelle = "-";

        public OperationR(float solde, Compte c) : base(solde, c)
        {

        }
        public override string showOperation()
        {

            return base.ToString() + " Ope: " + libelle;
        }
    }
}

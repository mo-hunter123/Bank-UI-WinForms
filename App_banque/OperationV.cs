using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_banque
{

    public class OperationV: Operation
    {
        public static string libelle = "+";

        public OperationV(float solde, Compte c) : base(solde, c)
        {

        }
        public override string showOperation()
        {

            return base.ToString() + " Ope: " + libelle; 
        }

        
    }
}

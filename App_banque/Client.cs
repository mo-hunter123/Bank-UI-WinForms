using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_banque
{
    public class Client
    {
        public string nom { get; }
        public string prenom { get; }
        private string pass;
        public List<Compte> comptes; 

        public Client(string nom, string prenom, string pass)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.pass = pass;
            this.comptes = new List<Compte>(); 
        }
        
        public bool auth(string L, string pas)
        {
            if (this.nom == L && this.pass == pas)
                return true;
            return false; 
        }

        public bool addCompte(Compte c)
        {
            if (this.comptes.Contains(c))
                return false;
            this.comptes.Add(c);
            return true;
        }

        public override string ToString()
        {
            return "Nom: " + this.nom + " Prenom: " + this.prenom;
        }
    }
}

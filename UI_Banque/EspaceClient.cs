using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_banque; 

namespace UI_Banque
{
    public partial class EspaceClient : Form
    {
        Client currentUser;
        Compte compte;

        public EspaceClient()
        {
            InitializeComponent();
        }


        public void addToListView(Compte c)
        {

        }

        private void EspaceClient_Load(object sender, EventArgs e)
        {
            currentUser = Form1.authenticatedUser;
            saluteUser.Text = "Bonjour \n " + currentUser.nom;


            currentUser.addCompte(new Compte(currentUser, 100));
            currentUser.addCompte(new Compte(currentUser, 500));
            currentUser.addCompte(new Compte(currentUser, 300));
            currentUser.addCompte(new Compte(currentUser, 750));
            currentUser.addCompte(new Compte(currentUser, 142));


            accountsList.View = View.Details;
            accountsList.GridLines = true;
            //accountsList.FullRowSelect = true;

            // column header 
            accountsList.Columns.Add("NumeroCompte", 100); 
            accountsList.Columns.Add("Solde", 70);


            foreach(Compte co in currentUser.comptes)
            {
                string[] arr = new string[3];

                arr[0] = co.numCompte.ToString();
                arr[1] = co.solde.ToString();

                ListViewItem itm = new ListViewItem(arr);
                accountsList.Items.Add(itm);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void accountsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            currentUser.addCompte(new Compte(currentUser, 324));
        }
    }
}

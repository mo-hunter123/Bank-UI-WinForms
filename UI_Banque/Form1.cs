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
    
    public partial class Form1 : Form
    {
        List<Client> clients = new List<Client>();
        public static Client authenticatedUser; 
        
        public Form1()
        {
            InitializeComponent();

            // after here we will load the users and test the authentication 
            clients.Add(new Client("user1", "pus1", "pass1"));
            clients.Add(new Client("user2", "pus2", "pass2"));
        }

       
        private void button1_Click_2(object sender, EventArgs e)
        {
            bool trouv = false; 
            foreach (Client item in clients)
            {
                if(item.auth(textBox2.Text, textBox1.Text))
                {
                   
                    trouv = true;
                    authenticatedUser = item; 
                    break; 
                }
                    
            }
            if (trouv == false)
                MessageBox.Show("Sorry");
            else
            {
                this.Hide();
                var espaceClient = new EspaceClient();
                espaceClient.Show();
            }
        }

       
    }
}

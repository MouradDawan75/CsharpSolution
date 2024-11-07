using ProjetWindowsForms.Models;
using ProjetWindowsForms.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetWindowsForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                // MessageBox.Show("Email et password sont obligatoires...");
                lblErreur.Text = "Email et password sont obligatoires...";
            }
            else
            {
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                Utilisateur u = UtilisateurRepository.FindByEmail(email);
                if (u != null && password.Equals(u.Password))
                {
                    //Connexion OK

                    Form1 f = new Form1();


                    txtEmail.Clear();
                    txtPassword.Clear();
                    lblErreur.Text = "";

                    this.Visible = false;

                    //Si user admin
                    if (!u.Admin)
                    {
                        f.UserNotAdmin();
                    }


                    f.ShowDialog(this); //garder un lien de parenté entre ces 2 fenêtres
                }
                else
                {
                    lblErreur.Text = "Echec connexion.......";
                }
            }

            
        }
    }
}

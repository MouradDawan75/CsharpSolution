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
    public partial class UtilisateurForm : Form
    {
        public UtilisateurForm()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text.Equals("") || txtPassword.Text.Equals("") || picture.Image == null)
            {
                MessageBox.Show("Tous champs sont obligatoires");
            }
            Utilisateur u = new Utilisateur(txtEmail.Text, txtPassword.Text, picture.ImageLocation, checkBoxAdmin.Checked); ;

            UtilisateurRepository.Insert(u);
            Reset();
        }

        private void Reset()
        {
            txtEmail.Clear();
            txtPassword.Clear();
            checkBoxAdmin.Checked = false;
            picture.Image = null;
            picture.ImageLocation = null;
        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Afficher l'image dans PictureBox
                picture.Image = Image.FromFile(openFileDialog1.FileName);
                picture.ImageLocation = openFileDialog1.FileName; //conserver le chemin de l'image
            }
        }
    }
}

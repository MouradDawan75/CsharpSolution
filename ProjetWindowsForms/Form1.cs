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
using System.Windows.Forms.VisualStyles;

namespace ProjetWindowsForms
{
    public partial class Form1 : Form
    {
        BDD bdd = new BDD();
        public Form1()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void demoFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Afficher la fenêtre DemoForm
            DemoForm demo = new DemoForm();

            //Option1: fenêtre parent + fenêtres enfants

            //Définir la fenêtre parente
            //demo.MdiParent = this; -- Dans la fenêtre principale -> mettre la propriété isMdiParent à true
            //demo.Show();

            //Option2: utiliser de fenêtres modales (bloquante)

            demo.ShowDialog(); //affiche une boite modale (fenêtre bloquante)
        }

        private void gestionFichieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FichierForm fichierForm = new FichierForm();
            fichierForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProduitRepository.Insert(new Produit(1000, "PC Dell", 999, 10));
            MessageBox.Show("Produit inséré....");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // timer1.Interval = 1000; // 1 seconde
            //DateTime dt = DateTime.Now;
            //string heure = dt.ToLongTimeString();
            //lblHeure.Text = heure;
            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1 seconde
            DateTime dt = DateTime.Now;
            string heure = dt.ToLongTimeString();
            lblHeure.Text = heure;
            timer1.Start();
        }

        private void baseDeDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            bdd.ShowDialog();
        }

        private void gestionDesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UtilisateurForm utilisateurForm = new UtilisateurForm();
            utilisateurForm.ShowDialog();
        }

        internal void UserNotAdmin()
        {
            gestionDesUtilisateursToolStripMenuItem.Enabled = false;
            bdd.UserNotAdmin();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = this.Owner as LoginForm;
            loginForm.Visible = true;
            this.Close();
        }
    }
}

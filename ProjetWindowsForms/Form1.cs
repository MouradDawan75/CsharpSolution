using ProjetDLL;
using ProjetWindowsForms.Models;
using ProjetWindowsForms.Repository;
using ProjetWindowsForms.Service;
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

            List<Produit> lst = ProduitRepository.GetAll();
            foreach (Produit produit in lst)
            {
                listBox1.Items.Add(produit);
            }

           
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

        private void button2_Click(object sender, EventArgs e)
        {
            List<Ligne> lignes = new List<Ligne>();
            lignes.Add(new Ligne("l1", "nc1", "adc1", "c1"));
            lignes.Add(new Ligne("l2", "nc2", "adc2", "c2"));
            lignes.Add(new Ligne("l3", "nc3", "adc3", "c3"));
            XmlTool.ExportXml(@"c:\dossier\lignes.xml", lignes);
        }

        private void Remplir(List<Ligne> lignes)
        {
            listBox2.Items.Clear();
            foreach (var ligne in lignes)
            {
                listBox2.Items.Add(ligne);
            }
        }

        private void Clear()
        {
            txtAdresse.Clear();
            txtCouleur.Clear();
            txtNom.Clear();
            txtDescription.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Ligne> lignes = XmlTool.ImportXml(@"c:\dossier\lignes.xml");
            foreach(var ligne in lignes)
            {
                listBox2.Items.Add(ligne);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Ligne l = new Ligne(txtDescription.Text, txtNom.Text, txtAdresse.Text, txtCouleur.Text);
            List<Ligne> lignes = XmlTool.ImportXml(@"c:\dossier\lignes.xml");
            lignes.Add(l);
            XmlTool.ExportXml(@"c:\dossier\lignes.xml", lignes);
            Remplir(XmlTool.ImportXml(@"c:\dossier\lignes.xml"));
            Clear();
            
        }

        private void btnAjouterCsv_Click(object sender, EventArgs e)
        {
            Ligne l = new Ligne(txtDescriptionCsv.Text, txtNomClientCsv.Text, txtAdresseClientCsv.Text, txtCoueurCsv.Text);
            List<Ligne> lst = CsvTool.ImportCsv(@"c:\dossier\lignes.csv");
            lst.Add(l);
            CsvTool.ExportCsv(@"c:\dossier\lignes.csv", lst);
            RemplirListBoxCsv(lst);
        }

        private void RemplirListBoxCsv(List<Ligne> lst)
        {
            listBox3.Items.Clear();
            foreach (var item in lst)
            {
                listBox3.Items.Add(item);
            }

            ClearChampsCsv();
        }

        private void ClearChampsCsv()
        {
            txtDescriptionCsv.Clear();
            txtNomClientCsv.Clear();
            txtAdresseClientCsv.Clear();
            txtCoueurCsv.Clear();
            btnAjouterCsv.Text = "Ajouter";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Ligne> lignes = new List<Ligne>();
            lignes.Add(new Ligne("l1", "nc1", "adc1", "c1"));
            lignes.Add(new Ligne("l2", "nc2", "adc2", "c2"));
            lignes.Add(new Ligne("l3", "nc3", "adc3", "c3"));
            CsvTool.ExportCsv(@"c:\dossier\lignes.csv", lignes);
        }

        private void btnLectureCSV_Click(object sender, EventArgs e)
        {
            //Remplir la listeBox3 à partir du fichier CSV
            //listBox3.Items.Clear();

            //foreach (var item in CsvTool.ImportCsv(@"c:\dossier\lignes.csv"))
            //{
            //    listBox3.Items.Add(item);   
            //} 

            RemplirListBoxCsv(CsvTool.ImportCsv(@"c:\dossier\lignes.csv"));
        }
    }
}

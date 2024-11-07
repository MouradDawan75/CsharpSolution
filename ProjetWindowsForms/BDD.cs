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
    public partial class BDD : Form
    {
        public BDD()
        {
            InitializeComponent();
        }

        private void BDD_Load(object sender, EventArgs e)
        {
            List<Produit> prods = ProduitRepository.GetAll();
            //dataGridView1.DataSource = false; //RAZ
            //dataGridView1.DataSource = prods;
            Remplir(prods);
        }

        private void Remplir(List<Produit> lst)
        {
            dataGridView1.DataSource = false; //RAZ
            dataGridView1.DataSource = lst;
        }

        private void Reset()
        {
            txtID.Clear();
            txtDescription.Clear();
            txtPrix.Clear();
            txtQuantite.Clear();
            btnAjouter.Text = "Ajouter";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //Construire un produit à partir des champs de saisie
            Produit p = new Produit();
            p.Description = txtDescription.Text;
            p.Prix = Convert.ToInt32(txtPrix.Text);
            p.Quantite = Convert.ToInt32(txtQuantite.Text);

            //Insérer ou maj le produit en BD

            if (btnAjouter.Text.Equals("Ajouter"))
            {
                ProduitRepository.Insert(p);
            }
            else
            {
                p.Id = Convert.ToInt32(txtID.Text);
                ProduitRepository.Update(p);
            }
            

            //Actualiser la GridView
            Remplir(ProduitRepository.GetAll());

            //Réinitialiser les champs de saisie
            Reset();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            Remplir(ProduitRepository.FindByKey(txtMotCle.Text));
        }

        private void txtMotCle_TextChanged(object sender, EventArgs e)
        {
            Remplir(ProduitRepository.FindByKey(txtMotCle.Text));
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;

           if( MessageBox.Show("Etes-vous sûr de vouloir supprimer le produit ?", "Suppression d'un produit", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
            {
                ProduitRepository.Delete(id);

                //Actualiser la table
                Remplir(ProduitRepository.GetAll());
            }

            
        }

        private void bnModifier_Click(object sender, EventArgs e)
        {
            //Récupérer le produit sélectionné -> remplir les champs de saisie

            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            Produit p = ProduitRepository.GetById(id);

            txtID.Text = p.Id.ToString();
            txtDescription.Text = p.Description;
            txtPrix.Text = p.Prix.ToString();
            txtQuantite.Text = p.Quantite.ToString();
            btnAjouter.Text = "Modifier";
        }

        internal void UserNotAdmin()
        {
            //btnAjouter.Enabled = false;
            //btnSupprimer.Enabled = false;
            //bnModifier.Enabled = false;

            groupBox2.Enabled = false;
            bnModifier.Enabled = false;
            btnSupprimer.Enabled = false;

        }
    }
}

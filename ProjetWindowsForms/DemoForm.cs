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
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            //Récupérer le contenu des 2 TextBox
            try
            {

                double nb1 = Convert.ToDouble(txtNb1.Text);
                double nb2 = Convert.ToDouble(txtNb2.Text);
                double resultat = nb1 + nb2;
                lblResultat.Text = $"Somme =  {resultat.ToString()}";

                MessageBox.Show($"Somme = {resultat}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nombre invalide....");
                txtNb1.Clear();
                txtNb2.Clear();
            }
            

            
        }

        private void txtNb2_Leave(object sender, EventArgs e)
        {
            //try
            //{

            //    double nb1 = Convert.ToDouble(txtNb1.Text);
            //    double nb2 = Convert.ToDouble(txtNb2.Text);
            //    double resultat = nb1 + nb2;
            //    lblResultat.Text = $"Somme =  {resultat.ToString()}";

            //    MessageBox.Show($"Somme = {resultat}");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Nombre invalide....");
            //    txtNb1.Clear();
            //    txtNb2.Clear();
            //}

        }

        private void txtNb2_TextChanged(object sender, EventArgs e)
        {
            try
            {

                double nb1 = Convert.ToDouble(txtNb1.Text);
                double nb2 = Convert.ToDouble(txtNb2.Text);
                double resultat = nb1 + nb2;
                lblResultat.Text = $"Somme =  {resultat.ToString()}";

                //MessageBox.Show($"Somme = {resultat}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nombre invalide....");
                txtNb1.Clear();
                txtNb2.Clear();
            }
        }
    }
}

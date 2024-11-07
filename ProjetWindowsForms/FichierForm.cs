using ProjetDLL;
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
    public partial class FichierForm : Form
    {
        public FichierForm()
        {
            InitializeComponent();
        }

        private void btnEcriture_Click(object sender, EventArgs e)
        {
            try
            {
                //string chemin = @"c:\dossier\winform.txt";
                string chemin = "";
                saveFileDialog1.InitialDirectory = @"c:\dossier\";
                saveFileDialog1.Filter = "Fichier Texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";

                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    chemin = saveFileDialog1.FileName;
                    string contenu = txtEcriture.Text;
                    Tools.EcritureFichier(chemin, contenu, true);

                    MessageBox.Show("Contenu inséré dans: " + chemin);
                    txtEcriture.Clear();
                }
                else
                {
                    MessageBox.Show("Ecriture annulée......");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void btnLecture_Click(object sender, EventArgs e)
        {
            try
            {
                //string chemin = @"c:\dossier\winform.txt";
                string chemin = "";
                openFileDialog1.InitialDirectory = @"c:\dossier\";
                openFileDialog1.Filter = "Fichier Texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    chemin = openFileDialog1.FileName;
                    string conteunu = Tools.LectureFichier(chemin);
                    txtLecture.Text = conteunu;
                }
                else
                {
                    MessageBox.Show("Lecture annulée...");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

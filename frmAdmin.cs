using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Assemblies;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsBureau2Change
{
    public partial class frmAdmin : Form
    {
        clsBureau bureau = new clsBureau("B001", "TD", "87 HUJ ZZ", "Legal");
        clsPays paysCourant = new clsPays();
        string mode = "";
        int Indexcourant;


        public frmAdmin()
        {

            InitializeComponent();
        }

        private bool TextToDecimal(string txt)
        {

            try
            {
                decimal result = Convert.ToDecimal(txt);
                return true;
            }
            catch
            {
                return false;
            }
        }



        private void frmAdmin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            bureau.Pays = clsSourceDesDonnees.GetTousLesPays();
            lstPays.Items.Clear();
            foreach (clsPays unPays in bureau.Pays)
            {
                lstPays.Items.Add(unPays.Nom.ToString());
            }
            btnAnnuler_Click(sender, e);

        }

        private void lstPays_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPays.SelectedItem == null)
            { return; }
            lblInformation.Text = "Pays " + (lstPays.SelectedIndex + 1) + " Sur un totale de " + lstPays.Items.Count;
            string nomSelectonne = lstPays.SelectedItem.ToString();
            Indexcourant = lstPays.SelectedIndex;
            foreach (clsPays unPays in bureau.Pays)
            {
                if (nomSelectonne == unPays.Nom)
                {
                    txtNom.Text = unPays.Nom.ToString();
                    txtMonnaie.Text = unPays.Monnaie.ToString();
                    txtValeur.Text = (1/unPays.Valeur).ToString();
                    paysCourant = new clsPays(unPays.Nom, unPays.Monnaie, unPays.Valeur);
                    btnAjouter.Enabled = btnSauvegarder.Enabled = false;
                    btnSupprimer.Enabled = btnModifier.Enabled = btnAnnuler.Enabled = true;

                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtNom.Text.Length < 1)
            {
                MessageBox.Show("Veuille remplir le nom");
                txtNom.Focus();
                return;

            }
            else if (txtMonnaie.Text.Length < 1)
            {
                MessageBox.Show("Veuille remplir la monnaie");
                txtMonnaie.Focus();
                return;
            }
            else if (txtValeur.Text.Length < 1)
            {
                MessageBox.Show("Veuille remplir la valeur");
                txtValeur.Focus();
                return;

            }
            else if (!TextToDecimal(txtValeur.Text))
            {
                MessageBox.Show("Veuille insérer une valeur decimale");
                txtValeur.Focus();
                return;
            }
            else
            {
                mode = "ajout";

                btnModifier.Enabled = btnSupprimer.Enabled = btnAjouter.Enabled = false;

                btnSauvegarder.Enabled = btnAnnuler.Enabled = true;
                lblInformation.Text = "En mode Ajout...";
                lstPays.Enabled = false;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (txtNom.Text.Length < 1)
            {
                MessageBox.Show("Veuille remplir le nom");
                txtNom.Focus();
                return;

            }
            else if (txtMonnaie.Text.Length < 1)
            {
                MessageBox.Show("Veuille remplir la monnaie");
                txtMonnaie.Focus();
                return;
            }
            else if (txtValeur.Text.Length < 1)
            {
                MessageBox.Show("Veuille remplir la valeur");
                txtValeur.Focus();
                return;

            }
            else if (!TextToDecimal(txtValeur.Text))
            {
                MessageBox.Show("Veuille insérer une valeur decimale");
                txtValeur.Focus();
                return;

            }
            else
            {
                mode = "modif";


                btnModifier.Enabled = btnSupprimer.Enabled = btnAjouter.Enabled = false;

                btnSauvegarder.Enabled = btnAnnuler.Enabled = true;
                lblInformation.Text = "En mode Modification...";
                lstPays.Enabled = false;


            }

        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            if (mode == "ajout")
            {

                paysCourant = new clsPays(txtNom.Text, txtMonnaie.Text, Convert.ToDecimal(txtValeur.Text));
                bureau.Pays.Add(paysCourant);
                lstPays.Items.Add(paysCourant.Nom);
                txtNom.Text = txtMonnaie.Text = txtValeur.Text = "";


            }
            else if (mode == "modif")
            {
                paysCourant.Nom = txtNom.Text;
                paysCourant.Monnaie = txtMonnaie.Text;
                paysCourant.Valeur = Convert.ToDecimal(txtValeur.Text);
                lstPays.Items[Indexcourant] = paysCourant.Nom;
                bureau.Pays[Indexcourant] = paysCourant;


            }
            lstPays.Enabled = true;
            btnAjouter.Enabled = btnSauvegarder.Enabled = btnAnnuler.Enabled = false;
            btnSupprimer.Enabled = btnModifier.Enabled = true;
            foreach (clsPays unPays in bureau.Pays)
            {
               MessageBox.Show( unPays.Nom+"\n"+ unPays.Monnaie+"\n"+ unPays.Valeur.ToString());
               
            }
            clsSourceDesDonnees.SaveTousLesPays(bureau.Pays);
            frmAdmin_Load(sender, e);

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtMonnaie.Text = txtValeur.Text = txtNom.Text = "";
            txtNom.Focus();
            lblInformation.Text = "Information";
            btnAjouter.Enabled = true;
            btnSupprimer.Enabled = btnModifier.Enabled = btnSauvegarder.Enabled = btnAnnuler.Enabled = false;
            lstPays.Enabled = true;
            lstPays.SelectedIndex = -1;

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce pays ?", "Confirmation",  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bureau.Pays.RemoveAt(Indexcourant);

                lstPays.Items.RemoveAt(Indexcourant);

                txtNom.Text = txtMonnaie.Text = txtValeur.Text = "";
                lblInformation.Text = "Information";

                btnSupprimer.Enabled = btnModifier.Enabled = btnSauvegarder.Enabled = btnAnnuler.Enabled = false;
                btnAjouter.Enabled = true;
                

                MessageBox.Show("Le pays a été supprimé avec succès.");
                clsSourceDesDonnees.SaveTousLesPays(bureau.Pays);
            }
        }
    }
}

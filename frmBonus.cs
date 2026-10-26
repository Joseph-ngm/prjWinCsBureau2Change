using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsBureau2Change
{
    public partial class frmBonus : Form
    {

        private List<clsPays> tousLesPays = new List<clsPays>();
        private clsPays paysSource;
        private clsPays paysCible;
        public frmBonus()
        {
            InitializeComponent();
        }


        private void MettreAJourTaux()
        {
            if (cboMonnaieSource.SelectedIndex < 0 || cboMonnaieCible.SelectedIndex < 0) return;

            paysSource = tousLesPays[cboMonnaieSource.SelectedIndex];
            paysCible = tousLesPays[cboMonnaieCible.SelectedIndex];

            lblMonnaieSource.Text = paysSource.Monnaie;

            if (paysCible.Valeur != 0)
            {
               // decimal tauxSource = paysSource.Valeur / paysSource.Valeur;
                decimal tauxCible = paysCible.Valeur / paysSource.Valeur;
                lblTaux.Text = "1 " + paysSource.Monnaie + " = " + Math.Round(tauxCible, 4) + " " + paysCible.Monnaie;
            }
            else
            {
                lblTaux.Text = "Taux indisponible";
            }

            lblMontantConverti.Text = "...";
        }
        private void frmBonus_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            lblDateToday.Text = "Montréal, Aujourd'hui " + DateTime.Today.ToLongDateString();

            tousLesPays = clsSourceDesDonnees.GetTousLesPays();

            cboMonnaieSource.Items.Clear();
            cboMonnaieCible.Items.Clear();
            foreach (clsPays p in tousLesPays)
            {
                string texte = p.Nom + " - " + p.Monnaie;
                cboMonnaieSource.Items.Add(texte);
                cboMonnaieCible.Items.Add(texte);
            }

            cboMonnaieSource.SelectedIndex = 0;
            cboMonnaieCible.SelectedIndex = 1;
            cboMonnaieCible.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMonnaieSource.DropDownStyle = ComboBoxStyle.DropDownList;

            lblTaux.Text = "...";
            lblMonnaieSource.Text = "...";
            lblMontantConverti.Text = "...";
            txtMontant.Clear();
            cboMonnaieCible_SelectedIndexChanged(sender, e);    
            cboMonnaieSource_SelectedIndexChanged(sender,e);
        }


        private void cboMonnaieSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            MettreAJourTaux();
        }

        private void cboMonnaieCible_SelectedIndexChanged(object sender, EventArgs e)
        {
            MettreAJourTaux();
        }

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            string txt = txtMontant.Text;

            if (txt.Length > 0)
            {
                paysSource = tousLesPays[cboMonnaieSource.SelectedIndex];
                paysCible = tousLesPays[cboMonnaieCible.SelectedIndex];

                decimal montantSource = Convert.ToDecimal(txt);

                decimal taux = 0;
                if (paysCible.Valeur != 0)
                {
                    taux = paysSource.Valeur / paysCible.Valeur;
                }
                
                decimal resultat = Math.Round(montantSource * taux, 2);
                lblMontantConverti.Text = resultat.ToString() + " " + paysCible.Monnaie;
            }
            else
            {
                MessageBox.Show("Veuillez entrer un montant !", "Champ vide",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMontant.Focus();
            }
        }

        private void btnRecommencer_Click(object sender, EventArgs e)
        {
            cboMonnaieSource.SelectedIndex = 0;
            cboMonnaieCible.SelectedIndex = 1;

            txtMontant.Clear();

            lblTaux.Text = "...";
            lblMonnaieSource.Text = "...";
            lblMontantConverti.Text = "...";

            txtMontant.Focus();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

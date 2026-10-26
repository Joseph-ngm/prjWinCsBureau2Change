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
    public partial class frmChange : Form
    {
        private List<clsPays> tousLesPays = new List<clsPays>();
        private clsPays paysCourant ;
        int indiceCourant;
        string monnaieCan = "CAN. Dollars";
        public frmChange()
        {
            InitializeComponent();
        }


          private void ViderLeTextBox()
        {
            txtMontant.Clear();
            lblMontantConverti.Text = "...";
        }
        private void frmChange_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;


            lblDateToday.Text = "Montréal, Aujourd'hui " + DateTime.Today.ToLongDateString();

            tousLesPays = clsSourceDesDonnees.GetTousLesPays();

            cboPays.Items.Clear();
            foreach (clsPays unPays in tousLesPays)
            {
                cboPays.Items.Add(unPays.Nom + " - " + unPays.Monnaie);
            }
            
            cboPays.SelectedIndex = 0;
            cboPays_SelectedIndexChanged(sender, e);
            cboPays.DropDownStyle= ComboBoxStyle.DropDownList;
        }

        private void cboPays_SelectedIndexChanged(object sender, EventArgs e)
        {
          
             indiceCourant = cboPays.SelectedIndex;
            paysCourant = tousLesPays[indiceCourant];

            double taux = Convert.ToDouble(paysCourant.Valeur);

            lblCadToOther.Text = "1 "+ monnaieCan +" "+ Math.Round(taux, 2) + " " + paysCourant.Monnaie;
            lblOtherToCad.Text = "1 " + paysCourant.Monnaie + " = " + Math.Round(1 / taux, 2) +" "+ monnaieCan;

            radCadToOther.Text = monnaieCan + " vers " + paysCourant.Monnaie;
            radOtherToCad.Text = paysCourant.Monnaie + " vers "+ monnaieCan;

            radCadToOther.Checked = true;

            radCadToOther_CheckedChanged(sender,e);
            txtMontant.Focus();


        }

        private void radCadToOther_CheckedChanged(object sender, EventArgs e)
        {
          
                ViderLeTextBox();
                lblMonnaie.Text = monnaieCan;
                lblMontantConverti.Text = paysCourant.Monnaie;
            
        }
        

        private void radOtherToCad_CheckedChanged(object sender, EventArgs e)
        {
            
                ViderLeTextBox();
                lblMonnaie.Text = paysCourant.Monnaie;
                lblMontantConverti.Text = monnaieCan;

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            string montant = txtMontant.Text;

            if (montant.Length > 0)
            {
                decimal valeurEntree = Convert.ToDecimal(montant);

                decimal taux = paysCourant.Valeur;
                if (radCadToOther.Checked)
                {
                    
                    lblMontantConverti.Text = Math.Round(valeurEntree * taux, 2).ToString() + " " + paysCourant.Monnaie;
                }
                else
                {
                    lblMontantConverti.Text = Math.Round(valeurEntree * 1/taux, 2).ToString() + " " + monnaieCan;
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un montant !", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMontant.Focus();
            }
        }

        private void btnRecommencer_Click(object sender, EventArgs e)
        {
           

            txtMontant.Clear();
            frmChange_Load(sender, e);
            cboPays.SelectedIndex = 0;
            cboPays_SelectedIndexChanged(sender, e);
            txtMontant.Focus();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

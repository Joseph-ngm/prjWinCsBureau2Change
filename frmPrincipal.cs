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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void bureauDeChangeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmChange frmGuichet = new frmChange();
            frmGuichet.MdiParent = this;
            this.Size = frmGuichet.Size;
            frmGuichet.Show();
        }

        private void gestionDesPaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frmAdmin = new frmAdmin();
            frmAdmin.MdiParent = this;
            this.Size = frmAdmin.Size;
            frmAdmin.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bonusToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmBonus frmBonus = new frmBonus();
            frmBonus.MdiParent = this;
            this.Size = frmBonus.Size;
            frmBonus.Show();
        }
    }
}

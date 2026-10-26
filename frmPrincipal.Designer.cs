namespace prjWinCsBureau2Change
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuPrincipal = new MenuStrip();
            programmesToolStripMenuItem = new ToolStripMenuItem();
            projetsToolStripMenuItem = new ToolStripMenuItem();
            bureauDeChangeToolStripMenuItem1 = new ToolStripMenuItem();
            gestionDesPaysToolStripMenuItem = new ToolStripMenuItem();
            bonusToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            mnuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mnuPrincipal
            // 
            mnuPrincipal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mnuPrincipal.Items.AddRange(new ToolStripItem[] { programmesToolStripMenuItem });
            mnuPrincipal.Location = new Point(0, 0);
            mnuPrincipal.Name = "mnuPrincipal";
            mnuPrincipal.Size = new Size(596, 25);
            mnuPrincipal.TabIndex = 1;
            mnuPrincipal.Text = "menuStrip1";
            // 
            // programmesToolStripMenuItem
            // 
            programmesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { projetsToolStripMenuItem, bonusToolStripMenuItem, toolStripSeparator1, quitterToolStripMenuItem });
            programmesToolStripMenuItem.Name = "programmesToolStripMenuItem";
            programmesToolStripMenuItem.Size = new Size(98, 21);
            programmesToolStripMenuItem.Text = "Programmes";
            // 
            // projetsToolStripMenuItem
            // 
            projetsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bureauDeChangeToolStripMenuItem1, gestionDesPaysToolStripMenuItem });
            projetsToolStripMenuItem.Name = "projetsToolStripMenuItem";
            projetsToolStripMenuItem.Size = new Size(164, 22);
            projetsToolStripMenuItem.Text = "Projets";
            // 
            // bureauDeChangeToolStripMenuItem1
            // 
            bureauDeChangeToolStripMenuItem1.Name = "bureauDeChangeToolStripMenuItem1";
            bureauDeChangeToolStripMenuItem1.Size = new Size(190, 22);
            bureauDeChangeToolStripMenuItem1.Text = "Bureau De Change";
            bureauDeChangeToolStripMenuItem1.Click += bureauDeChangeToolStripMenuItem1_Click;
            // 
            // gestionDesPaysToolStripMenuItem
            // 
            gestionDesPaysToolStripMenuItem.Name = "gestionDesPaysToolStripMenuItem";
            gestionDesPaysToolStripMenuItem.Size = new Size(190, 22);
            gestionDesPaysToolStripMenuItem.Text = "Gestion Des Pays";
            gestionDesPaysToolStripMenuItem.Click += gestionDesPaysToolStripMenuItem_Click;
            // 
            // bonusToolStripMenuItem
            // 
            bonusToolStripMenuItem.Name = "bonusToolStripMenuItem";
            bonusToolStripMenuItem.Size = new Size(164, 22);
            bonusToolStripMenuItem.Text = "Bonus";
            bonusToolStripMenuItem.Click += bonusToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(161, 6);
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.X;
            quitterToolStripMenuItem.Size = new Size(164, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 251);
            Controls.Add(mnuPrincipal);
            IsMdiContainer = true;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            mnuPrincipal.ResumeLayout(false);
            mnuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuPrincipal;
        private ToolStripMenuItem programmesToolStripMenuItem;
        private ToolStripMenuItem projetsToolStripMenuItem;
        private ToolStripMenuItem bureauDeChangeToolStripMenuItem1;
        private ToolStripMenuItem gestionDesPaysToolStripMenuItem;
        private ToolStripMenuItem bonusToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem quitterToolStripMenuItem;
    }
}
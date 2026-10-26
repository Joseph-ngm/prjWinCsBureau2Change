namespace prjWinCsBureau2Change
{
    partial class frmAdmin
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
            label5 = new Label();
            label6 = new Label();
            btnAnnuler = new Button();
            btnSauvegarder = new Button();
            btnSupprimer = new Button();
            btnModifier = new Button();
            btnAjouter = new Button();
            txtValeur = new TextBox();
            groupBox1 = new GroupBox();
            lstPays = new ListBox();
            txtMonnaie = new TextBox();
            txtNom = new TextBox();
            lblInformation = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bodoni MT", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(237, 66);
            label5.Name = "label5";
            label5.Size = new Size(298, 25);
            label5.TabIndex = 7;
            label5.Text = "Bureau De Changes International";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bodoni MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(260, 35);
            label6.Name = "label6";
            label6.Size = new Size(264, 28);
            label6.TabIndex = 6;
            label6.Text = "BANQUE DE TORONTO";
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = Color.Black;
            btnAnnuler.ForeColor = Color.LimeGreen;
            btnAnnuler.Location = new Point(348, 165);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(109, 30);
            btnAnnuler.TabIndex = 12;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = false;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // btnSauvegarder
            // 
            btnSauvegarder.BackColor = Color.Black;
            btnSauvegarder.ForeColor = Color.LimeGreen;
            btnSauvegarder.Location = new Point(348, 134);
            btnSauvegarder.Name = "btnSauvegarder";
            btnSauvegarder.Size = new Size(109, 30);
            btnSauvegarder.TabIndex = 11;
            btnSauvegarder.Text = "Sauvegarder";
            btnSauvegarder.UseVisualStyleBackColor = false;
            btnSauvegarder.Click += btnSauvegarder_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = Color.Black;
            btnSupprimer.ForeColor = Color.LimeGreen;
            btnSupprimer.Location = new Point(348, 103);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(109, 30);
            btnSupprimer.TabIndex = 10;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.Black;
            btnModifier.ForeColor = Color.LimeGreen;
            btnModifier.Location = new Point(348, 72);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(109, 30);
            btnModifier.TabIndex = 9;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.Black;
            btnAjouter.ForeColor = Color.LimeGreen;
            btnAjouter.Location = new Point(348, 41);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(109, 30);
            btnAjouter.TabIndex = 8;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // txtValeur
            // 
            txtValeur.ForeColor = Color.Maroon;
            txtValeur.Location = new Point(99, 108);
            txtValeur.Name = "txtValeur";
            txtValeur.Size = new Size(78, 25);
            txtValeur.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 192);
            groupBox1.Controls.Add(lstPays);
            groupBox1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.Location = new Point(46, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 251);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choisir un pays :";
            // 
            // lstPays
            // 
            lstPays.FormattingEnabled = true;
            lstPays.Location = new Point(13, 27);
            lstPays.Name = "lstPays";
            lstPays.Size = new Size(183, 208);
            lstPays.TabIndex = 0;
            lstPays.SelectedIndexChanged += lstPays_SelectedIndexChanged;
            // 
            // txtMonnaie
            // 
            txtMonnaie.ForeColor = Color.Maroon;
            txtMonnaie.Location = new Point(99, 77);
            txtMonnaie.Name = "txtMonnaie";
            txtMonnaie.Size = new Size(178, 25);
            txtMonnaie.TabIndex = 6;
            // 
            // txtNom
            // 
            txtNom.ForeColor = Color.Maroon;
            txtNom.Location = new Point(99, 45);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(178, 25);
            txtNom.TabIndex = 1;
            // 
            // lblInformation
            // 
            lblInformation.ForeColor = Color.Blue;
            lblInformation.Location = new Point(20, 160);
            lblInformation.Name = "lblInformation";
            lblInformation.Size = new Size(306, 30);
            lblInformation.TabIndex = 4;
            lblInformation.Text = "Information";
            lblInformation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(182, 118);
            label4.Name = "label4";
            label4.Size = new Size(164, 15);
            label4.TabIndex = 3;
            label4.Text = "Par rapport à 1 CAN. Dollar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 85);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 2;
            label3.Text = "Monnaie :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 116);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 1;
            label2.Text = "Valeur :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 53);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 0;
            label1.Text = "Nom pays :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(192, 255, 192);
            groupBox2.Controls.Add(btnAnnuler);
            groupBox2.Controls.Add(btnSauvegarder);
            groupBox2.Controls.Add(btnSupprimer);
            groupBox2.Controls.Add(btnModifier);
            groupBox2.Controls.Add(btnAjouter);
            groupBox2.Controls.Add(txtValeur);
            groupBox2.Controls.Add(txtMonnaie);
            groupBox2.Controls.Add(txtNom);
            groupBox2.Controls.Add(lblInformation);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic);
            groupBox2.Location = new Point(281, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(476, 251);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Infrmations sur le pays choisi";
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(803, 415);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmAdmin";
            Text = "s";
            Load += frmAdmin_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label6;
        private Button btnAnnuler;
        private Button btnSauvegarder;
        private Button btnSupprimer;
        private Button btnModifier;
        private Button btnAjouter;
        private TextBox txtValeur;
        private GroupBox groupBox1;
        private ListBox lstPays;
        private TextBox txtMonnaie;
        private TextBox txtNom;
        private Label lblInformation;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
    }
}
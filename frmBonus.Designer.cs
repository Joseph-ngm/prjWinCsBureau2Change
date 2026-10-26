namespace prjWinCsBureau2Change
{
    partial class frmBonus
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
            label1 = new Label();
            btnFermer = new Button();
            btnRecommencer = new Button();
            groupBox4 = new GroupBox();
            lblMontantConverti = new Label();
            btnConvertir = new Button();
            lblMonnaieSource = new Label();
            txtMontant = new TextBox();
            label5 = new Label();
            cboMonnaieCible = new ComboBox();
            label4 = new Label();
            cboMonnaieSource = new ComboBox();
            lblTaux = new Label();
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            lblDateToday = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(148, 34);
            label1.Name = "label1";
            label1.Size = new Size(264, 28);
            label1.TabIndex = 6;
            label1.Text = "BANQUE DE TORONTO";
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(297, 414);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(93, 30);
            btnFermer.TabIndex = 8;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += btnFermer_Click;
            // 
            // btnRecommencer
            // 
            btnRecommencer.Location = new Point(107, 415);
            btnRecommencer.Name = "btnRecommencer";
            btnRecommencer.Size = new Size(93, 30);
            btnRecommencer.TabIndex = 7;
            btnRecommencer.Text = "Recommencer";
            btnRecommencer.UseVisualStyleBackColor = true;
            btnRecommencer.Click += btnRecommencer_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(128, 255, 128);
            groupBox4.Controls.Add(lblMontantConverti);
            groupBox4.Controls.Add(btnConvertir);
            groupBox4.Controls.Add(lblMonnaieSource);
            groupBox4.Controls.Add(txtMontant);
            groupBox4.Location = new Point(41, 272);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(424, 124);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Entrez le montant : ";
            // 
            // lblMontantConverti
            // 
            lblMontantConverti.AutoSize = true;
            lblMontantConverti.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblMontantConverti.Location = new Point(280, 77);
            lblMontantConverti.Name = "lblMontantConverti";
            lblMontantConverti.Size = new Size(21, 20);
            lblMontantConverti.TabIndex = 6;
            lblMontantConverti.Text = "...";
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(47, 73);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(93, 30);
            btnConvertir.TabIndex = 5;
            btnConvertir.Text = "Convertir ";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblMonnaieSource
            // 
            lblMonnaieSource.AutoSize = true;
            lblMonnaieSource.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblMonnaieSource.Location = new Point(280, 42);
            lblMonnaieSource.Name = "lblMonnaieSource";
            lblMonnaieSource.Size = new Size(21, 20);
            lblMonnaieSource.TabIndex = 4;
            lblMonnaieSource.Text = "...";
            // 
            // txtMontant
            // 
            txtMontant.Location = new Point(47, 39);
            txtMontant.Name = "txtMontant";
            txtMontant.Size = new Size(213, 23);
            txtMontant.TabIndex = 3;
            txtMontant.TextChanged += txtMontant_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(248, 30);
            label5.Name = "label5";
            label5.Size = new Size(131, 15);
            label5.TabIndex = 6;
            label5.Text = "Monnaie de conversion";
            // 
            // cboMonnaieCible
            // 
            cboMonnaieCible.FormattingEnabled = true;
            cboMonnaieCible.Location = new Point(248, 48);
            cboMonnaieCible.Name = "cboMonnaieCible";
            cboMonnaieCible.Size = new Size(154, 23);
            cboMonnaieCible.TabIndex = 7;
            cboMonnaieCible.SelectedIndexChanged += cboMonnaieCible_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 30);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 1;
            label4.Text = "Monnaie source";
            // 
            // cboMonnaieSource
            // 
            cboMonnaieSource.FormattingEnabled = true;
            cboMonnaieSource.Location = new Point(18, 48);
            cboMonnaieSource.Name = "cboMonnaieSource";
            cboMonnaieSource.Size = new Size(154, 23);
            cboMonnaieSource.TabIndex = 2;
            cboMonnaieSource.SelectedIndexChanged += cboMonnaieSource_SelectedIndexChanged;
            // 
            // lblTaux
            // 
            lblTaux.AutoSize = true;
            lblTaux.ForeColor = Color.FromArgb(192, 0, 0);
            lblTaux.Location = new Point(220, 29);
            lblTaux.Name = "lblTaux";
            lblTaux.Size = new Size(16, 15);
            lblTaux.TabIndex = 4;
            lblTaux.Text = "...";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(128, 255, 128);
            groupBox3.Controls.Add(lblTaux);
            groupBox3.Location = new Point(41, 186);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(424, 64);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Taux actuel : ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(128, 255, 128);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cboMonnaieCible);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cboMonnaieSource);
            groupBox2.Location = new Point(41, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(424, 100);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Selectionner  les devises : ";
            // 
            // lblDateToday
            // 
            lblDateToday.AutoSize = true;
            lblDateToday.Location = new Point(226, 35);
            lblDateToday.Name = "lblDateToday";
            lblDateToday.Size = new Size(16, 15);
            lblDateToday.TabIndex = 0;
            lblDateToday.Text = "...";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 192);
            groupBox1.Controls.Add(btnFermer);
            groupBox1.Controls.Add(btnRecommencer);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(lblDateToday);
            groupBox1.Location = new Point(41, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(497, 473);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Programme De Changes Des Monnaies Inter,ationales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bodoni MT", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(125, 65);
            label2.Name = "label2";
            label2.Size = new Size(298, 25);
            label2.TabIndex = 7;
            label2.Text = "Bureau De Changes International";
            // 
            // frmBonus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(578, 630);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Name = "frmBonus";
            Text = "frmBonus";
            Load += frmBonus_Load;
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnFermer;
        private Button btnRecommencer;
        private GroupBox groupBox4;
        private Label lblMontantConverti;
        private Button btnConvertir;
        private Label lblMonnaieSource;
        private TextBox txtMontant;
        private Label label5;
        private ComboBox cboMonnaieCible;
        private Label label4;
        private ComboBox cboMonnaieSource;
        private Label lblTaux;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label lblDateToday;
        private GroupBox groupBox1;
        private Label label2;
    }
}
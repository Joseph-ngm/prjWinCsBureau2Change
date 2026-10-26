namespace prjWinCsBureau2Change
{
    partial class frmChange
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
            groupBox1 = new GroupBox();
            btnFermer = new Button();
            btnRecommencer = new Button();
            groupBox4 = new GroupBox();
            lblMontantConverti = new Label();
            btnConvertir = new Button();
            lblMonnaie = new Label();
            txtMontant = new TextBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            radOtherToCad = new RadioButton();
            radCadToOther = new RadioButton();
            groupBox2 = new GroupBox();
            lblOtherToCad = new Label();
            lblCadToOther = new Label();
            cboPays = new ComboBox();
            label4 = new Label();
            lblDateToday = new Label();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 192);
            groupBox1.Controls.Add(btnFermer);
            groupBox1.Controls.Add(btnRecommencer);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cboPays);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblDateToday);
            groupBox1.Location = new Point(63, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(475, 513);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Programme De Change Avec Le Dollar Canadien";
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(286, 470);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(93, 30);
            btnFermer.TabIndex = 8;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += btnFermer_Click;
            // 
            // btnRecommencer
            // 
            btnRecommencer.Location = new Point(94, 470);
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
            groupBox4.Controls.Add(lblMonnaie);
            groupBox4.Controls.Add(txtMontant);
            groupBox4.Controls.Add(label3);
            groupBox4.Location = new Point(6, 330);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(459, 124);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Apply the conversion";
            // 
            // lblMontantConverti
            // 
            lblMontantConverti.AutoSize = true;
            lblMontantConverti.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblMontantConverti.Location = new Point(174, 85);
            lblMontantConverti.Name = "lblMontantConverti";
            lblMontantConverti.Size = new Size(21, 20);
            lblMontantConverti.TabIndex = 6;
            lblMontantConverti.Text = "...";
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(41, 77);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(93, 30);
            btnConvertir.TabIndex = 5;
            btnConvertir.Text = "Convertir >>";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblMonnaie
            // 
            lblMonnaie.AutoSize = true;
            lblMonnaie.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblMonnaie.Location = new Point(280, 42);
            lblMonnaie.Name = "lblMonnaie";
            lblMonnaie.Size = new Size(21, 20);
            lblMonnaie.TabIndex = 4;
            lblMonnaie.Text = "...";
            // 
            // txtMontant
            // 
            txtMontant.Location = new Point(174, 34);
            txtMontant.Name = "txtMontant";
            txtMontant.Size = new Size(100, 23);
            txtMontant.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 42);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 2;
            label3.Text = "Entrez le montant :";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(128, 255, 128);
            groupBox3.Controls.Add(radOtherToCad);
            groupBox3.Controls.Add(radCadToOther);
            groupBox3.Location = new Point(6, 186);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(459, 100);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Type de conversion";
            // 
            // radOtherToCad
            // 
            radOtherToCad.AutoSize = true;
            radOtherToCad.ForeColor = Color.FromArgb(192, 0, 0);
            radOtherToCad.Location = new Point(30, 53);
            radOtherToCad.Name = "radOtherToCad";
            radOtherToCad.Size = new Size(14, 13);
            radOtherToCad.TabIndex = 1;
            radOtherToCad.TabStop = true;
            radOtherToCad.UseVisualStyleBackColor = true;
            radOtherToCad.CheckedChanged += radOtherToCad_CheckedChanged;
            // 
            // radCadToOther
            // 
            radCadToOther.AutoSize = true;
            radCadToOther.ForeColor = Color.FromArgb(192, 0, 0);
            radCadToOther.Location = new Point(30, 28);
            radCadToOther.Name = "radCadToOther";
            radCadToOther.Size = new Size(14, 13);
            radCadToOther.TabIndex = 0;
            radCadToOther.TabStop = true;
            radCadToOther.UseVisualStyleBackColor = true;
            radCadToOther.CheckedChanged += radCadToOther_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(128, 255, 128);
            groupBox2.Controls.Add(lblOtherToCad);
            groupBox2.Controls.Add(lblCadToOther);
            groupBox2.Location = new Point(226, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(239, 100);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Les valeurs actuelles";
            // 
            // lblOtherToCad
            // 
            lblOtherToCad.AutoSize = true;
            lblOtherToCad.ForeColor = Color.FromArgb(192, 0, 0);
            lblOtherToCad.Location = new Point(26, 45);
            lblOtherToCad.Name = "lblOtherToCad";
            lblOtherToCad.Size = new Size(0, 15);
            lblOtherToCad.TabIndex = 5;
            // 
            // lblCadToOther
            // 
            lblCadToOther.AutoSize = true;
            lblCadToOther.ForeColor = Color.FromArgb(192, 0, 0);
            lblCadToOther.Location = new Point(26, 21);
            lblCadToOther.Name = "lblCadToOther";
            lblCadToOther.Size = new Size(0, 15);
            lblCadToOther.TabIndex = 4;
            // 
            // cboPays
            // 
            cboPays.FormattingEnabled = true;
            cboPays.Location = new Point(12, 90);
            cboPays.Name = "cboPays";
            cboPays.Size = new Size(154, 23);
            cboPays.TabIndex = 2;
            cboPays.SelectedIndexChanged += cboPays_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 72);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 1;
            label4.Text = "Choisir votre pays";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(157, 14);
            label1.Name = "label1";
            label1.Size = new Size(264, 28);
            label1.TabIndex = 6;
            label1.Text = "BANQUE DE TORONTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bodoni MT", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(134, 45);
            label2.Name = "label2";
            label2.Size = new Size(298, 25);
            label2.TabIndex = 7;
            label2.Text = "Bureau De Changes International";
            // 
            // frmChange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(600, 653);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "frmChange";
            Text = "frmChange";
            Load += frmChange_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnFermer;
        private Button btnRecommencer;
        private GroupBox groupBox4;
        private Label lblMontantConverti;
        private Button btnConvertir;
        private Label lblMonnaie;
        private TextBox txtMontant;
        private Label label3;
        private GroupBox groupBox3;
        private RadioButton radOtherToCad;
        private RadioButton radCadToOther;
        private GroupBox groupBox2;
        private Label lblOtherToCad;
        private Label lblCadToOther;
        private ComboBox cboPays;
        private Label label4;
        private Label lblDateToday;
        private Label label1;
        private Label label2;
    }
}

namespace Colocation_CROUS
{
    partial class FNouvelleDepense
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
            this.btnValider = new System.Windows.Forms.Button();
            this.lblLaDate = new System.Windows.Forms.Label();
            this.lblTexte = new System.Windows.Forms.Label();
            this.lblJustificatif = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.btnReparti = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbTexte = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbidColoc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(185, 311);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(97, 47);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // lblLaDate
            // 
            this.lblLaDate.AutoSize = true;
            this.lblLaDate.Location = new System.Drawing.Point(25, 101);
            this.lblLaDate.Name = "lblLaDate";
            this.lblLaDate.Size = new System.Drawing.Size(36, 13);
            this.lblLaDate.TabIndex = 1;
            this.lblLaDate.Text = "Date :";
            // 
            // lblTexte
            // 
            this.lblTexte.AutoSize = true;
            this.lblTexte.Location = new System.Drawing.Point(25, 137);
            this.lblTexte.Name = "lblTexte";
            this.lblTexte.Size = new System.Drawing.Size(40, 13);
            this.lblTexte.TabIndex = 2;
            this.lblTexte.Text = "Texte :";
            // 
            // lblJustificatif
            // 
            this.lblJustificatif.AutoSize = true;
            this.lblJustificatif.Location = new System.Drawing.Point(292, 58);
            this.lblJustificatif.Name = "lblJustificatif";
            this.lblJustificatif.Size = new System.Drawing.Size(59, 13);
            this.lblJustificatif.TabIndex = 3;
            this.lblJustificatif.Text = "Justificatif :";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(25, 187);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(52, 13);
            this.lblMontant.TabIndex = 4;
            this.lblMontant.Text = "Montant :";
            // 
            // btnReparti
            // 
            this.btnReparti.AutoSize = true;
            this.btnReparti.Location = new System.Drawing.Point(30, 231);
            this.btnReparti.Name = "btnReparti";
            this.btnReparti.Size = new System.Drawing.Size(47, 13);
            this.btnReparti.TabIndex = 5;
            this.btnReparti.Text = "Reparti :";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(98, 101);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(100, 20);
            this.tbDate.TabIndex = 6;
            this.tbDate.TextChanged += new System.EventHandler(this.tbDate_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(98, 180);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // tbTexte
            // 
            this.tbTexte.Location = new System.Drawing.Point(98, 137);
            this.tbTexte.Name = "tbTexte";
            this.tbTexte.Size = new System.Drawing.Size(100, 20);
            this.tbTexte.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(98, 228);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(267, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 142);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // cbidColoc
            // 
            this.cbidColoc.FormattingEnabled = true;
            this.cbidColoc.Location = new System.Drawing.Point(77, 36);
            this.cbidColoc.Name = "cbidColoc";
            this.cbidColoc.Size = new System.Drawing.Size(121, 21);
            this.cbidColoc.TabIndex = 12;
            this.cbidColoc.SelectedIndexChanged += new System.EventHandler(this.cbidColoc_SelectedIndexChanged);
            // 
            // FNouvelleDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 379);
            this.Controls.Add(this.cbidColoc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tbTexte);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.btnReparti);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblJustificatif);
            this.Controls.Add(this.lblTexte);
            this.Controls.Add(this.lblLaDate);
            this.Controls.Add(this.btnValider);
            this.Name = "FNouvelleDepense";
            this.Text = "FNouvelleDepense";
            this.Load += new System.EventHandler(this.FNouvelleDepense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblLaDate;
        private System.Windows.Forms.Label lblTexte;
        private System.Windows.Forms.Label lblJustificatif;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label btnReparti;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbTexte;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbidColoc;
    }
}
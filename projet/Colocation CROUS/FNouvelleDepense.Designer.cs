
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
            this.tbMontant = new System.Windows.Forms.TextBox();
            this.tbTexte = new System.Windows.Forms.TextBox();
            this.pbJustificatif = new System.Windows.Forms.PictureBox();
            this.cbidColoc = new System.Windows.Forms.ComboBox();
            this.btnChoisir = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbJustificatif)).BeginInit();
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
            this.lblTexte.Location = new System.Drawing.Point(25, 152);
            this.lblTexte.Name = "lblTexte";
            this.lblTexte.Size = new System.Drawing.Size(40, 13);
            this.lblTexte.TabIndex = 2;
            this.lblTexte.Text = "Texte :";
            // 
            // lblJustificatif
            // 
            this.lblJustificatif.AutoSize = true;
            this.lblJustificatif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJustificatif.Location = new System.Drawing.Point(314, 66);
            this.lblJustificatif.Name = "lblJustificatif";
            this.lblJustificatif.Size = new System.Drawing.Size(105, 24);
            this.lblJustificatif.TabIndex = 3;
            this.lblJustificatif.Text = "Justificatif ";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(25, 199);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(52, 13);
            this.lblMontant.TabIndex = 4;
            this.lblMontant.Text = "Montant :";
            // 
            // tbMontant
            // 
            this.tbMontant.Location = new System.Drawing.Point(98, 199);
            this.tbMontant.Name = "tbMontant";
            this.tbMontant.Size = new System.Drawing.Size(100, 20);
            this.tbMontant.TabIndex = 8;
            // 
            // tbTexte
            // 
            this.tbTexte.Location = new System.Drawing.Point(98, 149);
            this.tbTexte.Name = "tbTexte";
            this.tbTexte.Size = new System.Drawing.Size(100, 20);
            this.tbTexte.TabIndex = 9;
            // 
            // pbJustificatif
            // 
            this.pbJustificatif.Location = new System.Drawing.Point(292, 101);
            this.pbJustificatif.Name = "pbJustificatif";
            this.pbJustificatif.Size = new System.Drawing.Size(166, 142);
            this.pbJustificatif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbJustificatif.TabIndex = 11;
            this.pbJustificatif.TabStop = false;
            // 
            // cbidColoc
            // 
            this.cbidColoc.FormattingEnabled = true;
            this.cbidColoc.Location = new System.Drawing.Point(67, 49);
            this.cbidColoc.Name = "cbidColoc";
            this.cbidColoc.Size = new System.Drawing.Size(121, 21);
            this.cbidColoc.TabIndex = 12;
            this.cbidColoc.SelectedIndexChanged += new System.EventHandler(this.cbidColoc_SelectedIndexChanged);
            // 
            // btnChoisir
            // 
            this.btnChoisir.Location = new System.Drawing.Point(344, 266);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(75, 23);
            this.btnChoisir.TabIndex = 14;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(67, 101);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 15;
            // 
            // FNouvelleDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 379);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.cbidColoc);
            this.Controls.Add(this.pbJustificatif);
            this.Controls.Add(this.tbTexte);
            this.Controls.Add(this.tbMontant);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblJustificatif);
            this.Controls.Add(this.lblTexte);
            this.Controls.Add(this.lblLaDate);
            this.Controls.Add(this.btnValider);
            this.Name = "FNouvelleDepense";
            this.Text = "FNouvelleDepense";
            this.Load += new System.EventHandler(this.FNouvelleDepense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbJustificatif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblLaDate;
        private System.Windows.Forms.Label lblTexte;
        private System.Windows.Forms.Label lblJustificatif;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.TextBox tbMontant;
        private System.Windows.Forms.TextBox tbTexte;
        private System.Windows.Forms.PictureBox pbJustificatif;
        private System.Windows.Forms.ComboBox cbidColoc;
        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}
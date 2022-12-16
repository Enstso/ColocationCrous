
namespace Colocation_CROUS
{
    partial class FMain
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
            this.btnGererColoc = new System.Windows.Forms.Button();
            this.btnSolderPeriode = new System.Windows.Forms.Button();
            this.btnGererDepense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGererColoc
            // 
            this.btnGererColoc.Location = new System.Drawing.Point(335, 91);
            this.btnGererColoc.Name = "btnGererColoc";
            this.btnGererColoc.Size = new System.Drawing.Size(147, 60);
            this.btnGererColoc.TabIndex = 0;
            this.btnGererColoc.Text = "Gerer Colocataires";
            this.btnGererColoc.UseVisualStyleBackColor = true;
            // 
            // btnSolderPeriode
            // 
            this.btnSolderPeriode.Location = new System.Drawing.Point(449, 216);
            this.btnSolderPeriode.Name = "btnSolderPeriode";
            this.btnSolderPeriode.Size = new System.Drawing.Size(149, 58);
            this.btnSolderPeriode.TabIndex = 1;
            this.btnSolderPeriode.Text = "Solder Periode";
            this.btnSolderPeriode.UseVisualStyleBackColor = true;
            // 
            // btnGererDepense
            // 
            this.btnGererDepense.Location = new System.Drawing.Point(576, 91);
            this.btnGererDepense.Name = "btnGererDepense";
            this.btnGererDepense.Size = new System.Drawing.Size(147, 60);
            this.btnGererDepense.TabIndex = 2;
            this.btnGererDepense.Text = "Gerer Depenses";
            this.btnGererDepense.UseVisualStyleBackColor = true;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGererDepense);
            this.Controls.Add(this.btnSolderPeriode);
            this.Controls.Add(this.btnGererColoc);
            this.Name = "FMain";
            this.Text = "FMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGererColoc;
        private System.Windows.Forms.Button btnSolderPeriode;
        private System.Windows.Forms.Button btnGererDepense;
    }
}
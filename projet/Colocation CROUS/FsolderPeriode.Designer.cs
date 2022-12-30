namespace Colocation_CROUS
{
    partial class FsolderPeriode
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
            this.lblSolderPeriode = new System.Windows.Forms.Label();
            this.btnLancerRepartition = new System.Windows.Forms.Button();
            this.lblRepartirDepense = new System.Windows.Forms.Label();
            this.pnlSolderPeriode = new System.Windows.Forms.Panel();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pnlSolderPeriode.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSolderPeriode
            // 
            this.lblSolderPeriode.AutoSize = true;
            this.lblSolderPeriode.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSolderPeriode.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolderPeriode.Location = new System.Drawing.Point(274, 6);
            this.lblSolderPeriode.Name = "lblSolderPeriode";
            this.lblSolderPeriode.Size = new System.Drawing.Size(238, 29);
            this.lblSolderPeriode.TabIndex = 0;
            this.lblSolderPeriode.Text = "SOLDER UNE  PÉRIODE";
            // 
            // btnLancerRepartition
            // 
            this.btnLancerRepartition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLancerRepartition.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancerRepartition.Location = new System.Drawing.Point(279, 109);
            this.btnLancerRepartition.Margin = new System.Windows.Forms.Padding(2);
            this.btnLancerRepartition.Name = "btnLancerRepartition";
            this.btnLancerRepartition.Size = new System.Drawing.Size(233, 91);
            this.btnLancerRepartition.TabIndex = 3;
            this.btnLancerRepartition.Text = "Lancer la Répartition";
            this.btnLancerRepartition.UseVisualStyleBackColor = true;
            // 
            // lblRepartirDepense
            // 
            this.lblRepartirDepense.AutoSize = true;
            this.lblRepartirDepense.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepartirDepense.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblRepartirDepense.Location = new System.Drawing.Point(288, 228);
            this.lblRepartirDepense.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRepartirDepense.Name = "lblRepartirDepense";
            this.lblRepartirDepense.Size = new System.Drawing.Size(0, 18);
            this.lblRepartirDepense.TabIndex = 4;
            // 
            // pnlSolderPeriode
            // 
            this.pnlSolderPeriode.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlSolderPeriode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSolderPeriode.Controls.Add(this.lblSolderPeriode);
            this.pnlSolderPeriode.Location = new System.Drawing.Point(0, 1);
            this.pnlSolderPeriode.Name = "pnlSolderPeriode";
            this.pnlSolderPeriode.Size = new System.Drawing.Size(800, 68);
            this.pnlSolderPeriode.TabIndex = 5;
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.White;
            this.pnlBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBackground.Controls.Add(this.btnLancerRepartition);
            this.pnlBackground.Controls.Add(this.lblRepartirDepense);
            this.pnlBackground.Location = new System.Drawing.Point(0, 53);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(800, 398);
            this.pnlBackground.TabIndex = 6;
            // 
            // FsolderPeriode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.pnlSolderPeriode);
            this.Name = "FsolderPeriode";
            this.Text = "FsolderPeriode";
            this.pnlSolderPeriode.ResumeLayout(false);
            this.pnlSolderPeriode.PerformLayout();
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSolderPeriode;
        private System.Windows.Forms.Button btnLancerRepartition;
        private System.Windows.Forms.Label lblRepartirDepense;
        private System.Windows.Forms.Panel pnlSolderPeriode;
        private System.Windows.Forms.Panel pnlBackground;
    }
}
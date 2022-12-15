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
            this.SuspendLayout();
            // 
            // lblSolderPeriode
            // 
            this.lblSolderPeriode.AutoSize = true;
            this.lblSolderPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolderPeriode.Location = new System.Drawing.Point(208, 11);
            this.lblSolderPeriode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSolderPeriode.Name = "lblSolderPeriode";
            this.lblSolderPeriode.Size = new System.Drawing.Size(576, 91);
            this.lblSolderPeriode.TabIndex = 0;
            this.lblSolderPeriode.Text = "Solder Periode";
            // 
            // btnLancerRepartition
            // 
            this.btnLancerRepartition.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancerRepartition.Location = new System.Drawing.Point(386, 143);
            this.btnLancerRepartition.Name = "btnLancerRepartition";
            this.btnLancerRepartition.Size = new System.Drawing.Size(284, 112);
            this.btnLancerRepartition.TabIndex = 3;
            this.btnLancerRepartition.Text = "Lancer la Répartition";
            this.btnLancerRepartition.UseVisualStyleBackColor = true;
            // 
            // lblRepartirDepense
            // 
            this.lblRepartirDepense.AutoSize = true;
            this.lblRepartirDepense.Location = new System.Drawing.Point(383, 341);
            this.lblRepartirDepense.Name = "lblRepartirDepense";
            this.lblRepartirDepense.Size = new System.Drawing.Size(0, 21);
            this.lblRepartirDepense.TabIndex = 4;
            // 
            // FsolderPeriode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblRepartirDepense);
            this.Controls.Add(this.btnLancerRepartition);
            this.Controls.Add(this.lblSolderPeriode);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FsolderPeriode";
            this.Text = "FsolderPeriode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSolderPeriode;
        private System.Windows.Forms.Button btnLancerRepartition;
        private System.Windows.Forms.Label lblRepartirDepense;
    }
}

namespace Colocation_CROUS
{
    partial class SolderPeriode
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
            this.cbxReparti = new System.Windows.Forms.CheckBox();
            this.lblSolderPeriode = new System.Windows.Forms.Label();
            this.btnRepartirDepense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxReparti
            // 
            this.cbxReparti.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxReparti.Location = new System.Drawing.Point(343, 271);
            this.cbxReparti.Name = "cbxReparti";
            this.cbxReparti.Size = new System.Drawing.Size(69, 39);
            this.cbxReparti.TabIndex = 0;
            this.cbxReparti.Text = "Reparti";
            this.cbxReparti.UseVisualStyleBackColor = true;
            // 
            // lblSolderPeriode
            // 
            this.lblSolderPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolderPeriode.Location = new System.Drawing.Point(175, 9);
            this.lblSolderPeriode.Name = "lblSolderPeriode";
            this.lblSolderPeriode.Size = new System.Drawing.Size(457, 77);
            this.lblSolderPeriode.TabIndex = 1;
            this.lblSolderPeriode.Text = "Solder periode";
            // 
            // btnRepartirDepense
            // 
            this.btnRepartirDepense.Location = new System.Drawing.Point(314, 165);
            this.btnRepartirDepense.Name = "btnRepartirDepense";
            this.btnRepartirDepense.Size = new System.Drawing.Size(130, 61);
            this.btnRepartirDepense.TabIndex = 2;
            this.btnRepartirDepense.Text = "Lancer la répartition";
            this.btnRepartirDepense.UseVisualStyleBackColor = true;
            // 
            // SolderPeriode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRepartirDepense);
            this.Controls.Add(this.lblSolderPeriode);
            this.Controls.Add(this.cbxReparti);
            this.Name = "SolderPeriode";
            this.Text = "SolderPeriode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxReparti;
        private System.Windows.Forms.Label lblSolderPeriode;
        private System.Windows.Forms.Button btnRepartirDepense;
    }
}
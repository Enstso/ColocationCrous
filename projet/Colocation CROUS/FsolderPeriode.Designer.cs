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
            this.button1 = new System.Windows.Forms.Button();
            this.cbxReparti = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblSolderPeriode
            // 
            this.lblSolderPeriode.AutoSize = true;
            this.lblSolderPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolderPeriode.Location = new System.Drawing.Point(156, 9);
            this.lblSolderPeriode.Name = "lblSolderPeriode";
            this.lblSolderPeriode.Size = new System.Drawing.Size(471, 73);
            this.lblSolderPeriode.TabIndex = 0;
            this.lblSolderPeriode.Text = "Solder Periode";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(287, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 89);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lancer la répartition";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxReparti
            // 
            this.cbxReparti.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxReparti.Location = new System.Drawing.Point(350, 265);
            this.cbxReparti.Name = "cbxReparti";
            this.cbxReparti.Size = new System.Drawing.Size(67, 36);
            this.cbxReparti.TabIndex = 2;
            this.cbxReparti.Text = "Reparti";
            this.cbxReparti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxReparti.UseVisualStyleBackColor = true;
            // 
            // FsolderPeriode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxReparti);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSolderPeriode);
            this.Name = "FsolderPeriode";
            this.Text = "FsolderPeriode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSolderPeriode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbxReparti;
    }
}
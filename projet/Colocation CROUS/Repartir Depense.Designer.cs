
namespace Colocation_CROUS
{
    partial class RepartirDepense
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
            this.lbDepense = new System.Windows.Forms.ListBox();
            this.lbrepartirdepense = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.btnRepartir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDepense
            // 
            this.lbDepense.FormattingEnabled = true;
            this.lbDepense.Location = new System.Drawing.Point(183, 105);
            this.lbDepense.Name = "lbDepense";
            this.lbDepense.Size = new System.Drawing.Size(501, 160);
            this.lbDepense.TabIndex = 0;
            // 
            // lbrepartirdepense
            // 
            this.lbrepartirdepense.AutoSize = true;
            this.lbrepartirdepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrepartirdepense.Location = new System.Drawing.Point(170, 9);
            this.lbrepartirdepense.Name = "lbrepartirdepense";
            this.lbrepartirdepense.Size = new System.Drawing.Size(535, 73);
            this.lbrepartirdepense.TabIndex = 1;
            this.lbrepartirdepense.Text = "Repartir Depense";
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(412, 347);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(0, 39);
            this.lblResultat.TabIndex = 2;
            // 
            // btnRepartir
            // 
            this.btnRepartir.Location = new System.Drawing.Point(368, 287);
            this.btnRepartir.Name = "btnRepartir";
            this.btnRepartir.Size = new System.Drawing.Size(101, 30);
            this.btnRepartir.TabIndex = 3;
            this.btnRepartir.Text = "Repartir";
            this.btnRepartir.UseVisualStyleBackColor = true;
            // 
            // RepartirDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 407);
            this.Controls.Add(this.btnRepartir);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.lbrepartirdepense);
            this.Controls.Add(this.lbDepense);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RepartirDepense";
            this.Text = "RepartirDepense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDepense;
        private System.Windows.Forms.Label lbrepartirdepense;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Button btnRepartir;
    }
}

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
            this.btnRepartir = new System.Windows.Forms.Button();
            this.lbDoitCombien = new System.Windows.Forms.ListBox();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pnlRepartirDepenses = new System.Windows.Forms.Panel();
            this.pnlBackground.SuspendLayout();
            this.pnlRepartirDepenses.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDepense
            // 
            this.lbDepense.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepense.FormattingEnabled = true;
            this.lbDepense.HorizontalScrollbar = true;
            this.lbDepense.ItemHeight = 14;
            this.lbDepense.Location = new System.Drawing.Point(0, 3);
            this.lbDepense.Name = "lbDepense";
            this.lbDepense.ScrollAlwaysVisible = true;
            this.lbDepense.Size = new System.Drawing.Size(446, 284);
            this.lbDepense.TabIndex = 0;
            // 
            // lbrepartirdepense
            // 
            this.lbrepartirdepense.AutoSize = true;
            this.lbrepartirdepense.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrepartirdepense.Location = new System.Drawing.Point(299, 11);
            this.lbrepartirdepense.Name = "lbrepartirdepense";
            this.lbrepartirdepense.Size = new System.Drawing.Size(256, 29);
            this.lbrepartirdepense.TabIndex = 1;
            this.lbrepartirdepense.Text = "RÉPARTIR LES DEPENSES";
            // 
            // btnRepartir
            // 
            this.btnRepartir.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRepartir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepartir.Location = new System.Drawing.Point(378, 315);
            this.btnRepartir.Name = "btnRepartir";
            this.btnRepartir.Size = new System.Drawing.Size(121, 36);
            this.btnRepartir.TabIndex = 3;
            this.btnRepartir.Text = "RÉPARTIR";
            this.btnRepartir.UseVisualStyleBackColor = false;
            this.btnRepartir.Click += new System.EventHandler(this.btnRepartir_Click);
            // 
            // lbDoitCombien
            // 
            this.lbDoitCombien.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoitCombien.FormattingEnabled = true;
            this.lbDoitCombien.HorizontalScrollbar = true;
            this.lbDoitCombien.ItemHeight = 14;
            this.lbDoitCombien.Location = new System.Drawing.Point(446, 3);
            this.lbDoitCombien.Margin = new System.Windows.Forms.Padding(2);
            this.lbDoitCombien.Name = "lbDoitCombien";
            this.lbDoitCombien.ScrollAlwaysVisible = true;
            this.lbDoitCombien.Size = new System.Drawing.Size(450, 284);
            this.lbDoitCombien.TabIndex = 4;
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.White;
            this.pnlBackground.Controls.Add(this.lbDepense);
            this.pnlBackground.Controls.Add(this.btnRepartir);
            this.pnlBackground.Controls.Add(this.lbDoitCombien);
            this.pnlBackground.Location = new System.Drawing.Point(-1, 55);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(896, 392);
            this.pnlBackground.TabIndex = 5;
            // 
            // pnlRepartirDepenses
            // 
            this.pnlRepartirDepenses.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlRepartirDepenses.Controls.Add(this.lbrepartirdepense);
            this.pnlRepartirDepenses.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRepartirDepenses.Location = new System.Drawing.Point(0, 0);
            this.pnlRepartirDepenses.Name = "pnlRepartirDepenses";
            this.pnlRepartirDepenses.Size = new System.Drawing.Size(894, 53);
            this.pnlRepartirDepenses.TabIndex = 6;
            // 
            // RepartirDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 447);
            this.Controls.Add(this.pnlRepartirDepenses);
            this.Controls.Add(this.pnlBackground);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RepartirDepense";
            this.Text = "RepartirDepense";
            this.pnlBackground.ResumeLayout(false);
            this.pnlRepartirDepenses.ResumeLayout(false);
            this.pnlRepartirDepenses.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDepense;
        private System.Windows.Forms.Label lbrepartirdepense;
        private System.Windows.Forms.Button btnRepartir;
        private System.Windows.Forms.ListBox lbDoitCombien;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel pnlRepartirDepenses;
    }
}
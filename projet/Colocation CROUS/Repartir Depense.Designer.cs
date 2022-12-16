
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
            this.SuspendLayout();
            // 
            // lbDepense
            // 
            this.lbDepense.FormattingEnabled = true;
            this.lbDepense.HorizontalScrollbar = true;
            this.lbDepense.ItemHeight = 16;
            this.lbDepense.Location = new System.Drawing.Point(92, 136);
            this.lbDepense.Margin = new System.Windows.Forms.Padding(4);
            this.lbDepense.Name = "lbDepense";
            this.lbDepense.ScrollAlwaysVisible = true;
            this.lbDepense.Size = new System.Drawing.Size(475, 196);
            this.lbDepense.TabIndex = 0;
            // 
            // lbrepartirdepense
            // 
            this.lbrepartirdepense.AutoSize = true;
            this.lbrepartirdepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrepartirdepense.Location = new System.Drawing.Point(227, 11);
            this.lbrepartirdepense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbrepartirdepense.Name = "lbrepartirdepense";
            this.lbrepartirdepense.Size = new System.Drawing.Size(661, 91);
            this.lbrepartirdepense.TabIndex = 1;
            this.lbrepartirdepense.Text = "Repartir Depense";
            // 
            // btnRepartir
            // 
            this.btnRepartir.Location = new System.Drawing.Point(524, 373);
            this.btnRepartir.Margin = new System.Windows.Forms.Padding(4);
            this.btnRepartir.Name = "btnRepartir";
            this.btnRepartir.Size = new System.Drawing.Size(135, 37);
            this.btnRepartir.TabIndex = 3;
            this.btnRepartir.Text = "Repartir";
            this.btnRepartir.UseVisualStyleBackColor = true;
            this.btnRepartir.Click += new System.EventHandler(this.btnRepartir_Click);
            // 
            // lbDoitCombien
            // 
            this.lbDoitCombien.FormattingEnabled = true;
            this.lbDoitCombien.HorizontalScrollbar = true;
            this.lbDoitCombien.ItemHeight = 16;
            this.lbDoitCombien.Location = new System.Drawing.Point(628, 136);
            this.lbDoitCombien.Name = "lbDoitCombien";
            this.lbDoitCombien.ScrollAlwaysVisible = true;
            this.lbDoitCombien.Size = new System.Drawing.Size(475, 196);
            this.lbDoitCombien.TabIndex = 4;
            // 
            // RepartirDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 501);
            this.Controls.Add(this.lbDoitCombien);
            this.Controls.Add(this.btnRepartir);
            this.Controls.Add(this.lbrepartirdepense);
            this.Controls.Add(this.lbDepense);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RepartirDepense";
            this.Text = "RepartirDepense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDepense;
        private System.Windows.Forms.Label lbrepartirdepense;
        private System.Windows.Forms.Button btnRepartir;
        private System.Windows.Forms.ListBox lbDoitCombien;
    }
}
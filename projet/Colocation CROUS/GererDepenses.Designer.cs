
namespace Colocation_CROUS
{
    partial class GererDepenses
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
            this.btnSaisirDepense = new System.Windows.Forms.Button();
            this.btnModifierDepense = new System.Windows.Forms.Button();
            this.btnSupprimerDepense = new System.Windows.Forms.Button();
            this.lblGererDepenses = new System.Windows.Forms.Label();
            this.lbGererDepenses = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaisirDepense
            // 
            this.btnSaisirDepense.Location = new System.Drawing.Point(80, 269);
            this.btnSaisirDepense.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaisirDepense.Name = "btnSaisirDepense";
            this.btnSaisirDepense.Size = new System.Drawing.Size(89, 30);
            this.btnSaisirDepense.TabIndex = 1;
            this.btnSaisirDepense.Text = "Saisir Depense";
            this.btnSaisirDepense.UseVisualStyleBackColor = true;
            // 
            // btnModifierDepense
            // 
            this.btnModifierDepense.Location = new System.Drawing.Point(189, 269);
            this.btnModifierDepense.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifierDepense.Name = "btnModifierDepense";
            this.btnModifierDepense.Size = new System.Drawing.Size(104, 30);
            this.btnModifierDepense.TabIndex = 3;
            this.btnModifierDepense.Text = "Modifier depense";
            this.btnModifierDepense.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerDepense
            // 
            this.btnSupprimerDepense.Location = new System.Drawing.Point(312, 269);
            this.btnSupprimerDepense.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimerDepense.Name = "btnSupprimerDepense";
            this.btnSupprimerDepense.Size = new System.Drawing.Size(106, 30);
            this.btnSupprimerDepense.TabIndex = 4;
            this.btnSupprimerDepense.Text = "Supprimer depense";
            this.btnSupprimerDepense.UseVisualStyleBackColor = true;
            // 
            // lblGererDepenses
            // 
            this.lblGererDepenses.AutoSize = true;
            this.lblGererDepenses.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGererDepenses.Location = new System.Drawing.Point(80, 6);
            this.lblGererDepenses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGererDepenses.Name = "lblGererDepenses";
            this.lblGererDepenses.Size = new System.Drawing.Size(436, 73);
            this.lblGererDepenses.TabIndex = 5;
            this.lblGererDepenses.Text = "Gerer Depenses";
            // 
            // lbGererDepenses
            // 
            this.lbGererDepenses.FormattingEnabled = true;
            this.lbGererDepenses.Location = new System.Drawing.Point(80, 130);
            this.lbGererDepenses.Margin = new System.Windows.Forms.Padding(2);
            this.lbGererDepenses.Name = "lbGererDepenses";
            this.lbGererDepenses.Size = new System.Drawing.Size(435, 134);
            this.lbGererDepenses.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(440, 269);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // GererDepenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbGererDepenses);
            this.Controls.Add(this.lblGererDepenses);
            this.Controls.Add(this.btnSupprimerDepense);
            this.Controls.Add(this.btnModifierDepense);
            this.Controls.Add(this.btnSaisirDepense);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GererDepenses";
            this.Text = "GererDepenses";
            this.Load += new System.EventHandler(this.GererDepenses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaisirDepense;
        private System.Windows.Forms.Button btnModifierDepense;
        private System.Windows.Forms.Button btnSupprimerDepense;
        private System.Windows.Forms.Label lblGererDepenses;
        private System.Windows.Forms.ListBox lbGererDepenses;
        private System.Windows.Forms.Button btnSave;
    }
}
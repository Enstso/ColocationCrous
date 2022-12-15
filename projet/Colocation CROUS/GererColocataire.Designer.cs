
namespace Colocation_CROUS
{
    partial class GererColocataire
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
            this.lbColocataire = new System.Windows.Forms.ListBox();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.lblColocataire = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbColocataire
            // 
            this.lbColocataire.FormattingEnabled = true;
            this.lbColocataire.HorizontalScrollbar = true;
            this.lbColocataire.ItemHeight = 16;
            this.lbColocataire.Location = new System.Drawing.Point(125, 103);
            this.lbColocataire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbColocataire.Name = "lbColocataire";
            this.lbColocataire.ScrollAlwaysVisible = true;
            this.lbColocataire.Size = new System.Drawing.Size(551, 228);
            this.lbColocataire.TabIndex = 0;
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(125, 361);
            this.btnajouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(112, 37);
            this.btnajouter.TabIndex = 1;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Location = new System.Drawing.Point(428, 359);
            this.btnsupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(112, 37);
            this.btnsupprimer.TabIndex = 2;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(275, 359);
            this.btnmodifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(112, 37);
            this.btnmodifier.TabIndex = 3;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            // 
            // lblColocataire
            // 
            this.lblColocataire.AutoSize = true;
            this.lblColocataire.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColocataire.Location = new System.Drawing.Point(115, 9);
            this.lblColocataire.Name = "lblColocataire";
            this.lblColocataire.Size = new System.Drawing.Size(564, 68);
            this.lblColocataire.TabIndex = 4;
            this.lblColocataire.Text = "Gerer les Colocataires";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(576, 361);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(101, 36);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // GererColocataire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 462);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lblColocataire);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.lbColocataire);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GererColocataire";
            this.Text = "Gerer Colocataire";
            this.Load += new System.EventHandler(this.GererColocataire_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbColocataire;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Label lblColocataire;
        private System.Windows.Forms.Button btnsave;
    }
}
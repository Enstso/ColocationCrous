
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
            this.lbColocataire.Location = new System.Drawing.Point(94, 84);
            this.lbColocataire.Margin = new System.Windows.Forms.Padding(2);
            this.lbColocataire.Name = "lbColocataire";
            this.lbColocataire.Size = new System.Drawing.Size(414, 186);
            this.lbColocataire.TabIndex = 0;
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(94, 293);
            this.btnajouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(84, 30);
            this.btnajouter.TabIndex = 1;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Location = new System.Drawing.Point(321, 292);
            this.btnsupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(84, 30);
            this.btnsupprimer.TabIndex = 2;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(206, 292);
            this.btnmodifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(84, 30);
            this.btnmodifier.TabIndex = 3;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            // 
            // lblColocataire
            // 
            this.lblColocataire.AutoSize = true;
            this.lblColocataire.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColocataire.Location = new System.Drawing.Point(86, 7);
            this.lblColocataire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColocataire.Name = "lblColocataire";
            this.lblColocataire.Size = new System.Drawing.Size(443, 55);
            this.lblColocataire.TabIndex = 4;
            this.lblColocataire.Text = "Gerer les Colocataires";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(432, 293);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(76, 29);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // GererColocataire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 375);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lblColocataire);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.lbColocataire);
            this.Margin = new System.Windows.Forms.Padding(2);
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
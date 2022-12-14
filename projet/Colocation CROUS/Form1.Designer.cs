
namespace Colocation_CROUS
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGererColoc = new System.Windows.Forms.Button();
            this.btnRepartirDepenses = new System.Windows.Forms.Button();
            this.btnSolderPeriode = new System.Windows.Forms.Button();
            this.btnGererDepenses = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGererColoc
            // 
            this.btnGererColoc.Location = new System.Drawing.Point(298, 122);
            this.btnGererColoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGererColoc.Name = "btnGererColoc";
            this.btnGererColoc.Size = new System.Drawing.Size(102, 29);
            this.btnGererColoc.TabIndex = 1;
            this.btnGererColoc.Text = "Gerer Colocataire";
            this.btnGererColoc.UseVisualStyleBackColor = true;
            this.btnGererColoc.Click += new System.EventHandler(this.btnGererColoc_Click);
            // 
            // btnRepartirDepenses
            // 
            this.btnRepartirDepenses.Location = new System.Drawing.Point(298, 236);
            this.btnRepartirDepenses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRepartirDepenses.Name = "btnRepartirDepenses";
            this.btnRepartirDepenses.Size = new System.Drawing.Size(102, 29);
            this.btnRepartirDepenses.TabIndex = 2;
            this.btnRepartirDepenses.Text = "Repartir depense";
            this.btnRepartirDepenses.UseVisualStyleBackColor = true;
            this.btnRepartirDepenses.Click += new System.EventHandler(this.btnRepartirDepenses_Click);
            // 
            // btnSolderPeriode
            // 
            this.btnSolderPeriode.Location = new System.Drawing.Point(452, 236);
            this.btnSolderPeriode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSolderPeriode.Name = "btnSolderPeriode";
            this.btnSolderPeriode.Size = new System.Drawing.Size(102, 29);
            this.btnSolderPeriode.TabIndex = 4;
            this.btnSolderPeriode.Text = "Solder Période";
            this.btnSolderPeriode.UseVisualStyleBackColor = true;
            // 
            // btnGererDepenses
            // 
            this.btnGererDepenses.Location = new System.Drawing.Point(452, 122);
            this.btnGererDepenses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGererDepenses.Name = "btnGererDepenses";
            this.btnGererDepenses.Size = new System.Drawing.Size(102, 29);
            this.btnGererDepenses.TabIndex = 5;
            this.btnGererDepenses.Text = "Gerer Depenses";
            this.btnGererDepenses.UseVisualStyleBackColor = true;
            this.btnGererDepenses.Click += new System.EventHandler(this.btnGererDepenses_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(25, 79);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(591, 405);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGererDepenses);
            this.Controls.Add(this.btnSolderPeriode);
            this.Controls.Add(this.btnRepartirDepenses);
            this.Controls.Add(this.btnGererColoc);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGererColoc;
        private System.Windows.Forms.Button btnRepartirDepenses;
        private System.Windows.Forms.Button btnSolderPeriode;
        private System.Windows.Forms.Button btnGererDepenses;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}



namespace Colocation_CROUS
{
    partial class FnouveauColocataire
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(34, 31);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "id :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(34, 57);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(33, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(34, 83);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(48, 13);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "prénom :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(34, 109);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(31, 13);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "mail :";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(34, 139);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(60, 13);
            this.lblTelephone.TabIndex = 4;
            this.lblTelephone.Text = "téléphone :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(100, 192);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(100, 31);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(75, 20);
            this.tbId.TabIndex = 6;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(100, 57);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(75, 20);
            this.tbNom.TabIndex = 7;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(100, 83);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(75, 20);
            this.tbPrenom.TabIndex = 8;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(100, 109);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(75, 20);
            this.tbMail.TabIndex = 9;
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(100, 135);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(75, 20);
            this.tbTelephone.TabIndex = 10;
            // 
            // FnouveauColocataire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 267);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblId);
            this.Name = "FnouveauColocataire";
            this.Text = "FnouveauColocataire";
            this.Load += new System.EventHandler(this.FnouveauColocataire_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbTelephone;
    }
}
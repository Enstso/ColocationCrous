using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dao;
using Model;
namespace Colocation_CROUS
{
    public partial class FNouvelleDepense : Form
    {
        State state;
        int id;
        ListBox.ObjectCollection items;
        public FNouvelleDepense(State state, ListBox.ObjectCollection items, int id)
        {
            InitializeComponent();
            this.state = state;
            this.items = items;
            this.id = id;
            this.cbidColoc.SelectedIndexChanged += CbidColoc_SelectedIndexChanged;
            this.btnValider.Click += BtnValider_Click;
            this.btnChoisir.Click += BtnChoisir_Click;
            
            switch (state)
            {
                case State.added:
                    this.Text = "Création d'une dépense";
                    DaoColocataire colocataire = new DaoColocataire();
                    List<Colocataire> colocataires = colocataire.GetAll();
                    foreach (Colocataire coloc in colocataires)
                    {
                        this.cbidColoc.Items.Add(coloc);
                    }

                    break;
                case State.modified:
                    this.Text = "Modification d'une dépense";
                    this.dtpDate.Value = ((Depense)items[id]).Date;
                    this.tbTexte.Text = ((Depense)items[id]).Texte;
                    this.tbMontant.Text = ((Depense)items[id]).Montant.ToString();
                    this.cbidColoc.Enabled = false;
                    // à Modifier 
                    this.pbJustificatif.ImageLocation = ((Depense)items[id]).Justificatif;
                    break;
                case State.deleted:
                    this.Text = "Suppression d'une dépense";
                    break;
                case State.unChanged:
                    this.Text = "Consultation d'une dépense";
                    break;
                default:
                    break;
            }

        }

        private void BtnChoisir_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Choissez un justificatif";
            file.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png*.pdf)|*.BMP;*.JPG;*.JPEG;*.PNG;*.PDF";
            if (file.ShowDialog() == DialogResult.OK) {
                this.pbJustificatif.ImageLocation = file.FileName;
            }
        }

        private void CbidColoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = cbidColoc.SelectedIndex;
            Colocataire coloc = (Colocataire)this.cbidColoc.Items[id];
            this.id = coloc.Id;

        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            switch (this.state)
            {
                case State.added :
                    items.Add(new Depense(dtpDate.Value,tbTexte.Text, pbJustificatif.ImageLocation, Convert.ToDecimal(tbMontant.Text),id,this.state));
                    this.Close();
                    break;
                case State.modified:
                    Depense modifiedDepense = (Depense)items[this.id];
                    modifiedDepense.State = state;
                    modifiedDepense.Date = dtpDate.Value;
                    modifiedDepense.Texte = tbTexte.Text;
                    modifiedDepense.Justificatif = pbJustificatif.ImageLocation;
                    modifiedDepense.Reparti = false;
                    modifiedDepense.Montant = Convert.ToDecimal(tbMontant.Text);
                    this.Close();
                    break;
                case State.deleted:
                    break;
                case State.unChanged:
                    break;
                default:
                    break;
            }
        }

        private void tbDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbidColoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FNouvelleDepense_Load(object sender, EventArgs e)
        {

        }

        
    }
}

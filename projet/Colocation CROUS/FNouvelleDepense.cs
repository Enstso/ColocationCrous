using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dao;
using Model;
namespace Colocation_CROUS
{
    public partial class FnouvelleDepense : Form
    {
        State state;
        int id;
        ListBox.ObjectCollection items;
        public FnouvelleDepense(State state, ListBox.ObjectCollection items, int id)
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
                    this.tbMontant.Text = ((Depense)items[id]).Montant.ToString("0.##");
                    this.cbidColoc.Enabled = false;
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
            file.Title = "Choisissez un justificatif";
            file.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png*.pdf)|*.BMP;*.JPG;*.JPEG;*.PNG;*.PDF";
            if (file.ShowDialog() == DialogResult.OK)
            {
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
                case State.added:
                    List<bool> list = new List<bool>();
                    list.Add(Regexm(@"^[a-zA-Z]+$", this.pbValidation1, tbTexte));
                    list.Add(Regexm(@"^[0-9]+$", this.pbValidation2, tbMontant));
                    int test = Testvalidation(list);
                    if (this.cbidColoc.SelectedItem != null)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Choisissez un colocataire");
                    }
                    if (test == 3)
                    {
                        items.Add(new Depense(dtpDate.Value, tbTexte.Text, pbJustificatif.ImageLocation, Convert.ToDecimal(tbMontant.Text), id, this.state));
                        this.Close();
                    }
                    break;
                case State.modified:
                    List<bool> list2 = new List<bool>();
                    list2.Add(Regexm(@"^[a-zA-Z]+$", this.pbValidation1, tbTexte));
                    list2.Add(Regexm(@"^[0-9]+$", this.pbValidation2, tbMontant));
                    int test2 = Testvalidation(list2);
                    if (test2 == 3)
                    {
                        Depense modifiedDepense = (Depense)items[this.id];
                        modifiedDepense.State = this.state;
                        modifiedDepense.Date = this.dtpDate.Value;
                        modifiedDepense.Texte = this.tbTexte.Text;
                        modifiedDepense.Justificatif = this.pbJustificatif.ImageLocation;
                        modifiedDepense.Montant = Convert.ToDecimal(tbMontant.Text);
                        this.items[this.id] = modifiedDepense;
                        this.Close();
                    }
                    break;
                case State.deleted:
                    break;
                case State.unChanged:
                    break;
                default:
                    break;
            }
        }

        public bool Regexm(string re, PictureBox pb, TextBox tb)
        {
            bool valid = false;
            Regex regex = new Regex(re);
            if (regex.IsMatch(tb.Text))
            {
                pb.Image = Properties.Resources.valid;
                valid = true;
            }
            else
            {
                pb.Image = Properties.Resources.invalid;
            }
            return valid;
        }

        public int Testvalidation(List<bool> list)
        {
            int compteur = 0;
            foreach (bool elmt in list)
            {
                if (elmt == true)
                {
                    compteur = compteur + 1;
                }

            }
            if (this.pbJustificatif.ImageLocation != null)
            {
                compteur = compteur + 1;
            }
            else
            {
                MessageBox.Show("Justificatif Obligatoire");
            }

            return compteur;
        }
    }
}


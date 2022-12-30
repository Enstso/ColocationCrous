using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Text.RegularExpressions;
namespace Colocation_CROUS
{
    public partial class FnouveauColocataire : Form
    {
        State state;
        ListBox.ObjectCollection items;
        int position;
        int compteur;
        public FnouveauColocataire(State state, ListBox.ObjectCollection items, int position)
        {
            InitializeComponent();
            btnValider.Click += this.BtnValider_Click;
            this.state = state;
            this.items = items;
            this.position = position;


            switch (state)
            {
                case State.added:
                    this.Text = "Création d'un locataire";
                    break;

                case State.modified:
                    this.Text = "Modification d'un locataire";
                    Colocataire colocataire = (Colocataire)items[this.position];
                    this.tbNom.Text = colocataire.Nom;
                    this.tbPrenom.Text = colocataire.Prenom;
                    this.tbMail.Text = colocataire.Mail;
                    this.tbTelephone.Text = colocataire.Telephone;
                    break;

                case State.deleted:
                    this.Text = "Suppression d'un locataire";
                    break;

                case State.unChanged:
                    this.Text = "Consultation d'un colocataire";
                    break;

                default:
                    break;
            }

        }

        private void BtnValider_Click(object sender, EventArgs e)
        {

            switch (this.state)
            {

                case State.added:
                    List<bool> list = new List<bool>();
                    list.Add(Regexm(@"([a-zA-Z',.-]+( [a-zA-Z',.-]+)*){2,30}", this.pbValidation1, tbNom));
                    list.Add(Regexm(@"([a-zA-Z',.-]+( [a-zA-Z',.-]+)*){2,30}", this.pbValidation2, tbPrenom));
                    list.Add(Regexm(@"[a-z0-9]+@[a-z]+\.[a-z]{2,3}", this.pbValidation3, tbMail));
                    list.Add(Regexm(@"^(?:(?:\+|00)33[\s.-]{0,3}(?:\(0\)[\s.-]{0,3})?|0)[1-9](?:(?:[\s.-]?\d{2}){4}|\d{2}(?:[\s.-]?\d{3}){2})$", this.pbValidation4, tbTelephone));
                    int test = Testvalidation(list);
                    if (test == 4)
                    {
                        items.Add(new Colocataire(0, tbNom.Text, tbPrenom.Text, tbMail.Text, tbTelephone.Text, this.state));
                        this.Close();
                    }
                    break;
                case State.modified:
                    List<bool> list2 = new List<bool>();
                    list2.Add(Regexm(@"([a-zA-Z',.-]+( [a-zA-Z',.-]+)*){2,30}", this.pbValidation1, tbNom));
                    list2.Add(Regexm(@"([a-zA-Z',.-]+( [a-zA-Z',.-]+)*){2,30}", this.pbValidation2, tbPrenom));
                    list2.Add(Regexm(@"[a-z0-9]+@[a-z]+\.[a-z]{2,3}", this.pbValidation3, tbMail));
                    list2.Add(Regexm(@"^(?:(?:\+|00)33[\s.-]{0,3}(?:\(0\)[\s.-]{0,3})?|0)[1-9](?:(?:[\s.-]?\d{2}){4}|\d{2}(?:[\s.-]?\d{3}){2})$", this.pbValidation4, tbTelephone));
                    int test2 = Testvalidation(list2);
                    if (test2 == 4)
                    {
                        Colocataire colocataire = (Colocataire)items[this.position];
                        colocataire.Nom = this.tbNom.Text;
                        colocataire.Prenom = this.tbPrenom.Text;
                        colocataire.Mail = this.tbMail.Text;
                        colocataire.Telephone = this.tbTelephone.Text;
                        colocataire.State = this.state;
                        items[this.position] = colocataire;
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
                this.compteur = this.compteur + 1;
            }
            else
            {
                pb.Image = Properties.Resources.invalid;
                if (this.compteur < 0)
                {
                    this.compteur = 0;
                }
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
            return compteur;
        }

    }
}

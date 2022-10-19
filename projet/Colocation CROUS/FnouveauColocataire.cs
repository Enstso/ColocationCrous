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
namespace Colocation_CROUS
{
    public partial class FnouveauColocataire : Form
    {
        State state;
        ListBox.ObjectCollection items;
        int position;
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
                    items.Add(new Colocataire(0, tbNom.Text, tbPrenom.Text, tbMail.Text, tbTelephone.Text, this.state));
                    break;
                case State.modified:
                    Colocataire colocataire = (Colocataire)items[this.position];
                    colocataire.Nom = this.tbNom.Text;
                    colocataire.Prenom = this.tbPrenom.Text;
                    colocataire.Mail = this.tbMail.Text;
                    colocataire.Telephone = this.tbTelephone.Text;
                    items[this.position] = colocataire;
                    break;
                case State.deleted:
                    break;
                case State.unChanged:
                    break;
                default:
                    break;
            }
            this.Close();
        }
    }
}

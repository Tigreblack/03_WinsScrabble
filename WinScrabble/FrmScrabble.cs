using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinScrabble
{
    public partial class FrmScrabble : Form
    {
        Joueur Joueur1;
        Joueur Joueur2;
        public FrmScrabble()
        {
            InitializeComponent();
            tabControl.SelectedTab = Joueurs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Assignation des joueurs
            Joueur1 = new Joueur(txtJ1.Text);
            Joueur2 = new Joueur (txtJ2.Text);

            gpJ1.Text = gpJ1.Text + Joueur1.GetunNom();
            gpJ2.Text = gpJ2.Text + Joueur2.GetunNom();

            // Supprime la tabPages

            tabControl.TabPages.Remove(Joueurs);

            // Focus sur la tab Jeu
            tabControl.SelectedTab = Jeu;
        }




        // ignorer
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void J1label_Click(object sender, EventArgs e)
        {

        }

        private void txtJ1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtJ2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

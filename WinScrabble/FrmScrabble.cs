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

            // choisis la tab Joueurs au débuts
            tabControl.SelectedTab = Joueurs;
        }

        /// <summary>
        /// Méthode qui choisis un joueur aléotoire parmis les 2 joueurs
        /// </summary>
        /// <param name="J1">Joueur 1</param>
        /// <param name="J2">Joueur 2</param>
        /// <returns>Le joueur choisis parmis les 2 joueurs </returns>
        public Joueur RandomJoueur(Joueur J1, Joueur J2)
        {
            int selected = 0;
            var rand = new Random();
            selected = rand.Next(1, 3);
            if (selected == 1)
                return J1;
            else
                return J2;
        }

        /// <summary>
        /// Méthode qui choisis 7 lettres au hasard dans l'alphabets et les renvoie dans  un tableau.
        /// </summary>
        /// <returns>le tableau en question de 7 lettres</returns>
        public string[] RandomLettres()
        {      
            string []  selectedletter = new string[7];
            string[] alphabets = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "n", "l", "m", "o", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
            
            int Lenght = 7;
            var rand = new Random();

            for (int i = 0; i < Lenght; i++)
            {
                // initialisation
                string letter = "";

                // attributs la lettre
                int index = rand.Next(alphabets.Length);
                letter = alphabets[index];

                // ajoute la lettre dans le tableau
                selectedletter[i] = letter + " ,";
            }

            // supprime les espaces et virgules pour la dernières valeurs du tableau
            selectedletter[selectedletter.Length - 1] = selectedletter[selectedletter.Length - 1].Trim(',',' ');

            return selectedletter;
        }

        /// <summary>
        /// Bouton Valider de Sélection des joueurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            // Choisis un joueur random
            var JoueurRandom = RandomJoueur(Joueur1, Joueur2);
            Joueurtxt.Text = JoueurRandom.GetunNom();

            // Choisis les lettres

            string[] lettreschoisis = RandomLettres();

            foreach ( var value in  lettreschoisis )
            {
                txtlettres.Text = txtlettres.Text + value;
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

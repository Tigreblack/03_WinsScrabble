using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        #region attributs privées

        // Tab pages
        private TabPage tabGame;
        private TabPage tabGagnant;
        private TabPage tabJoueurs;

        // NB round
        private int round = 1;

        // les lettres
        private string lettres = "";

        // J1
        private int totalpointJ1 = 0;

        private string mmotsJ1 = "";
        private int nbsmotsJ1 = 0;
        private bool condJ1 = false;

        // J2
        private int totalpointJ2 = 0;
        private string mmotsJ2 = "";
        private int nbsmotsJ2 = 0;
        private bool condJ2 = false;

        #endregion
        public FrmScrabble()
        {
            InitializeComponent();

            // assignation de variables local aux tabpages existantes
            var tabGame1 = tabControl.TabPages[0];
            var tabGagnant1 = tabControl.TabPages[2];
            var tabJoueurs1 = tabControl.TabPages[1];

            // stock les pages pour les réutiliser plus tard à laide de variable global
            tabGame = tabGame1;
            tabGagnant = tabGagnant1;
            tabJoueurs = tabJoueurs1;
            
            // supprime les autres tab pages ( seul moyen existant pour pas les afficher )
            tabControl.TabPages.Remove(Jeu);
            tabControl.TabPages.Remove(Gagnant);

            // choisis la tab Joueurs au débuts
            tabControl.SelectedTab = Joueurs;
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


            // si la partie a recommencer
            gpJ1.Text = "Joueur :";
            gpJ2.Text = "Joueur :";

            // assignation des noms

            gpJ1.Text = gpJ1.Text + Joueur1.GetunNom();
            gpJ2.Text = gpJ2.Text + Joueur2.GetunNom();

            // Supprime la tabPages

            txtJ1.Text = "";
            txtJ2.Text = "";

            tabControl.TabPages.Remove(Joueurs);

            // Focus sur la tab Jeu
            tabControl.TabPages.Add(tabGame);
            tabControl.SelectedTab = Jeu;

            // Choisis un joueur random
            var JoueurRandom = Utilitaire.RandomJoueur(Joueur1, Joueur2);


            // Désactive la groupbox du joueurs qui ne joue pas au 1er round
            if (JoueurRandom == Joueur1)
            {
                condJ1 = true;
                // assignation
                txttotalpointsJ1.Text = totalpointJ1.ToString();
                txtmmotsJ1.Text = mmotsJ1.ToString();
                nbmotsJ1.Text = nbsmotsJ1.ToString();

                txtmotsJ1.Focus();

                // Si la partie a recommencer
                txttotalpointsJ1.Text = "";
                txtmmotsJ1.Text = "";
                nbmotsJ1.Text = "";

                // disable
                txttotalpointsJ1.Enabled = false;
                txtmmotsJ1.Enabled = false;
                nbmotsJ1.Enabled = false;

                // disable groupebox 2
                gpJ2.Enabled = false;
            }
            else 
            {
                condJ2 = true;
                // assignation
                txttotalpointsJ2.Text = totalpointJ2.ToString();
                txtmmotsJ2.Text = mmotsJ2.ToString();
                nbmotsJ2.Text = nbsmotsJ2.ToString();

                txtmotsJ2.Focus();

                // Si la partie a recommencer
                txttotalpointsJ2.Text = "";
                txtmmotsJ2.Text = "";
                nbmotsJ2.Text = "";

                // disable
                txttotalpointsJ2.Enabled = false;
                txtmmotsJ2.Enabled = false;
                nbmotsJ2.Enabled = false;

                // disable groupbox 1
                gpJ1.Enabled = false; 
            }

            // attributs le nom du joueur qui joue a Joueurtxt
            Joueurtxt.Text = JoueurRandom.GetunNom();
            Joueurtxt.Enabled = false;


            // Choisis les lettres

            // Si rejouer
            txtlettres.Text = "";

            string[] lettreschoisis = Utilitaire.RandomLettres();

            foreach ( var value in  lettreschoisis )
            {
                txtlettres.Text = txtlettres.Text + value;
            }

            txtlettres.Enabled = false;

            // Affcihe le nombre de round
            txtround.Text = round.ToString();
            txtround.Enabled = false;

            // Conversion de la chaine de lettre en string sans les virgules et espaces
            // Utiles pour plus tard pour vérifier

            lettres = Utilitaire.Nettoyage(lettreschoisis);
        }

        private void ValiderJ1_Click(object sender, EventArgs e)
        {
            condJ1 = true;
            bool verifie = Utilitaire.Verificationlettres(txtmotsJ1.Text, lettres);
            if (verifie == true)
            {
                System.Windows.Forms.MessageBox.Show("Le mots ne respecte pas les lettres définis veuillez ressayer");
                txtmotsJ1.Clear();
                txtmotsJ1.Focus();
            }
            else
            {
                if (round == 10)
                {
                    System.Windows.Forms.MessageBox.Show("Dernier round, le gagnant sera annoncé après ce round !");
                }
                if (condJ1 == true && condJ2 == true)
                {
                    // actualise le round
                    round = round + 1;
                    txtround.Text = round.ToString();

                    if (round <= 10)
                    {
                        // reintialise les 2 conditions
                        condJ1 = false;
                        condJ2 = false;
                    }
                }

                if (round < 11)
                {
                    // Ajout d'un mot dans la liste atrribuer a joueur 2
                    Joueur1.AjouterMot(txtmotsJ1.Text);

                    // Assignation
                    int point = Utilitaire.PointsMot(txtmotsJ1.Text);
                    totalpointJ1 = totalpointJ1 + point;

                    txttotalpointsJ1.Text = totalpointJ1.ToString();
                    string mmots = Utilitaire.MeilleurMot(txtmotsJ1.Text, mmotsJ1);
                    txtmmotsJ1.Text = mmots;
                    mmotsJ1 = mmots;

                    nbsmotsJ1 = nbsmotsJ1 + 1;
                    nbmotsJ1.Text = nbsmotsJ1.ToString();

                    // active l'autre groupe box
                    gpJ1.Enabled = false;
                    gpJ2.Enabled = true;

                    // désactive les textboxs
                    txttotalpointsJ2.Enabled = false;
                    txtmmotsJ2.Enabled = false;
                    nbmotsJ2.Enabled = false;

                    // focus
                    txtmotsJ2.Focus();

                    // changement de joueur txt
                    Joueurtxt.Text = Joueur2.GetunNom();

                    // clear de la textbox
                    txtmotsJ1.Clear();
                }

                if (round > 10)
                {
                    if (condJ1 == false)
                    {
                        // Ajout d'un mot dans la liste atrribuer a joueur 1
                        Joueur1.AjouterMot(txtmotsJ1.Text);

                        // Assignation
                        int point = Utilitaire.PointsMot(txtmotsJ1.Text);
                        totalpointJ1 = totalpointJ1 + point;

                        txttotalpointsJ1.Text = totalpointJ1.ToString();
                        string mmots = Utilitaire.MeilleurMot(txtmotsJ1.Text, mmotsJ1);
                        txtmmotsJ1.Text = mmots;
                        mmotsJ1 = mmots;

                        nbsmotsJ1 = nbsmotsJ1 + 1;
                        nbmotsJ1.Text = nbsmotsJ1.ToString();
                    }
                    else
                    {
                        // Ajout d'un mot dans la liste atrribuer a joueur 2
                        Joueur2.AjouterMot(txtmotsJ2.Text);

                        // Assignation
                        int point = Utilitaire.PointsMot(txtmotsJ2.Text);
                        totalpointJ2 = totalpointJ2 + point;

                        txttotalpointsJ2.Text = totalpointJ2.ToString();

                        string mmots = Utilitaire.MeilleurMot(txtmotsJ2.Text, mmotsJ2);
                        txtmmotsJ2.Text = mmots;
                        mmotsJ2 = mmots;

                        nbsmotsJ2 = nbsmotsJ2 + 1;
                        nbmotsJ2.Text = nbsmotsJ2.ToString();
                    }

                    // Tab gagnant
                    tabControl.TabPages.Add(tabGagnant);

                    // Delete tab jeu
                    tabControl.TabPages.Remove(Jeu);
                    tabControl.SelectedTab = tabGagnant;

                    // Début du script pour afficher le gagnant
                    Joueur1.GetTotalPoints(totalpointJ1);
                    Joueur2.GetTotalPoints(totalpointJ2);

                    //
                    Joueur1.MotMeilleur(mmotsJ1);
                    Joueur1.MotMeilleur(mmotsJ2);

                    int points1 = Joueur1.GetPoints();
                    int points2 = Joueur2.GetPoints();

                    if (points1 > points2)
                    {
                        txtgagnant.Text = Joueur1.GetunNom();
                        txtgagnant.Enabled = false;
                        listGagnant.DataSource = Joueur1.GetLesMots();
                        txtgagnantmmot.Text = mmotsJ1;
                        txtgagnantmmot.Enabled = false;
                    }
                    else
                    {
                        txtgagnant.Text = Joueur2.GetunNom();
                        listGagnant.DataSource = Joueur2.GetLesMots();
                        txtgagnantmmot.Text = mmotsJ2;
                    }
                }
            }
        }

        private void ValiderJ2_Click(object sender, EventArgs e)
        {
            condJ2 = true;
            bool verifie = Utilitaire.Verificationlettres(txtmotsJ2.Text, lettres);
            if (verifie == true)
            {
                System.Windows.Forms.MessageBox.Show("Le mots ne respecte pas les lettres définis veuillez ressayer");
                txtmotsJ2.Clear();
                txtmotsJ2.Focus();
            }
            else
            {
                if (round == 10)
                {
                    System.Windows.Forms.MessageBox.Show("Dernier round, le gagnant sera annoncé après ce round !");
                }

                if (condJ1 == true && condJ2 == true)
                {
                    if (round <= 10)
                    {
                        // actualise le round
                        round = round + 1;
                        txtround.Text = round.ToString();
                    }

                    // reintialise les 2 conditions
                    condJ1 = false;
                    condJ2 = false;
                }

                if (round <= 11)
                {
                    // Ajout d'un mot dans la liste atrribuer a joueur 2
                    Joueur2.AjouterMot(txtmotsJ2.Text);

                    // Assignation
                    int point = Utilitaire.PointsMot(txtmotsJ2.Text);
                    totalpointJ2 = totalpointJ2 + point;

                    txttotalpointsJ2.Text = totalpointJ2.ToString();

                    string mmots = Utilitaire.MeilleurMot(txtmotsJ2.Text, mmotsJ2);
                    txtmmotsJ2.Text = mmots;
                    mmotsJ2 = mmots;

                    nbsmotsJ2 = nbsmotsJ2 + 1;
                    nbmotsJ2.Text = nbsmotsJ2.ToString();

                    // active l'autre groupe box
                    gpJ2.Enabled = false;
                    gpJ1.Enabled = true;

                    // désactive les textboxs
                    txttotalpointsJ1.Enabled = false;
                    txtmmotsJ1.Enabled = false;
                    nbmotsJ1.Enabled = false;

                    // focus
                    txtmotsJ1.Focus();

                    // changement de joueur txt
                    Joueurtxt.Text = Joueur1.GetunNom();

                    // clear de la textbox
                    txtmotsJ2.Clear();
                }

                if (round > 10)
                {
                    if (condJ1 == false)
                    {
                        // Ajout d'un mot dans la liste atrribuer a joueur 2
                        Joueur1.AjouterMot(txtmotsJ1.Text);

                        // Assignation
                        int point = Utilitaire.PointsMot(txtmotsJ1.Text);
                        totalpointJ1 = totalpointJ1 + point;

                        txttotalpointsJ1.Text = totalpointJ1.ToString();
                        string mmots = Utilitaire.MeilleurMot(txtmotsJ1.Text, mmotsJ1);
                        txtmmotsJ1.Text = mmots;
                        mmotsJ1 = mmots;

                        nbsmotsJ1 = nbsmotsJ1 + 1;
                        nbmotsJ1.Text = nbsmotsJ1.ToString();
                    }
                    else
                    {
                        // Ajout d'un mot dans la liste atrribuer a joueur 2
                        Joueur2.AjouterMot(txtmotsJ2.Text);

                        // Assignation
                        int point = Utilitaire.PointsMot(txtmotsJ2.Text);
                        totalpointJ2 = totalpointJ2 + point;

                        txttotalpointsJ2.Text = totalpointJ2.ToString();

                        string mmots = Utilitaire.MeilleurMot(txtmotsJ2.Text, mmotsJ2);
                        txtmmotsJ2.Text = mmots;
                        mmotsJ2 = mmots;

                        nbsmotsJ2 = nbsmotsJ2 + 1;
                        nbmotsJ2.Text = nbsmotsJ2.ToString();
                    }

                    // Tab gagnant
                    tabControl.TabPages.Add(tabGagnant);

                    // Delete tab jeu
                    tabControl.TabPages.Remove(Jeu);
                    tabControl.SelectedTab = tabGagnant;

                    // Début du script pour afficher le gagnant
                    Joueur1.GetTotalPoints(totalpointJ1);
                    Joueur2.GetTotalPoints(totalpointJ2);

                    // Assignation
                    Joueur1.MotMeilleur(mmotsJ1);
                    Joueur1.MotMeilleur(mmotsJ2);

                    int points1 = Joueur1.GetPoints();
                    int points2 = Joueur2.GetPoints();

                    if (points1 > points2)
                    {
                        txtgagnant.Text = Joueur1.GetunNom();
                        txtgagnant.Enabled = false;
                        listGagnant.DataSource = Joueur1.GetLesMots();
                        txtgagnantmmot.Text = mmotsJ1;
                        txtgagnantmmot.Enabled = false;
                    }
                    else
                    {
                        txtgagnant.Text = Joueur2.GetunNom();
                        listGagnant.DataSource = Joueur2.GetLesMots();
                        txtgagnantmmot.Text = mmotsJ2;
                    }

                }
            }
        }

        private void Rejouer_Click(object sender, EventArgs e)
        {
            // clean de gagnant ,joueur.cs et remove de la tab

            // clean
            txtgagnant.Clear();
            listGagnant.DataSource = null;
            txtgagnantmmot.Clear();

            // remove tabGagnant et ajoute Joueurs
            tabControl.TabPages.Add(tabJoueurs);
            tabControl.TabPages.Remove(tabGagnant);

            // clean des variables
            round = 1;
            lettres = "";
            totalpointJ1 = 0; totalpointJ2 = 0;
            mmotsJ1 = ""; mmotsJ2 = "";
            nbsmotsJ1 = 0; nbsmotsJ2 = 0;
            condJ1 = false; condJ2 = false;

            // clean Joueur.cs
            Joueur1.WipeList();
            Joueur2.WipeList();
            Joueur1.WipePoints();
            Joueur2.WipePoints();
            Joueur1.WipeMeilleurMot();
            Joueur2.WipeMeilleurMot();

            // focus
            tabControl.SelectedTab = Joueurs;


        }

        // Ignorer le restes
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

        private void nbmotsJ1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

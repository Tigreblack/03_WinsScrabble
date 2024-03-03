using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinScrabble
{
    /// <summary>
    /// Classe qui regroupe les fonctions de calcul
    /// </summary>
    public static class Utilitaire
    {
        /// <summary>
        /// Méthode qui retourne le nombre de points que rapporte une lettre
        /// </summary>
        /// <param name="l">Lettre de type char</param>
        /// <returns>Nombre de points rapportés par la lettre</returns>
        private static int PointsLettre(char l)
        {
            int p;
            if (l == 'D' || l == 'G' || l == 'M')
                p = 2;
            else
            {
                if (l == 'B' || l == 'C' || l == 'P')
                    p = 3;
                else
                {
                    if (l == 'F' || l == 'H' || l == 'V')
                        p = 4;
                    else
                    {
                        if (l == 'J' || l == 'Q')
                            p = 8;
                        else
                        {
                            if (l == 'K' || l == 'W' || l == 'X' || l == 'Y' || l == 'Z')
                                p = 10;
                            else
                                p = 1;
                        }
                    }
                }
            }
            return p;
        }
        /// <summary>
        /// Méthode qui retourne le nombre de points que rapporte un mot
        /// </summary>
        /// <param name="mot">Mot de type string</param>
        /// <returns>Nombre de points du mot</returns>
        public static int PointsMot(string mot)
        {
            mot = mot.ToUpper();
            int pts = 0;
            for (int i = 0; i <= mot.Length - 1; i++)
            {
                char lettre = mot[i];
                pts = pts + PointsLettre(lettre);
            }
            return pts;
        }

        public static string MeilleurMot(string mot, string mmots)
        {
            
            int mot1 = PointsMot(mot);
            int mot2 = PointsMot(mmots);
            string lemot = "";

            if (mot1 > mot2)
            {
                lemot = mot;
            }
            else
            {
                lemot = mmots;
            }

            return lemot;
        }

        /// <summary>
        /// Méthode qui choisis 7 lettres au hasard dans l'alphabets et les renvoie dans  un tableau.
        /// </summary>
        /// <returns>le tableau en question de 7 lettres</returns>
        public static string[] RandomLettres()
        {
            string[] selectedletter = new string[7];
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
            selectedletter[selectedletter.Length - 1] = selectedletter[selectedletter.Length - 1].Trim(',', ' ');

            return selectedletter;
        }

        /// <summary>
        /// Méthode qui retourne une chaine de lettre toute propre sans les virgules et espaces
        /// </summary>
        /// <param name="tableau"></param>
        /// <returns>cleaned string</returns>
        public static string Nettoyage(string[] tableau)
        {
            string cleaned = "";

            foreach(string element in tableau)
            {
                element.Trim(',', ' ');
                cleaned = cleaned + element;
            }

            return cleaned;
        }
        /// <summary>
        /// Méthode qui choisis un joueur aléotoire parmis les 2 joueurs
        /// </summary>
        /// <param name="J1">Joueur 1</param>
        /// <param name="J2">Joueur 2</param>
        /// <returns>Le joueur choisis parmis les 2 joueurs </returns>
        public static Joueur RandomJoueur(Joueur J1, Joueur J2)
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
        /// Méthode qui permet de vérfier s'y les lettres sont bien respectées
        /// </summary>
        /// <param name="chaine">réponse</param>
        /// <param name="verifie">liste des mots</param>
        /// <returns>true ou false</returns>
        public static bool Verificationlettres(string chaine, string verifie)
        {
            bool cac = false;

            // Pour mettre des majuscules ou miniscules
            string vef1 = verifie.ToUpper();
            string c1 = chaine.ToUpper();

            foreach( char s in c1)
            {
                if(!vef1.Contains(s.ToString()))
                {
                    cac = true;
                    // casse le foreach s'y jamais il ya une autre lettre que dans la chaine verifie
                    break;
                }
            }

            return cac;
        }
    }
}

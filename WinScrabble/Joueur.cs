using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinScrabble
{
    /// <summary>
    /// Classe Joueur
    /// </summary>
    public class Joueur
    {
        #region attributs privés
        private string nom;             // nom du joueur 
        private List<string> lesMots;   // liste des mots proposés par le joueur
        private int totalPoints;        // nombre total de points du joueur
        private string MeilleurMots; // MeilleurMots
        #endregion

        #region constructeur
        /// <summary>
        /// Constructeur de la classe Joueur
        /// </summary>
        /// <param name="unNom"></param>
        public Joueur(string unNom)
        {
            this.nom = unNom;
            this.lesMots = new List<string>();
            this.totalPoints = 0;
            this.MeilleurMots = "";
        }
        #endregion

        #region méthodes
        /// <summary>
        /// Méthode qui permet d'ajouter un mot à la liste des mots du joueur
        /// et qui actualise le nombre total de points du joueur
        /// </summary>
        /// <param name="unMot">mot proposé par le joueur</param>
        public void AjouterMot(string unMot)
        {
            lesMots.Add(unMot);
            this.totalPoints = this.totalPoints + Utilitaire.PointsMot(unMot);
        }

        /// <summary>
        /// retourne le nombre total de points du joueur (getter)
        /// </summary>
        /// <returns>nombre total de points du joueur</returns>
        public int GetTotalPoints(int point)
        {
            point = this.totalPoints;
            return this.totalPoints;
        }

        /// <summary>
        /// retourne le nombre total de points du joueur ( version pour récupérer )
        /// </summary>
        /// <returns></returns>
        public int GetPoints()
        {
            return this.totalPoints;
        }
        /// <summary>
        /// retourne la liste des mots du joueur
        /// </summary>
        /// <returns>liste de mots du joueur</returns>
        public List<string> GetLesMots()
        {
            return this.lesMots;
        }

        #region Wipe
        public List<string> WipeList()
        {
            this.lesMots.Clear();
            return this.lesMots;
        }

        public int WipePoints()
        {
            this.totalPoints = 0;
            return this.totalPoints;
        }

        public string WipeMeilleurMot()
        {
            this.MeilleurMots = "";
            return this.MeilleurMots;
        }

        #endregion

        /// <summary>
        /// retourne le mot qui a rapporté le plus grand nombre de points 
        /// parmi les mots proposés par le joueur
        /// </summary>
        /// <returns>mot qui a rapporté le plus grand nombre de points</returns>
        public string MotMeilleur(string mot)
        {
            mot = this.MeilleurMots;
            return this.MeilleurMots;
        }
        /// <summary>
        /// Méthode qui retourne le nom du joueur
        /// </summary>
        /// <returns></returns>
        public string GetunNom()
        {
            return this.nom;
        }
        #endregion
    }
}

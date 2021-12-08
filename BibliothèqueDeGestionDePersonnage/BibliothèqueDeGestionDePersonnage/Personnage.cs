using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothèqueDeGestionDePersonnage
{
    /// <summary>
    /// Cette classe représente des personnages dans un jeu de combat.
    /// <code>
    ///     Personnage personnage = new Personnage("Patrick", 10, 2);
    ///     personnage.SubbitDegat(5);
    /// </code>
    /// </summary>
    public class Personnage
    {
        /// <summary>
        /// Nom du personnage.
        /// </summary>
        public string Nom { get; }
        /// <summary>
        /// Points de vie du personnage.
        /// </summary>
        public int PV { get; private set; }
        /// <summary>
        /// Armure du personnage.
        /// </summary>
        public int Armure { get; }
        /// <summary>
        /// Constructeur à paramètre pour instancier un personnage.
        /// </summary>
        /// <param name="nom">Le nom du personnage</param>
        /// <param name="pv">Le nombre de point de vie du personnage</param>
        /// <param name="armure">La force de l'armure du personnage</param>
        public Personnage(string nom, int pv, int armure)
        {
            Nom = nom;
            PV = pv;
            Armure = armure;
        }
        /// <summary>
        /// Cette fonction permet au personnage de subir des dégats.
        /// </summary>
        /// <param name="degat">Nombre de dégat que le personnage va subir.</param>
        public void SubbitDegat(int degat)
        {
            int degatSubbit = GetDegatApresArmure(degat);

            PV =-degatSubbit;
            if (PV < 0)
                PV = 0;
        }

        private int GetDegatApresArmure(int degat)
        {
            int vraiDegat = degat - Armure;

            if (vraiDegat<0)
                vraiDegat = 0;

            return vraiDegat;
        }
    }
}

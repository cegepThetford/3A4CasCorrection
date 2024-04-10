using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasCorrection_Affaires
{
    public class Exercice
    {
        private string _titre;
        private double _noteSur;
        private List<FicheCorrection> _fiches;

        #region Proprietes
        public string Titre { get { return _titre; } set { _titre = value; } }
        public double NoteSur { get { return _noteSur; } set { _noteSur = value; } }
        public List<FicheCorrection> Fiches { get { return _fiches; } set { _fiches = value; } }
        #endregion

        public Exercice(string titre, double noteSur)
        {
        }

        public void ajouterFiche(string nom, double note)
        {
        }
        public int denombrerEchecs()
        {
            return 0;
        }
        public List<FicheCorrection> extraireEchecs()
        {
            return null;
        }

        public FicheCorrection rechercherFiche(string nom)
        {
            return null;
        }
        public void supprimerFiche(FicheCorrection f)
        {
        }
        public double calculerMoyenne()
        {
            return 0.0;
        }
        public int denombrerFiches()
        {
            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasCorrection_Affaires
{
    public class FicheCorrection
    {
        private string _nom;
        private double _noteObtenue, _noteSur;

        #region Proprietes
        public string Nom { get { return _nom; } set { _nom = value; } }
        public double NoteObtenue { get { return _noteObtenue; } set { _noteObtenue = value; } }
        public double NoteSur { get { return _noteSur; } set { _noteSur = value; } }
        #endregion

        public FicheCorrection(string nom, double note, double noteSur)
        {
            _nom = nom;
            _noteObtenue = note;
            _noteSur = noteSur;
        }

        public bool aEchec()
        {
            return _noteObtenue / _noteSur < 0.6;
        }

        public override int GetHashCode()
        {
            return new { _nom, _noteObtenue, _noteSur }.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool equivalence = false;
            FicheCorrection autre = obj as FicheCorrection;
            if (autre != null)
                equivalence = _nom.Equals(autre.Nom); // considere noms uniques
            return equivalence;
        }
    }
}

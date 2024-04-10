using Microsoft.VisualStudio.TestTools.UnitTesting;
using CasCorrection_Affaires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasCorrectionTests
{
    [TestClass()]
    public class ExerciceTests
    {
        private Exercice _exerc;
        private FicheCorrection _ficheAdam, _ficheBernard, _ficheCharles;

        [TestInitialize]
        public void initialisation()
        {
            _exerc = new Exercice("Exercice #3", 20.0);
            _ficheAdam = new FicheCorrection("Adam", 15.0, 20.0);
            _ficheBernard = new FicheCorrection("Bernard", 20.0, 20.0);
            _ficheCharles = new FicheCorrection("Charles", 10.0, 20.0);
        }
        [TestMethod()]
        public void CreationExerciceTests()
        {
            Assert.AreEqual("Exercice #3", _exerc.Titre);
            Assert.AreEqual(20.0, _exerc.NoteSur);
            Assert.IsNotNull(_exerc.Fiches);
            Assert.AreEqual(0, _exerc.Fiches.Count);
        }
        [TestMethod]
        public void AjoutsRechercheExerciceTests()
        {
            Assert.IsNull(_exerc.rechercherFiche("Zebulon"));
            _exerc.ajouterFiche("Adam", 15.0);
            Assert.IsNull(_exerc.rechercherFiche("Zebulon"));
            FicheCorrection f = _exerc.rechercherFiche("Adam");
            Assert.IsNotNull(f);
            Assert.AreEqual(_ficheAdam, f);
            Assert.AreEqual(1, _exerc.Fiches.Count);
            Assert.AreEqual(_ficheAdam, _exerc.Fiches.First());
            _exerc.ajouterFiche("Charles", 10.0);
            Assert.AreEqual(2, _exerc.Fiches.Count);
            Assert.AreEqual(_ficheAdam, _exerc.Fiches.First());
            Assert.AreEqual(_ficheCharles, _exerc.Fiches.Last());
            Assert.AreEqual(_ficheAdam, _exerc.rechercherFiche("Adam"));
            Assert.AreEqual(_ficheCharles, _exerc.rechercherFiche("Charles"));
        }
        [TestMethod]
        public void AjoutSuppressionExerciceTests()
        {
            _exerc.ajouterFiche("Adam", 15.0);
            _exerc.ajouterFiche("Bernard", 20.0);
            _exerc.ajouterFiche("Charles", 10.0);
            Assert.AreEqual(3, _exerc.denombrerFiches());
            _exerc.supprimerFiche(_ficheBernard);
            Assert.AreEqual(2, _exerc.denombrerFiches());
            Assert.AreEqual(_ficheAdam, _exerc.Fiches.First());
            Assert.AreEqual(_ficheCharles, _exerc.Fiches.Last());
            _exerc.supprimerFiche(_ficheCharles);
            Assert.AreEqual(1, _exerc.denombrerFiches());
            Assert.AreEqual(_ficheAdam, _exerc.Fiches.First());
            _exerc.supprimerFiche(_ficheAdam);
            Assert.AreEqual(0, _exerc.denombrerFiches());
        }

        [TestMethod]
        public void EchecsMoyenneExerciceTests()
        {
            Assert.AreEqual(0.0, _exerc.calculerMoyenne());
            Assert.AreEqual(0, _exerc.denombrerEchecs());
            Assert.IsNotNull(_exerc.extraireEchecs());
            Assert.AreEqual(0, _exerc.extraireEchecs().Count);
            _exerc.ajouterFiche("Adam", 15.0);
            _exerc.ajouterFiche("Bernard", 20.0);
            Assert.AreEqual(17.5, _exerc.calculerMoyenne(), 0.01);
            Assert.AreEqual(0, _exerc.denombrerEchecs());
            _exerc.ajouterFiche("Charles", 10.0);
            Assert.AreEqual(1, _exerc.extraireEchecs().Count);
            Assert.AreEqual(_ficheCharles, _exerc.extraireEchecs().First());
            Assert.AreEqual(15.0, _exerc.calculerMoyenne(), 0.01);
            Assert.AreEqual(1, _exerc.denombrerEchecs());
            _exerc.ajouterFiche("Denis", 2.0);
            Assert.AreEqual(2, _exerc.extraireEchecs().Count);
            Assert.AreEqual(_ficheCharles, _exerc.extraireEchecs().First());
            Assert.AreEqual("Denis", _exerc.extraireEchecs().Last().Nom);
            Assert.AreEqual(11.75, _exerc.calculerMoyenne(), 0.01);
            Assert.AreEqual(2, _exerc.denombrerEchecs());
        }
    }
}
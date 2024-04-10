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
    public class FicheCorrectionTests
    {
        private FicheCorrection _fiche6sur10,
                                _fiche9sur20,
                                _fiche2sur5;
        [TestInitialize]
        public void initialisation()
        {
            _fiche6sur10 = new FicheCorrection("Adam Bernard", 6, 10);
            _fiche9sur20 = new FicheCorrection("Charles Demers", 9, 20);
            _fiche2sur5 = new FicheCorrection("Eric Fillion", 2, 5);
        }

        [TestMethod()]
        public void CreationFicheCorrectionTest()
        {
            Assert.AreEqual("Adam Bernard", _fiche6sur10.Nom);
            Assert.AreEqual(6, _fiche6sur10.NoteObtenue);
            Assert.AreEqual(10, _fiche6sur10.NoteSur);
            Assert.AreEqual(2, _fiche2sur5.NoteObtenue);
            Assert.AreEqual(20, _fiche9sur20.NoteSur);
        }

        [TestMethod]
        public void EchecsFicheCorrectionTests()
        {
            Assert.IsFalse(_fiche6sur10.aEchec());
            Assert.IsTrue(_fiche9sur20.aEchec());
            Assert.IsTrue(_fiche2sur5.aEchec());
            _fiche2sur5.NoteSur = 3;
            Assert.IsFalse(_fiche2sur5.aEchec());
        }
    }
}
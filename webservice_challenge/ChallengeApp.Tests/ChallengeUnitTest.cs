using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeApp.Tests
{
    /// <summary>
    /// Classe de test du service ChallengeService
    /// </summary>
    [TestClass]
    public class ChallengeUnitTest
    {
        #region -- Webservice initialisation

        private static ChallengeServiceReference.ChallengeServiceSoapClient _service;

      
        [ClassInitialize]
        public static void InitializeClass(TestContext ctx)
        {
            _service = new ChallengeServiceReference.ChallengeServiceSoapClient();
        }


        [ClassCleanup]
        public static void CleanupClass()
        {
            _service.Close();
        }

        #endregion


        /// <summary>
        /// Méthode de test de la fonction Fibonacci
        /// </summary>
        [TestMethod]
        public void TestFibonacci()
        {
            var result = _service.Fibonacci(6);
            Assert.AreEqual(8, result, "Call should return the string 8");

        }
    }
}

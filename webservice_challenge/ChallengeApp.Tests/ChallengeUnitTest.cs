using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeApp.Tests
{
    [TestClass]
    public class ChallengeUnitTest
    {
        #region -- Webservice initialisation

        // The client object for the WCF service.
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
        [TestMethod]
        public void TestFibonacci()
        {
            var result = _service.Fibonacci(6);
            Assert.AreEqual(8, result, "Call should return the string 8");

        }
    }
}

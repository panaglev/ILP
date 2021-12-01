using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ILP.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EcnryptTest() 
        {
            string s = "I love Paris";
            double e = 5;
            double n = 323;
            string result = RSA.Encrypt(s, e, n);
            string compareWith = "307,61,115,169,7,109,61,196,168,49,6,107";
            Assert.AreEqual(compareWith, result);
        }

        [TestMethod]
        public void DecryptTest() 
        {
            string message = "307,61,115,169,7,109,61,196,168,49,6,107";
            double d = 173;
            double n = 323;
            string result = RSA.Decrypt(message, d, n);
            string compareWith = "I love Paris";
            Assert.AreEqual(compareWith, result);
        }
    }
}

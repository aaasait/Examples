using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Stringie;

namespace Stringie.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestMethod]
        public void TestMethod2()
        {
            int length = DomainCheck.GetDomainExtLenght("co");
            //int length = DomainCheck.GetDomainExtLenght("com");

            Assert.AreEqual(3, length);
        }

        [TestMethod]
        public void TestMethod3()
        {

        }

        [TestMethod]
        public void TestMethod4()
        {

        }

        [TestMethod]
        public void TestMethod5()
        {

        }
    }
}

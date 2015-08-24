using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace PrimeFactorKata.Tests
{
    [TestFixture]
    public class PrimeFactorTest
    {
        PrimeFactor primefactor = null;

        [SetUp]
        public void InitializeTest()
        {
            primefactor = new PrimeFactor();
        }

        [TearDown]
        public void FinalizeTest()
        {

        }

        [Test]
        public void Test_PrimeFactor_1_Equals_Null()
        {
            Assert.AreEqual(null, primefactor.GetList(1));
        }

        [Test]
        public void Test_PrimeFactor_2_Equals_2()
        {
            Assert.AreEqual(new List<int> { 2 }, primefactor.GetList(2));
        }
    }
}

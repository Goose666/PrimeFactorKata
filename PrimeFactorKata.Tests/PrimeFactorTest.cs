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
        public void Test_PrimeFactor_1_Returns_Null()
        {
            Assert.AreEqual(new List<int>(), primefactor.GetList(1));
        }

        [Test]
        public void Test_PrimeFactor_2_Returns_2()
        {
            Assert.AreEqual(new List<int> { 2 }, primefactor.GetList(2));
        }

        [Test]
        public void Test_PrimeFactor_3_Returns_3()
        {
            Assert.AreEqual(new List<int> { 3 }, primefactor.GetList(3));
        }

        [Test]
        public void Test_PrimeFactor_4_Returns_2_2()
        {
            Assert.AreEqual(new List<int> { 2, 2 }, primefactor.GetList(4));
        }

        [Test]
        public void Test_PrimeFactor_5_Returns_5()
        {
            Assert.AreEqual(new List<int> { 5 }, primefactor.GetList(5));
        }

        [Test]
        public void Test_PrimeFactor_6_Returns_2_3()
        {
            Assert.AreEqual(new List<int> { 2, 3 }, primefactor.GetList(6));
        }

        [Test]
        public void Test_PrimeFactor_8_Returns_2_2_2()
        {
            Assert.AreEqual(new List<int> { 2, 2, 2 }, primefactor.GetList(8));
        }

        [Test]
        public void Test_PrimeFactor_9_Returns_3_3()
        {
            Assert.AreEqual(new List<int> { 3, 3 }, primefactor.GetList(9));
        }
    }
}

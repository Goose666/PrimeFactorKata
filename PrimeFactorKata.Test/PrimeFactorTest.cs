﻿using System;
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
            Assert.Fail("PrimeFactor class doesn't present generation method.");
        }
    }
}

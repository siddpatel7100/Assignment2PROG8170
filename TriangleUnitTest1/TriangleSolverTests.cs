using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment2PROG8170;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Assignment2PROG8170.Tests
{
    [TestClass()]
    public class TriangleSolverTests
    {
        [TestMethod()]
        public void analyzeTriangleValidityTest_NotValid()
        {
            Assert.That(TriangleSolver.analyze(2, 3, 8), Is.EqualTo("The triangle is not valid.\n"));
        }

        [TestMethod()]
        public void analyzeEquilateraltriangleTest()
        {
            Assert.That(TriangleSolver.analyze(25, 25, 25), Is.EqualTo("This is an equilateral triangle.\n"));
        }

        [TestMethod()]
        public void analyzeIsoscelestriangleTest()
        {
            Assert.That(TriangleSolver.analyze(70, 70, 40), Is.EqualTo("This is an isosceles triangle.\n"));
        }

        [TestMethod()]
        public void analyzescalenetriangleTest()
        {
            Assert.That(TriangleSolver.analyze(7, 12, 15), Is.EqualTo("This is a scalene triangle.\n"));
        }
    }
}
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
        [TestMethod()]//It will check user entered number and display message if any input is not forming a valid traingle
        public void analyzeTriangleValidityTest_NotValid()
        {
            Assert.That(TriangleSolver.analyze(2, 3, 8), Is.EqualTo("The triangle is not valid.\n"));
        }

        [TestMethod()]//Will check input number forming an Equilateral Triangle
        public void analyzeEquilateraltriangleTest_IsTrue()
        {
            Assert.That(TriangleSolver.analyze(25, 25, 25), Is.EqualTo("This is an equilateral triangle.\n"));
        }

        [TestMethod()]//Will check input number forming an Isosceles Triangle
        public void analyzeIsoscelestriangleTest_IsTrue()
        {
            Assert.That(TriangleSolver.analyze(70, 70, 40), Is.EqualTo("This is an isosceles triangle.\n"));
        }

        [TestMethod()]//Will check input number forming a Scalene Triangle
        public void analyzeScalenetriangleTest_IsTrue()
        {
            Assert.That(TriangleSolver.analyze(7, 12, 15), Is.EqualTo("This is a scalene triangle.\n"));
        }

        [TestMethod()]// Will verify first side is a valid number i.e. not negative,if it is then it will display an error
        public void sideOneNumberValidityCheck_IsNegative()
        {
            Assert.That(TriangleSolver.analyze(-5,5,6),Is.EqualTo("Side One Invalid"));
        }

        [TestMethod()]// Will verify Second side is a valid number i.e. not negative,if it is then it will display an error
        public void sideTwoNumberValidityCheck_IsNegative()
        {
            Assert.That(TriangleSolver.analyze(8,-10,2), Is.EqualTo("Side Two Invalid"));
        }

        [TestMethod()]// Will verify Third side is a valid number i.e. not negative,if it is then it will display an error
        public void sideThreeNumberValidityCheck_IsNegative()
        {
            Assert.That(TriangleSolver.analyze(7, 4, -9), Is.EqualTo("Side Three Invalid"));
        }

        [TestMethod()]// Will verify all sides is a valid number i.e. not negative,if it is then it will display an error
        public void allSidesNumberValidityCheck_IsNegative()
        {
            Assert.That(TriangleSolver.analyze(-9,-8,-15), Is.EqualTo("All sides are negative"));
        }
    }
}
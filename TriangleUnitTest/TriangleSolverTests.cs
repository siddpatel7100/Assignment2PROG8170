
using Assignment2PROG8170;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Assignment2PROG8170.Tests
{
    [TestFixture]
    public class TriangleSolverTests
    {
        [Test]
        public void analyzeTriangleValidity()
        {
            Assert.That(TriangleSolver.analyze(2, 3, 8), Is.EqualTo("Triangle Not Valid"));
        }
    }
}
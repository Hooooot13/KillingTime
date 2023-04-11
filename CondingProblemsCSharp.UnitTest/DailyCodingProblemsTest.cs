using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingProblemsCSharp;
using NUnit;

namespace CondingProblemsCSharp.UnitTest
{
    internal class DailyCodingProblemsTest
    {
        public readonly DailyCodingProblems _dailyCodingProblems = new DailyCodingProblems();

        [SetUp]
        public void Setup()
        {

        }

        [TestCase("Linux is great and you know it ;)", ";) it know you and great is linux")]
        public void reverseWordOrderInString_GivenString_ReversesWordOrder(string givenString, string revercedString)
        {
            string result = _dailyCodingProblems.reverseWordOrderInString(givenString);

            Assert.That(result, Is.EqualTo(revercedString));
        }

        [TestCase("Linux is great and you know it ;)", ";) it know you and great is linux")]
        public void reverseWordOrderInString_OneLiner_GivenString_ReversesWordOrder(string givenString, string revercedString)
        {
            string result = _dailyCodingProblems.reverseWordOrderInString_OneLiner(givenString);

            Assert.That(result, Is.EqualTo(revercedString));
        }
    }
}

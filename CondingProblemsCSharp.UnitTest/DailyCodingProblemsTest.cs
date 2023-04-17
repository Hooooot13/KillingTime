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
        public void reverseWordOrderInString_OneLiner_GivenString_ReversesWordOrder(string givenString, string revercedString)
        {
            string result = _dailyCodingProblems.reverseWordOrderInString_OneLiner(givenString);

            Assert.That(result, Is.EqualTo(revercedString));
        }

        [TestCase(new int[] { 2, 1, 2 }, 1)]
        [TestCase(new int[] { 3, 0, 1, 3, 0, 5 }, 8)]
        [TestCase(new int[] { 5, 0, 0, 0, 0, 0, 5}, 25)]
        [TestCase(new int[] { 5, 0, 0, 0, 0, 0, 0 }, 0)]
        [TestCase(new int[] { 2, 0, 5, 0, 2}, 4)]
        public void rainTrapped_GivenArray_ReturnsIntOfFreeSpaces(int[] input, int result)
        {
            Assert.That(_dailyCodingProblems.rainTrapped(input), Is.EqualTo(result));
        }
    }
}

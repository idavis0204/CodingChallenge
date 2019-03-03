using BackendConsoleApp;
using NUnit.Framework;
using System.Collections.Generic;

namespace BackendTests
{
    [TestFixture]
    public class Task2Tests
    {
        string noOneLikeThisString = "no one likes this";

        [Test]
        public void NullNameArrayReturnsNoOneLikes()
        {
            var expectedString = noOneLikeThisString;

            var actualString = Task2.GenerateLikesString(null);

            Assert.AreEqual(expectedString, actualString);
        }

        [Test]
        public void EmptyNameArrayReturnsNoOneLikes()
        {
            var expectedString = noOneLikeThisString;
            var emptyNameList = new List<string>();

            var actualString = Task2.GenerateLikesString(emptyNameList);

            Assert.AreEqual(expectedString, actualString);
        }

        [Test]
        public void SingleNameArrayReturnsOneLike()
        {
            var expectedString = "Peter likes this";
            var emptyNameList = new List<string>() { "Peter" };

            var actualString = Task2.GenerateLikesString(emptyNameList);

            Assert.AreEqual(expectedString, actualString);
        }

        [Test]
        public void TwoNameArrayReturnsTwoLikes()
        {
            var expectedString = "Jacob and Alex like this";
            var emptyNameList = new List<string>() { "Jacob", "Alex" };

            var actualString = Task2.GenerateLikesString(emptyNameList);

            Assert.AreEqual(expectedString, actualString);
        }

        [Test]
        public void ThreeNameArrayReturnsThreeLikes()
        {
            var expectedString = "Max, John and Mark like this";
            var emptyNameList = new List<string>() { "Max", "John", "Mark" };

            var actualString = Task2.GenerateLikesString(emptyNameList);

            Assert.AreEqual(expectedString, actualString);
        }

        [Test]
        public void FiveNameArrayReturnsTwoPlusLikes()
        {
            var expectedString = "Alex, Jacob and 3 others like this";
            var emptyNameList = new List<string>() { "Alex", "Jacob", "Mark", "Max", "Iain" };

            var actualString = Task2.GenerateLikesString(emptyNameList);

            Assert.AreEqual(expectedString, actualString);
        }
    }
}

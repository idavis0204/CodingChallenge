using Backend;
using NUnit.Framework;

namespace BackendTests
{
    [TestFixture]
    public class Task1Tests
    {
        string stackOverflowString = "Stack Overflow!";
        string overflowString = "Overflow";
        string stackString = "Stack";

        [Test]
        public void StringDivisibleByTwoAndFourReturnsStackOverflow()
        {
            var expectedResult = stackOverflowString;
            var inputString = "consoles";

            var actualResult = Task1.GenerateStackOverFlowString(inputString, 2, 4);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void StringDivisibleByTwoOnlyReturnsStack()
        {
            var expectedResult = stackString;
            var inputString = "insert";

            var actualResult = Task1.GenerateStackOverFlowString(inputString, 2, 4);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void StringDivisibleNeitherTwoOrFourReturnsEmptyString()
        {
            var expectedResult = string.Empty;
            var inputString = "end";

            var actualResult = Task1.GenerateStackOverFlowString(inputString, 2, 4);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void StringDivisibleByThreeButNotTwoReturnsOverflow()
        {
            var expectedResult = overflowString;
            var inputString = "asdfghjkl";

            var actualResult = Task1.GenerateStackOverFlowString(inputString, 2, 3);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace PurchaseList.Tests
{
    [TestClass]
    public class PurchaseListTests
    {
        [TestMethod]
        public void PurchaseListTest1()
        {
            string input = "5 5 4 7 4 1 11";
            string expectedOutput = "7\n5\n";
            RunTest(input, expectedOutput);
        }

        [TestMethod]
        public void PurchaseListTest2()
        {
            string input = "1 2 3 3 3 3 3 3 3 3 3 3 3 3 3 2 1";
            string expectedOutput = "none\n3\n";
            RunTest(input, expectedOutput);
        }

        [TestMethod]
        public void PurchaseListTest3()
        {
            string input = "1 2 3 4 5";
            string expectedOutput = "1\nnone\n";
            RunTest(input, expectedOutput);
        }

        private void RunTest(string input, string expectedOutput)
        {
            // Arrange
            var consoleInput = new StringReader(input);
            Console.SetIn(consoleInput);
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            Program.Main(new string[] { });

            // Assert
            string actualOutput = consoleOutput.ToString();
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "2\nnoon moon\npart trap\n";
            string expectedOutput = "NO\nYES\n";
            RunTest(input, expectedOutput);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string input = "3\ntest5 estt5\nabcdefg abcdegf\nzag vaa\n";
            string expectedOutput = "YES\nNO\nNO\n";
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
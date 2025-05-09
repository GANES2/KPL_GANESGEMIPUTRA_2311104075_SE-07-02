using Microsoft.VisualStudio.TestTools.UnitTesting;
using modul12;

namespace unittest
{
    [TestClass]
    public class Unittest
    {
        [TestMethod]
        public void TestGrade()
        {
            // Test case untuk nilai A
            string result1 = Program.DetermineGrade(90);
            Assert.AreEqual("A", result1);

            // Test case untuk nilai B
            string result2 = Program.DetermineGrade(85);
            Assert.AreEqual("B", result2);

            // Test case untuk nilai C
            string result3 = Program.DetermineGrade(70);
            Assert.AreEqual("C", result3);

            // Test case untuk nilai D
            string result4 = Program.DetermineGrade(65);
            Assert.AreEqual("D", result4);

            // Test case untuk nilai E
            string result5 = Program.DetermineGrade(50);
            Assert.AreEqual("E", result5);
        }
    }
}

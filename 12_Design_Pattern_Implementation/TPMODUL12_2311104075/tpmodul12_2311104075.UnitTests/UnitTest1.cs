using Microsoft.VisualStudio.TestTools.UnitTesting;
using tpmodul12_2311104075;
using System.Windows.Forms;

namespace tpmodul12_2311104075.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private Form1 form;

        [TestInitialize]
        public void Setup()
        {
            form = new Form1();
            form.Show(); // Needed to initialize controls properly
        }

        [TestMethod]
        public void TestCariTandaBilangan_Negatif()
        {
            string result = form.CariTandaBilangan(-5);
            Assert.AreEqual("Negatif", result);
        }

        [TestMethod]
        public void TestCariTandaBilangan_Positif()
        {
            string result = form.CariTandaBilangan(10);
            Assert.AreEqual("Positif", result);
        }

        [TestMethod]
        public void TestCariTandaBilangan_Nol()
        {
            string result = form.CariTandaBilangan(0);
            Assert.AreEqual("Nol", result);
        }

        [TestMethod]
        public void TestButtonCheck_Click_ValidInput()
        {
            form.textBoxInput.Text = "15";
            form.buttonCheck.PerformClick();
            Assert.AreEqual("Positif", form.labelResult.Text);
        }

        [TestMethod]
        public void TestButtonCheck_Click_InvalidInput()
        {
            form.textBoxInput.Text = "abc";
            form.buttonCheck.PerformClick();
            Assert.AreEqual("Input tidak valid!", form.labelResult.Text);
        }
    }
}

using Microsoft.VisualStudio.TestPlatform.TestHost;
using static ProgramaNS.Calculator;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            {
                double result = calculateTotalPrice(-1, "standard", -1);
                Assert.AreEqual(5.0, result);
            }
            {
                double result = calculateTotalPrice(10, "standard", 20);
                Assert.AreEqual(20.0, result);
            }
            {
                double result = calculateTotalPrice(10, "standard", -1);
                Assert.AreEqual(15.0, result);
            }
            {
                double result = calculateTotalPrice(60, "overnight", 5);
                Assert.AreEqual(70, result);
            }
        }
    }
}
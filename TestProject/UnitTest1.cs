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
                double result = calculateTotalPrice(60, "overnight", 5);
                Assert.AreEqual(70, result);
            }
        }
    }
}
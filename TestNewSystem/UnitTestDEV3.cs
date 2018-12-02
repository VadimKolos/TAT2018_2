using DEV_7;
using NUnit.Framework;


namespace TestNewSystem
{
    [TestFixture]
    public class NUnitTestNewSystem
    {
        NewSystem test = new NewSystem();

        [TestCase("7", 2, "111")]
        [TestCase("0", 15, "0")]
        [Test]
        
        public void input_7and2_111returned(string inputValue, int countSystem, string result)
        {
            string tests = test.Convert_count_System(inputValue, countSystem);
            Assert.AreEqual(tests, result);
        }
       
    }
}

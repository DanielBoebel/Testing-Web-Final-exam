using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingFinalExam;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1  
    {
          
        [TestMethod]
        public void TestMethod1()
        {
            int a = 1;
            int b = 1;
            int c = 1;

            TestingFinalExam.Controllers.MathLogicController mathLogicController = new TestingFinalExam.Controllers.MathLogicController();

            mathLogicController.addNumbers(a, b, c);

            //bool result = Viewbag.addResult;
            Assert.AreEqual(true,mathLogicController.addNumbers(a, b, c));

        }
    }
}

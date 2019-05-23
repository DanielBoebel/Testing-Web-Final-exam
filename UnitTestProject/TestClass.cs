using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingFinalExam;


namespace TestClass
{
    [TestClass]
    public class TestClass
       
    {
         

        [TestMethod]
        public void addNumbersTestSucced()
        {
            int a = 1;
            int b = 1;
            int c = 1;

            TestingFinalExam.Controllers.MathLogicController mathLogicController = new TestingFinalExam.Controllers.MathLogicController();

            var result = mathLogicController.addNumbers(a, b, c);

            //bool result = Viewbag.addResult;
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void addNumbersTestFail()
        {
            int a = 2;
            int b = 1;
            int c = 1;

            TestingFinalExam.Controllers.MathLogicController mathLogicController = new TestingFinalExam.Controllers.MathLogicController();

            var result = mathLogicController.addNumbers(a, b, c);

            //bool result = Viewbag.addResult;
            Assert.AreEqual(false, result);

        }

        [TestMethod]
        public void mulNumbersTestSucced()
        {
            int a = 2;
            int b = 1;
            int c = 1;

            TestingFinalExam.Controllers.MathLogicController mathLogicController = new TestingFinalExam.Controllers.MathLogicController();

            var result = mathLogicController.mulNumbers(a, b, c);

            //bool result = Viewbag.addResult;
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void mulNumbersTestFail()
        {
            int a = 1;
            int b = 1;
            int c = 1;

            TestingFinalExam.Controllers.MathLogicController mathLogicController = new TestingFinalExam.Controllers.MathLogicController();

            var result = mathLogicController.mulNumbers(a, b, c);

            //bool result = Viewbag.addResult;
            Assert.AreEqual(false, result);

        }

        [TestMethod]
        public void subNumbersTestSucced()
        {
            int a = 0;
            int b = 1;
            int c = 1;

            TestingFinalExam.Controllers.MathLogicController mathLogicController = new TestingFinalExam.Controllers.MathLogicController();

            var result = mathLogicController.subNumbers(a, b, c);

            //bool result = Viewbag.addResult;
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void subNumbersTestFail()
        {
            int a = 1;
            int b = 1;
            int c = 1;

            TestingFinalExam.Controllers.MathLogicController mathLogicController = new TestingFinalExam.Controllers.MathLogicController();

            var result = mathLogicController.subNumbers(a, b, c);

            //bool result = Viewbag.addResult;
            Assert.AreEqual(false, result);

        }

        [TestMethod]
        public void divNumbersTestSucced()
        {
            int a = 1;
            int b = 1;
            int c = 1;

            TestingFinalExam.Controllers.MathLogicController mathLogicController = new TestingFinalExam.Controllers.MathLogicController();

            var result = mathLogicController.addNumbers(a, b, c);

            //bool result = Viewbag.addResult;
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void divNumbersTestFail()
        {
            int a = 0;
            int b = 1;
            int c = 1;

            TestingFinalExam.Controllers.MathLogicController mathLogicController = new TestingFinalExam.Controllers.MathLogicController();

            var result = mathLogicController.addNumbers(a, b, c);

            //bool result = Viewbag.addResult;
            Assert.AreEqual(false, result);

        }

        [TestMethod]
        public void piSymbolTestSucced()
        {
            string a = "Test";
            string b = "Test";
            

            TestingFinalExam.Controllers.MathLogicController mathLogicController = new TestingFinalExam.Controllers.MathLogicController();

            var result = mathLogicController.piSymbol(a, b);

            //bool result = Viewbag.addResult;
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void piSymbolTestFail()
        {
            string a = "Test";
            string b = "Test1";


            TestingFinalExam.Controllers.MathLogicController mathLogicController = new TestingFinalExam.Controllers.MathLogicController();

            var result = mathLogicController.piSymbol(a, b);

            //bool result = Viewbag.addResult;
            Assert.AreEqual(false, result);

        }
    }
}

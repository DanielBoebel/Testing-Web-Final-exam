using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingFinalExam;


namespace TestClass
{
    [TestClass]
    public class TestClass
    {
        TestingFinalExam.Controllers.MathLogicController mathLogicController = new TestingFinalExam.Controllers.MathLogicController();
        TestingFinalExam.Controllers.HomeController homeController = new TestingFinalExam.Controllers.HomeController();

        [TestMethod]
        public void multiplyNumbersTestSucced()
        {
            int a = 1;
            int b = 1;
            int c = 1;
            var result = mathLogicController.multiplyNumbers(a, b, c);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void multiplyNumbersTestFail()
        {
            int a = 2;
            int b = 1;
            int c = 1;
            var result = mathLogicController.multiplyNumbers(a, b, c);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void addNumbersTestSucced()
        {
            int a = 2;
            int b = 1;
            int c = 1;
            var result = mathLogicController.addNumbers(a, b, c);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void addNumbersTestFail()
        {
            int a = 1;
            int b = 1;
            int c = 1;
            var result = mathLogicController.addNumbers(a, b, c);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void subNumbersTestSucced()
        {
            int a = 0;
            int b = 1;
            int c = 1;
            var result = mathLogicController.subNumbers(a, b, c);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void subNumbersTestFail()
        {
            int a = 1;
            int b = 1;
            int c = 1;
            var result = mathLogicController.subNumbers(a, b, c);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void divNumbersTestSucced()
        {
            int a = 1;
            int b = 1;
            int c = 1;
            var result = mathLogicController.multiplyNumbers(a, b, c);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void divNumbersTestFail()
        {
            int a = 0;
            int b = 1;
            int c = 1;
            var result = mathLogicController.multiplyNumbers(a, b, c);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void piSymbolTestSucced()
        {
            string a = "Test";
            string b = "Test";           
            var result = mathLogicController.piSymbol(a, b);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void piSymbolTestFail()
        {
            string a = "Test";
            string b = "Test1";
            var result = mathLogicController.piSymbol(a, b);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void validateFirstnameTestSucced() {
            string testFirstname = "Test";
            var result = homeController.validateFirstname(testFirstname);
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void validateFirstnameTestFail()
        {
            string testFirstnameDigits = "Test123";
            string testFirstnameLength = "poiuytrewqasdfghjklop";
            string testFirstnameSymbol = "&test%&()";
            var resultLength = homeController.validateFirstname(testFirstnameLength);
            var resultDigits = homeController.validateFirstname(testFirstnameDigits);
            var resultSymbol = homeController.validateFirstname(testFirstnameSymbol);
            Assert.AreEqual("Your firstname needs to be less then 20 characters", resultLength);
            Assert.AreEqual("Your name can not contain digits", resultDigits);
        }

        [TestMethod]
        public void validateLastnameTestSucced()
        {
            string testLastname = "Test";
            var result = homeController.validateLastname(testLastname);
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void validateLastnameTestFail()
        {
            string testLastnameDigits = "Test123";
            string testLastnameLength = "poiuytrewqasdfghjklop";
            string testLastnameSymbol = "&test";
            var resultLength = homeController.validateLastname(testLastnameLength);
            var resultDigits = homeController.validateLastname(testLastnameDigits);
            var resultSymbol = homeController.validateLastname(testLastnameSymbol);
            Assert.AreEqual("Your lastname needs to be less then 20 characters", resultLength);
            Assert.AreEqual("Your lastname can not contain digits", resultDigits);
        }
    }
}

using NUnit.Framework;
using TestRegex;

namespace NUnitTestProject
{
    public class Tests
    {
        Program program ;

        [SetUp]
        public void Setup()
        {
            program = new Program();
        }

        [Test]
        public void Given_FirstName_Expecting_TrueResult()
        {
            bool result = program.FirstNameValidationNunitTest();
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Given_LastName_Expecting_TrueResult()
        {
            bool result = program.LastNameValidationNunitTest();
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Given_MobileNumber_Expecting_TrueResult()
        {
            bool result = program.MobileNumberValidationNunitTest();
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Given_PasswordRule4_Expecting_TrueResult()
        {
            bool result = program.PasswordRule4ValidationNunitTest();
            Assert.AreEqual(true, result);
        }

        [TestCase("abc@yahoo.com", true)]
        [TestCase("abc-100@yahoo.com,", true)]
        [TestCase("abc.100@yahoo.com", true)]
        [TestCase("abc111@abc.com,", true)]
        [TestCase("abc-100@abc.net,", true)]
        [TestCase("abc.100@abc.com.au", true)]
        [TestCase("abc@1.com,", true)]
        [TestCase("abc@gmail.com.com", true)]
        [TestCase("abc+100@gmail.com", true)]
        [TestCase("abc", false)]
        [TestCase("abc@.com.my", false)]
        [TestCase("abc123@gmail.a", false)]
        [TestCase("abc123@.com", false)]
        [TestCase("abc@.com.com", false)]
        [TestCase(".abc@abc.com", false)]
        [TestCase("abc()*@gmail.com", false)]
        [TestCase("abc@%*.com", false)]
        [TestCase("abc..2002@gmail.com", false)]
        [TestCase("abc.@gmail.com", false)]
        [TestCase("abc@abc@gmail.com", false)]
        [TestCase("abc@gmail.com.1a", false)]
        [TestCase("abc@gmail.com.aa.au", false)]
        public void Given_SampleEmails_Expecting_TrueResult(string sampleEmail, bool expectedResult)
        {
            bool result = program.EmailValidationNunitTest(sampleEmail);
            Assert.AreEqual(expectedResult, result);
        }


    }
}
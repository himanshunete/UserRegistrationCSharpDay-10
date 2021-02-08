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
        public void Given_EmailAddress_Expecting_TrueResult()
        {
            bool result = program.EmailAddressValidationNunitTest();
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


    }
}
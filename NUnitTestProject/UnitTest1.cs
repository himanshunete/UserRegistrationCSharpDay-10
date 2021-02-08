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
    }
}
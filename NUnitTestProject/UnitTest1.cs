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
        public void Test1()
        {
            bool result = program.FirstNameValidationTestForNunit();
            Assert.AreEqual(true, result);
        }
    }
}
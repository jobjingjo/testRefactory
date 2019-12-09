using NUnit.Framework;
using WebApplication.Services.Abstract;
using WebApplication.Services.Concrete;

namespace WebApplication.Services.Tests
{
    public class StringServiceTests
    {
        private IStringService _stringService;
        [SetUp]
        public void Setup()
        {
            _stringService =new StringService();
        }

        [TestCase("madam",true)]
        [TestCase("step on no pets",true)]
        [TestCase("book",false)]
        public void CanIdentifyPalindromes(string value, bool expected)
        {
            //Act
            var isPalindrome = _stringService.IsPalindrome(value);

            //Assert
            Assert.AreEqual(expected, isPalindrome);
        }

        [TestCase("welcome to control expert", "expert control to welcome")]
        public void ReverseWordsInSentence(string value, string expected)
        {
            //Act
            var isPalindrome = _stringService.ReverseWords(value);

            //Assert
            Assert.AreEqual(expected, isPalindrome);
        }
    }
}
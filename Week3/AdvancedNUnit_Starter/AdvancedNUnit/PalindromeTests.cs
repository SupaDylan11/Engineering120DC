using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace AdvancedNUnit
{
    public class PalindromeTests
    {
        
        [SetUp]
        public void Setup() { }

        [TestCase("Banana Ananab")]
        [TestCase("A Santa dog lived as a devil god at NASA")]
        [TestCase("Ada")]
        public void GivenAPalindrome_IsItPalendrome_ReturnTrue(string input)
        {
            Assert.That(Palindrome.IsItPalendrome(input), Is.EqualTo(true),
                "The IsItPalendrome(1) method is mistaking a palindrome for a non-palindrome!");
        }

        [TestCase("Nishant Mandal")]
        [TestCase("Bonafide")]
        public void GivenANonPalindrome_IsItPalendrome_ReturnFalse(string input)
        {
            Assert.That(Palindrome.IsItPalendrome(input), Is.EqualTo(false),
                "The IsItPalendrome(1) method is mistaking a non-palindrome for a palindrome!");
        }

        [Test]
        public void GivenASingleCharacterForString_IsItPalendrome_ReturnTrue()
        {
            Assert.That(Palindrome.IsItPalendrome("a"), Is.EqualTo(true), "There is an issue with the IsItPalendrome method");
        }

        [Test]
        public void GivenAnEmptyString_Throw_ArgumentException()
        {
            Assert.That(() => Palindrome.IsItPalendrome(""), Throws.TypeOf<ArgumentException>());
        }
        
    }
}


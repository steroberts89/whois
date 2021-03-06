﻿using NUnit.Framework;

namespace Whois.Extensions
{
    [TestFixture]
    public class StringExtensionsTest
    {
        [Test]
        public void TestSubStringEmptyString()
        {
            Assert.AreEqual(string.Empty, string.Empty.SubstringAfterChar("c"));
        }

        [Test]
        public void TestSubStringWithNonMatchingString()
        {
            Assert.AreEqual("banana", "banana".SubstringAfterChar("c"));
        }

        [Test]
        public void TestSubStringWithMatchingString()
        {
            Assert.AreEqual("ana", "banana".SubstringAfterChar("n"));
        }

        [Test]
        public void TestSubStringBeforeWithMatchingString()
        {
            Assert.AreEqual("ba", "banana".SubstringBeforeChar("n"));
        }
    }
}
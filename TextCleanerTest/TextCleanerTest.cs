using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextCleaner;

namespace TextCleanerTest
{
    [TestClass]
    public class TextCleanerTest
    {
        private TextCleanerUtils textCleaner = null;

        [TestInitialize]
        public void Init()
        {
            textCleaner = new TextCleanerUtils();
        }

        [TestMethod]
        public void RemoveDoubleSpaces_Null_Null()
        {
            string input = null;
            string output = textCleaner.RemoveDoubleSpaces(input);

            Assert.AreEqual(null, output);
        }

        [TestMethod]
        public void RemoveDoubleSpaces_EmptyString_EmptyString()
        {
            string input = string.Empty;
            string output = textCleaner.RemoveDoubleSpaces(input);

            Assert.AreEqual(string.Empty, output);
        }

        [TestMethod]
        public void RemoveDoubleSpaces_StringWithoutDoubleSpaces_StringWithoutDoubleSpaces()
        {
            string input = "Hello World";
            string output = textCleaner.RemoveDoubleSpaces(input);

            Assert.AreEqual(input, output);
        }

        [TestMethod]
        public void RemoveDoubleSpaces_StringWithDoubleSpaces_StringWithoutDoubleSpaces()
        {
            string input = "Hello  World";
            string output = textCleaner.RemoveDoubleSpaces(input);

            Assert.AreEqual("Hello World", output);
        }
    }
}

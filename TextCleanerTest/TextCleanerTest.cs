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

        [TestMethod]
        public void RemoveHtmlTags_Null_Null()
        {
            string input = null;
            string output = textCleaner.RemoveHtmlTags(input);

            Assert.AreEqual(null, output);
        }

        [TestMethod]
        public void RemoveHtmlTags_EmptyString_EmptyString()
        {
            string input = string.Empty;
            string output = textCleaner.RemoveHtmlTags(input);

            Assert.AreEqual(string.Empty, output);
        }

        [TestMethod]
        public void RemoveHtmlTags_StringWithoutTags_StringWithoutTags()
        {
            string input = "Hello World";
            string output = textCleaner.RemoveHtmlTags(input);

            Assert.AreEqual("Hello World", output);
        }

        [TestMethod]
        public void RemoveHtmlTags_StringWithTagsAtStart_StringWithoutTags()
        {
            string input = "<div>Hello World";
            string output = textCleaner.RemoveHtmlTags(input);

            Assert.AreEqual("Hello World", output);
        }

        [TestMethod]
        public void RemoveHtmlTags_StringWithTagsAtEnd_StringWithoutTags()
        {
            string input = "Hello World</div>";
            string output = textCleaner.RemoveHtmlTags(input);

            Assert.AreEqual("Hello World", output);
        }

        [TestMethod]
        public void RemoveHtmlTags_StringWithTwoTagsInDiferentPlaces_StringWithoutTags()
        {
            string input = "<div>Hello World</div>";
            string output = textCleaner.RemoveHtmlTags(input);

            Assert.AreEqual("Hello World", output);
        }

        [TestMethod]
        public void RemoveHtmlTags_StringWithTwoTagsInSequence_StringWithoutTags()
        {
            string input = "Hello <div><a> World";
            string output = textCleaner.RemoveHtmlTags(input);

            Assert.AreEqual("Hello  World", output);
        }

        [TestMethod]
        public void RemoveHtmlTags_StringWithTagWithAttribute_StringWithoutTags()
        {
            string input = "<div id='helloworld'>Hello World</div>";
            string output = textCleaner.RemoveHtmlTags(input);

            Assert.AreEqual("Hello World", output);
        }

        //Teste 1
        [TestMethod]
        public void RemoveExcessLineBreakers_Null_EmptyString()
        {
            string input = null;

            string output = textCleaner.RemoveExcessLineBreakers(input);

            Assert.AreEqual(string.Empty, output);
        }

        //Teste 2
        [TestMethod]
        public void RemoveExcessLineBreakers_TextWithTwoLineBreakers_TextWithSimpleLineBreaker()
        {
            string input = "Hello World!\r\n\r\nMy name is Lucas!";

            string output = textCleaner.RemoveExcessLineBreakers(input);

            Assert.AreEqual("Hello World!\r\nMy name is Lucas!", output);
        }

        //Teste 3
        [TestMethod]
        public void RemoveExcessLineBreakers_TextWithThreeLineBreakers_TextWithSimpleLineBreaker()
        {
            string input = "Hello World!\r\n\r\n\r\nMy name is Lucas!";

            string output = textCleaner.RemoveExcessLineBreakers(input);

            Assert.AreEqual("Hello World!\r\nMy name is Lucas!", output);
        }
    }
}

using System;
using Xunit;
using Extensions.BR;

namespace Extensions.MV.UnitTests
{
    public class CapitalizeSentenceTest
    {
        [Fact]
        public void TestCapitalizeSentence_SingleLetter()
        {
            //Arrange
            var testSentence = "teste de s test";

            //Act
            var testCapitalized = testSentence.CapitalizeSentence();

            //Assert
            Assert.Equal("Teste De S Test", testCapitalized);
        }

        [Fact]
        public void TestCapitalizeSentence_SmallCase()
        {
            //Arrange
            var testSentence = "teste de teste ";

            //Act
            var testCapitalized = testSentence.CapitalizeSentence();

            //Assert
            Assert.Equal("Teste De Teste", testCapitalized);
        }

        [Fact]
        public void TestCapitalizeSentence_SmallCaseWords()
        {
            //Arrange
            var smallCaseWords = new string[]{ "teste", "of" };
            var testSentence = "teste de teste of test";

            //Act
            var testCapitalized = testSentence.CapitalizeSentence(wordsLowerCase: smallCaseWords);

            //Assert
            Assert.Equal("teste De teste of Test", testCapitalized);
        }

        [Fact]
        public void TestCapitalizeSentence_UpperCaseWords()
        {
            //Arrange
            var upperCaseWords = new string[]{ "teste", "of" };
            var testSentence = "teste de teste of testof";

            //Act
            var testCapitalized = testSentence.CapitalizeSentence(wordsUpperCase: upperCaseWords);

            //Assert
            Assert.Equal("TESTE De TESTE OF Testof", testCapitalized);
        }

        [Fact]
        public void TestCapitalizarFrase_SingleLetter()
        {
            //Arrange
            var testSentence = "TESTE DE T TESTE";

            //Act
            var testCapitalized = testSentence.CapitalizarFrase();

            //Assert
            Assert.Equal("Teste de T Teste", testCapitalized);
        }

        [Fact]
        public void TestCapitalizarFrase_ValorNull()
        {
            //Arrange
            string testSentence = null;

            //Act
            var testCapitalized = testSentence.CapitalizarFrase();

            //Assert
            Assert.True(testCapitalized == null);
        }

        [Fact]
        public void TestCapitalizarFrase_StringVazia()
        {
            //Arrange
            string testSentence = "";

            //Act
            var testCapitalized = testSentence.CapitalizarFrase();

            //Assert
            Assert.True(testCapitalized == "");
        }

        [Fact]
        public void TestRemoveNonAlfanumeric()
        {
            //Arrange
            var testText = "1234213_123423";

            //Act
            var alteredText = testText.RemoveNonAlfanumeric();

            //Assert
            Assert.Equal("1234213123423", alteredText);
        }
    }
}

using Xunit;

namespace Extensions.MV.UnitTests
{
    public class StringExtensionTest
    {
        [Fact]
        public void TestIsValidEmail_Ok()
        {
            //Arrange
            var email = "test@a.com";

            //Act
            var isValidEmail = email.IsValidEmail();

            //Assert
            Assert.True(isValidEmail);
        }

        [Fact]
        public void TestIsValidEmail_WithoutDot()
        {
            //Arrange
            var email = "test@acom";

            //Act
            var isValidEmail = email.IsValidEmail();

            //Assert
            Assert.True(isValidEmail);
        }

        [Fact]
        public void TestIsValidEmail_WithoutAt()
        {
            //Arrange
            var email = "test_a.com";

            //Act
            var isValidEmail = email.IsValidEmail();

            //Assert
            Assert.False(isValidEmail);
        }

        [Fact]
        public void TestIsValidEmail_Null()
        {
            //Arrange
            var email = " ";

            //Act
            var isValidEmail = email.IsValidEmail();

            //Assert
            Assert.False(isValidEmail);
        }
    }
}
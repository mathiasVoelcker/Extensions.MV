using Xunit;

namespace Extensions.MV.UnitTests
{
    public class EnumExtensionsTest
    {
        [Fact]
        public void TestEnumContains_OnlyOneEnum()
        {
            //Arrange
            var enumValue = TestEnum.value1;
            var enumComparison = TestEnum.value1;

            //Act
            var valueContainsComparison = enumValue.Contains(enumComparison);

            //Assert
            Assert.True(valueContainsComparison);
        }

        [Fact]
        public void TestEnumContains_MoreThanOneEnum()
        {
            //Arrange
            var enumValue = TestEnum.value1 | TestEnum.value2 | TestEnum.value4;
            var enumComparison = TestEnum.value2;

            //Act
            var valueContainsComparison = enumValue.Contains(enumComparison);

            //Assert
            Assert.True(valueContainsComparison);
        }

        [Fact]
        public void TestEnumContains_MoreThanOneEnumInComparrisons()
        {
            //Arrange
            var enumValue = TestEnum.value1 | TestEnum.value2 | TestEnum.value4;
            var enumComparison = TestEnum.value1 | TestEnum.value2;

            //Act
            var valueContainsComparison = enumValue.Contains(enumComparison);

            //Assert
            Assert.True(valueContainsComparison);
        }

        [Fact]
        public void TestEnumContains_NotEqual()
        {
            //Arrange
            var enumValue = TestEnum.value1 | TestEnum.value2;
            var enumComparison = TestEnum.value4;

            //Act
            var valueContainsComparison = enumValue.Contains(enumComparison);

            //Assert
            Assert.False(valueContainsComparison);
        }

        [Fact]
        public void TestEnumContains_MoreThanOneEnumNotEqual()
        {
            //Arrange
            var enumValue = TestEnum.value1 | TestEnum.value2;
            var enumComparison = TestEnum.value2 | TestEnum.value4;

            //Act
            var valueContainsComparison = enumValue.Contains(enumComparison);

            //Assert
            Assert.True(valueContainsComparison);
        }

        [Fact]
        public void TestEnumContainsAll_OnlyOneEnum()
        {
            //Arrange
            var enumValue = TestEnum.value1;
            var enumComparison = TestEnum.value1;

            //Act
            var valueContainsComparison = enumValue.ContainsAll(enumComparison);

            //Assert
            Assert.True(valueContainsComparison);
        }

        [Fact]
        public void TestEnumContainsAll_MoreThanOneEnum()
        {
            //Arrange
            var enumValue = TestEnum.value1 | TestEnum.value2 | TestEnum.value4;
            var enumComparison = TestEnum.value2;

            //Act
            var valueContainsComparison = enumValue.ContainsAll(enumComparison);

            //Assert
            Assert.True(valueContainsComparison);
        }

        [Fact]
        public void TestEnumContainsAll_MoreThanOneEnumInComparrisons()
        {
            //Arrange
            var enumValue = TestEnum.value1 | TestEnum.value2 | TestEnum.value4;
            var enumComparison = TestEnum.value1 | TestEnum.value2;

            //Act
            var valueContainsComparison = enumValue.ContainsAll(enumComparison);

            //Assert
            Assert.True(valueContainsComparison);
        }

        [Fact]
        public void TestEnumContainsAll_NotEqual()
        {
            //Arrange
            var enumValue = TestEnum.value1 | TestEnum.value2;
            var enumComparison = TestEnum.value4;

            //Act
            var valueContainsComparison = enumValue.ContainsAll(enumComparison);

            //Assert
            Assert.False(valueContainsComparison);
        }

        [Fact]
        public void TestEnumContainsAll_MoreThanOneEnumNotEqual()
        {
            //Arrange
            var enumValue = TestEnum.value1 | TestEnum.value2;
            var enumComparison = TestEnum.value2 | TestEnum.value4;

            //Act
            var valueContainsComparison = enumValue.ContainsAll(enumComparison);

            //Assert
            Assert.False(valueContainsComparison);
        }

    }

    public enum TestEnum {
        value1 = 1,
        value2 = 2,
        value4 = 4,
        value8 = 8
    }
}
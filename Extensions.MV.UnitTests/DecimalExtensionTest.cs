using Extensions.BR;
using Xunit;

namespace Extensions.MV.UnitTests
{
    public class DecimalExtensionTest
    {
        [Fact]
        public void TestValorMonetario_Positive() {
            //Arrange
            var number = 5m;

            //Act
            var valorMonetario = number.ValorMonetario();

            //Assert
            Assert.Equal("R$ 5,00", valorMonetario);
        }

        [Fact]
        public void TestValorMonetario_Negativo() {
            //Arrange
            var number = -5m;

            //Act
            var valorMonetario = number.ValorMonetario();

            //Assert
            Assert.Equal("(R$ 5,00)", valorMonetario);
        }
    }
}
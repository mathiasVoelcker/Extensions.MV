using System;
using Xunit;
using Extensions.BR;

namespace Extensions.MV.UnitTests
{
    public class TimeSpanExtensionTest
    {
        [Fact]
        public void TestToStringShort_Hours()
        {
            //Arrange
            var dateNow = DateTime.Now;
            var date = dateNow.AddHours(-5);
            var time = DateTime.Now - date;

            //Act
            var test = time.ToStringShort();

            //Assert
            Assert.Equal("5h", test);
        }

        [Fact]
        public void TestToStringShort_Days()
        {
            //Arrange
            var dateNow = DateTime.Now;
            var date = dateNow.AddDays(-3);
            var time = DateTime.Now - date;

            //Act
            var test = time.ToStringShort();

            //Assert
            Assert.Equal("3 D", test);
        }

        [Fact]
        public void TestToStringShort_OneWeek()
        {
            //Arrange
            var dateNow = DateTime.Now;
            var date = dateNow.AddDays(-10);
            var time = DateTime.Now - date;

            //Act
            var test = time.ToStringShort();

            //Assert
            Assert.Equal("1 W", test);
        }

        [Fact]
        public void TestToStringShort_TwoWeek()
        {
            //Arrange
            var dateNow = DateTime.Now;
            var date = dateNow.AddDays(-15);
            var time = DateTime.Now - date;

            //Act
            var test = time.ToStringShort();

            //Assert
            Assert.Equal("2 W", test);
        }

        [Fact]
        public void TestTextoCurto_Recente()
        {
            //Arrange
            var dateNow = DateTime.Now;
            var date = dateNow.AddMinutes(-5);
            var time = DateTime.Now - date;

            //Act
            var test = time.TextoCurto();

            //Assert
            Assert.Equal("Recente", test);
        }

        [Fact]
        public void TestTextoCurto_Recente_TextoCustomizado()
        {
            //Arrange
            var dateNow = DateTime.Now;
            var date = dateNow.AddMinutes(-5);
            var time = DateTime.Now - date;

            //Act
            var test = time.TextoCurto("A menos de uma hora");

            //Assert
            Assert.Equal("A menos de uma hora", test);
        }

        [Fact]
        public void TestTextoCurto_Horas()
        {
            //Arrange
            var dateNow = DateTime.Now;
            var date = dateNow.AddHours(-5);
            var time = DateTime.Now - date;

            //Act
            var test = time.TextoCurto();

            //Assert
            Assert.Equal("5h", test);
        }

        [Fact]
        public void TestTextoCurto_Dias()
        {
            //Arrange
            var dateNow = DateTime.Now;
            var date = dateNow.AddDays(-3);
            var time = DateTime.Now - date;

            //Act
            var test = time.TextoCurto();

            //Assert
            Assert.Equal("3 D", test);
        }

        [Fact]
        public void TestTextoCurto_UmaSemana()
        {
            //Arrange
            var dateNow = DateTime.Now;
            var date = dateNow.AddDays(-10);
            var time = DateTime.Now - date;

            //Act
            var test = time.TextoCurto();

            //Assert
            Assert.Equal("1 Sem", test);
        }

        [Fact]
        public void TestTextoCurto_DuasSemanas()
        {
            //Arrange
            var dateNow = DateTime.Now;
            var date = dateNow.AddDays(-15);
            var time = DateTime.Now - date;

            //Act
            var test = time.TextoCurto();

            //Assert
            Assert.Equal("2 Sem", test);
        }
    }
}
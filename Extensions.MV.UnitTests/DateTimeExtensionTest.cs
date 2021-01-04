using Xunit;

using System;
using Xunit;

namespace Extensions.MV.UnitTests
{
    public class DateTimeExtensionTest
    {
        [Fact]
        public void TestLastDayOfMonth_January() {
            //Arrange
            var date = new DateTime(2019, 1, 20);

            //Act
            var lastDayOfMonthDate = date.GetLastDayOfMonth();

            //Assert
            Assert.Equal(31, lastDayOfMonthDate.Day);
            Assert.Equal(lastDayOfMonthDate, new DateTime(2019, 1, 31));
        }

        [Fact]
        public void TestLastDayOfMonth_December() {
            //Arrange
            var date = new DateTime(2019, 12, 20);

            //Act
            var lastDayOfMonthDate = date.GetLastDayOfMonth();

            //Assert
            Assert.Equal(31, lastDayOfMonthDate.Day);
            Assert.Equal(lastDayOfMonthDate, new DateTime(2019, 12, 31));
        }

        [Fact]
        public void TestLastDayOfMonth_July() {
            //Arrange
            var date = new DateTime(2019, 7, 1);

            //Act
            var lastDayOfMonthDate = date.GetLastDayOfMonth();

            //Assert
            Assert.Equal(31, lastDayOfMonthDate.Day);
            Assert.Equal(lastDayOfMonthDate, new DateTime(2019, 7, 31));
        }

        [Fact]
        public void TestLastDayOfMonth_LeapYear() {
            //Arrange
            var date = new DateTime(2020, 2, 20);

            //Act
            var lastDayOfMonthDate = date.GetLastDayOfMonth();

            //Assert
            Assert.Equal(29, lastDayOfMonthDate.Day);
            Assert.Equal(lastDayOfMonthDate, new DateTime(2020, 2, 29));
        }

        [Fact]
        public void TestLastDayOfMonth_February() {
            //Arrange
            var date = new DateTime(2019, 2, 20);

            //Act
            var lastDayOfMonthDate = date.GetLastDayOfMonth();

            //Assert
            Assert.Equal(28, lastDayOfMonthDate.Day);
            Assert.Equal(lastDayOfMonthDate, new DateTime(2019, 2, 28));
        }
    }
}
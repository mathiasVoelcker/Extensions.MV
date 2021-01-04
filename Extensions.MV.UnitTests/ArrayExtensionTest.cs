using Xunit;

namespace Extensions.MV.UnitTests
{
    public class ArrayExtensionTest
    {
        [Fact]
        public void TestAdd()
        {
            var array = new int[3] { 1, 2, 3};

            array = array.Add(4);

            Assert.Equal(1, array[0]);
            Assert.Equal(4, array[3]);
        }

        [Fact]
        public void TestAddInStart()
        {
            var array = new int[3] { 1, 2, 3};

            array = array.AddInStart(4);

            Assert.Equal(4, array[0]);
            Assert.Equal(3, array[3]);
        }

        [Fact]
        public void TestAt_InStart()
        {
            var array = new int[3] { 1, 2, 3};

            array = array.AddAt(4, 0);

            Assert.Equal(4, array[0]);
            Assert.Equal(3, array[3]);
        }

        [Fact]
        public void TestAt_InMiddle()
        {
            var array = new int[3] { 1, 2, 3};

            array = array.AddAt(4, 2);

            Assert.Equal(1, array[0]);
            Assert.Equal(4, array[2]);
            Assert.Equal(3, array[3]);
        }

        [Fact]
        public void TestAt_InEnd()
        {
            var array = new int[3] { 1, 2, 3};

            array = array.AddAt(4, 3);

            Assert.Equal(1, array[0]);
            Assert.Equal(3, array[2]);
            Assert.Equal(4, array[3]);
        }
    }
}
using System.Collections.Generic;
using Xunit;

namespace Extensions.MV.UnitTests
{
    public class ListExtensionTest
    {
        [Fact]
        public void TestAreEqualElement_WithFunc_SameElem()
        {
            //Arrange
            var el1 = new TestElement(1, "test 1");
            var el2 = new TestElement(2, "test 2");
            var el3 = new TestElement(3, "test 3");
            var el4 = new TestElement(1, "test 4");
            var list1 = new List<TestElement> { el1, el2 };
            var list2 = new List<TestElement> { el3, el4 };

            //Act
            var areTheSame = list1.AnyEqualElement(list2, (x, y) => x.Id == y.Id);
            
            //Assert
            Assert.Equal(true, areTheSame);
        }

        [Fact]
        public void TestAreEqualElement_WithFunc_NoEqualElem()
        {
            //Arrange
            var el1 = new TestElement(1, "test 1");
            var el2 = new TestElement(2, "test 2");
            var el3 = new TestElement(3, "test 3");
            var el4 = new TestElement(4, "test 4");
            var list1 = new List<TestElement> { el1, el2 };
            var list2 = new List<TestElement> { el3, el4 };

            //Act
            var areTheSame = list1.AnyEqualElement(list2, (x, y) => x.Id == y.Id);
            
            //Assert
            Assert.Equal(false, areTheSame);
        }

        [Fact]
        public void TestAreEqualElement_WithFunc_SameElemString()
        {
            //Arrange
            var el1 = new TestElement(1, "test 1");
            var el2 = new TestElement(2, "test 2");
            var el3 = new TestElement(3, "test 3");
            var el4 = new TestElement(4, "test 1");
            var list1 = new List<TestElement> { el1, el2 };
            var list2 = new List<TestElement> { el3, el4 };

            //Act
            var areTheSame = list1.AnyEqualElement(list2, (x, y) => x.Name == y.Name);
            
            //Assert
            Assert.Equal(true, areTheSame);
        }

        [Fact]
        public void TestAreEqualElement_NoFunc_AllDiffIds()
        {
            //Arrange
            var el1 = new TestElement(1, "test 1");
            var el2 = new TestElement(2, "test 2");
            var el3 = new TestElement(3, "test 3");
            var el4 = new TestElement(4, "test 1");
            var list1 = new List<TestElement> { el1, el2 };
            var list2 = new List<TestElement> { el3, el4 };

            //Act
            var areTheSame = list1.AnyEqualElement(list2);
            
            //Assert
            Assert.Equal(false, areTheSame);
        }

        [Fact]
        public void TestAreEqualElement_NoFunc_SameIdS()
        {
            //Arrange
            var el1 = new TestElement(1, "test 1");
            var el2 = new TestElement(2, "test 2");
            var el3 = new TestElement(3, "test 3");
            var el4 = new TestElement(1, "test 4");
            var list1 = new List<TestElement> { el1, el2 };
            var list2 = new List<TestElement> { el3, el4 };

            //Act
            var areTheSame = list1.AnyEqualElement(list2);
            
            //Assert
            Assert.Equal(true, areTheSame);
        }
    }

    public class TestElement 
    {
        public TestElement(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is TestElement)) return false;

            TestElement espacialidadeAComparar = (TestElement)obj;

            return Id == espacialidadeAComparar.Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
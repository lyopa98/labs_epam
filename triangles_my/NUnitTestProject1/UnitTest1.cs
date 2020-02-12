using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void Test1()
        {
            Assert.AreEqual(ClassLibrary1.Class1.IsTriangle(1, 1, 1), true);
        }

        [Test]
        public void IsTriangleRightTest()
        {
            Assert.AreEqual(ClassLibrary1.Class1.IsTriangle(5, 8, 10), true);
        }

        [Test]
        public void IsTriangleIsoscelesTest()
        {
            Assert.AreEqual(ClassLibrary1.Class1.IsTriangle(2, 2, 3), true);
        }

        [Test]
        public void IsTriangleAllSidesNullTest()
        {
            Assert.AreEqual(ClassLibrary1.Class1.IsTriangle(0, 0, 0), false);
        }

        [Test]
        public void IsTriangleBadTest()
        {
            Assert.AreEqual(ClassLibrary1.Class1.IsTriangle(1, 4, 7), false);
        }

        [Test]
        public void IsTriangleGoodTest()
        {
            Assert.AreEqual(ClassLibrary1.Class1.IsTriangle(4, 5, 6), true);
        }

        [Test]
        public void IsTriangleOneBadSideTest()
        {
            Assert.AreEqual(ClassLibrary1.Class1.IsTriangle(4, -5, 6), false);
        }

        [Test]
        public void IsTriangleTwoBadSidesGoodTest()
        {
            Assert.AreEqual(ClassLibrary1.Class1.IsTriangle(-4, -5, 6), false);
        }

        [Test]
        public void IsTriangleThreeBadSidesGoodTest()
        {
            Assert.AreEqual(ClassLibrary1.Class1.IsTriangle(-4, -5, -6), false);
        }

        [Test]
        public void IsTriangleDoubleGoodTest()
        {
            Assert.AreEqual(ClassLibrary1.Class1.IsTriangle(2.5, 3.5, 4.5), true);
        }
    }
}
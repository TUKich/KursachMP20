using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //arrange
            int[] col = { 100, 200, 300 };

            int expected = 600;

            //act
            int actual = 0;
            for (int i = 0; i < col.Length; i++)
            {
                actual += col[i];
            }

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
using CommitAndConquer;
using FluentAssertions;

namespace CommitAndConquerTests
{
    public class TwoSumTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            var numbers = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var expected = new int[] { 0, 1 };

            //Act
            var result = TwoSum.Execute_TwoLoops(numbers, target);

            //Assert
            result.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Test2()
        {
            //Arrange
            var numbers = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var expected = new int[] { 0, 1 };

            //Act
            var result = TwoSum.Execute_OneLoop(numbers, target);

            //Assert
            result.Should().BeEquivalentTo(expected);
        }
    }
}
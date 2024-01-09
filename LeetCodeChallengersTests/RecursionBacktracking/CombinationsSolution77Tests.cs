using FluentAssertions;
using LeetCodeChallengers.RecursionBacktracking;

namespace LeetCodeChallengersTests.RecursionBacktracking
{
    public  class CombinationsSolution77Tests
    {
        private CombinationsSolution77 sut = new CombinationsSolution77();

        [Fact]
        public void Test1()
        {
            var result = sut.Combine(4, 2);
            result.Should().BeEquivalentTo(new List<IList<int>>
            {
                new List<int>()
                {
                    1, 2,
                },
                new List<int>()
                {
                    1, 3,
                },
                new List<int>()
                {
                    1, 4,
                },
                new List<int>()
                {
                    2, 3,
                },
                new List<int>()
                {
                    2, 4,
                },
                new List<int>()
                {
                    3, 4,
                },
            });
        }


        [Fact]
        public void Test2()
        {
            var result = sut.Combine(1, 1);
            result.Should().BeEquivalentTo(new List<IList<int>>
            {
                new List<int>()
                {
                    1,
                },
            });
        }
    }
}

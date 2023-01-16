using FluentAssertions;
using LeetCodeChallengers.RecursionBacktracking;

namespace LeetCodeChallengersTests.RecursionBacktracking;

public class CombinationSumIISolution40Tests
{
    private CombinationSumIISolution40 sut = new CombinationSumIISolution40();

    [Fact]
    public void Test1()
    {
        var result = sut.CombinationSum2(new int[] { 10, 1, 2, 7, 6, 1, 5 }, 8);
        result.Should().BeEquivalentTo(new List<IList<int>>
        {
            new List<int> { 1, 1, 6 },
            new List<int> { 1, 2, 5 },
            new List<int> { 1, 7 },
            new List<int> { 2, 6 }
        });
    }

    [Fact]
    public void Test2()
    {
        var result = sut.CombinationSum2(new int[] { 2, 5, 2, 1, 2 }, 5);
        result.Should().BeEquivalentTo(new List<IList<int>>
        {
            new List<int> { 1, 2, 2 },
            new List<int> { 5 }
        });
    }
}

using FluentAssertions;
using LeetCodeChallengers.RecursionBacktracking;

namespace LeetCodeChallengersTests.RecursionBacktracking;

public class CombinationSumSolution39Tests
{
    private CombinationSumSolution39 sut = new CombinationSumSolution39();

    [Fact]
    public void Test1()
    {
        var result = sut.CombinationSum(new int[] { 2, 3, 7, 9 }, 7);
        result.Should().BeEquivalentTo(new List<IList<int>>
        {
            new List<int> { 2, 2, 3 },
            new List<int> { 7 }
        });
    }

    [Fact]
    public void Test2()
    {
        var result = sut.CombinationSum(new int[] { 2, 3, 5 }, 8);
        result.Should().BeEquivalentTo(new List<IList<int>>
        {
            new List<int> { 2, 2, 2, 2 },
            new List<int> { 2, 3, 3 },
            new List<int> { 3, 5 }
        });
    }

    [Fact]
    public void Test3()
    {
        var result = sut.CombinationSum(new int[] { 2 }, 1);
        result.Should().BeEquivalentTo(new List<IList<int>>());
    }
}

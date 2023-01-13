using FluentAssertions;
using LeetCodeChallengers.RecursionBacktracking;

namespace LeetCodeChallengersTests.RecursionBacktracking;

public class PermutationsIISolution47Tests
{
    private PermutationsIISolution47 sut = new PermutationsIISolution47();

    [Fact]
    public void Test1()
    {
        var result = sut.PermuteUnique(new int[] { 1, 1, 2 });
        result.Should().BeEquivalentTo(new List<IList<int>>()
        {
            new List<int>() { 1, 1, 2 },
            new List<int>() { 1, 2, 1 },
            new List<int>() { 2, 1, 1 }
        });
    }



    [Fact]
    public void Test2()
    {
        var result = sut.PermuteUnique(new int[] { 1, 2, 3 });
        result.Should().BeEquivalentTo(new List<IList<int>>()
        {
            new List<int>() { 1, 2, 3 },
            new List<int>() { 1, 3, 2 },
            new List<int>() { 2, 1, 3 },
            new List<int>() { 2, 3, 1 },
            new List<int>() { 3, 1, 2 },
            new List<int>() { 3, 2, 1 }
        });
    }
}

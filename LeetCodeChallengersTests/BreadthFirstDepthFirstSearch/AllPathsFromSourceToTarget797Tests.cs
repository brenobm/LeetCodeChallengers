using FluentAssertions;
using LeetCodeChallengers.BreadthFirstDepthFirstSearch;

namespace LeetCodeChallengersTests.BreadthFirstDepthFirstSearch;

public class AllPathsFromSourceToTarget797Tests
{
    private AllPathsFromSourceToTarget797 sut = new AllPathsFromSourceToTarget797();

    [Fact]
    public void Test1()
    {
        var result = sut.AllPathsSourceTarget(
            new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3 },
                new int[] { 3 },
                new int[] { }
            }
        );

        result.Should().BeEquivalentTo(
            new List<List<int>>
            {
                new List<int> { 0, 1, 3 },
                new List<int> { 0, 2, 3 }
            });
    }

    [Fact]
    public void Test2()
    {
        var result = sut.AllPathsSourceTarget(
            new int[][]
            {
                new int[] { 4, 3, 1 },
                new int[] { 3, 2, 4 },
                new int[] { 3 },
                new int[] { 4 },
                new int[] { }
            }
        );

        result.Should().BeEquivalentTo(
            new List<List<int>>
            {
                new List<int> { 0, 4 },
                new List<int> { 0, 3, 4 },
                new List<int> { 0, 1, 3, 4 },
                new List<int> { 0, 1, 2, 3, 4 },
                new List<int> { 0, 1, 4 }
            });
    }
}

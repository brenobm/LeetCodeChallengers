using FluentAssertions;
using LeetCodeChallengers.BreadthFirstDepthFirstSearch;

namespace LeetCodeChallengersTests.BreadthFirstDepthFirstSearch;

public class AllPathsFromSourceToTarget797Tests
{
    private AllPathsFromSourceToTarget797 sut = new AllPathsFromSourceToTarget797();

    public static IEnumerable<object[]> GetTestData =>
    new List<object[]>
    {
            new object[] { 
                new int[][]
                {
                    [1, 2],
                    [3],
                    [3],
                    []
                },
                new List<List<int>>
                {
                    new() { 0, 1, 3 },
                    new() { 0, 2, 3 }
            }},
            new object[] {
                new int[][]
                {
                    [4, 3, 1],
                    [3, 2, 4],
                    [3],
                    [4],
                    []
                },
                new List<List<int>>
                {
                    new() { 0, 4 },
                    new() { 0, 3, 4 },
                    new() { 0, 1, 3, 4 },
                    new() { 0, 1, 2, 3, 4 },
                    new() { 0, 1, 4 }
                }
            },
    };


    [Theory, MemberData(nameof(GetTestData))]
    public void Test(int[][] input, List<List<int>> output)
    {
        var result = sut.AllPathsSourceTarget(input);

        result.Should().BeEquivalentTo(output);
    }
}

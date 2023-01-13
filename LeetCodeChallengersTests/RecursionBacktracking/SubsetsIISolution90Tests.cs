using FluentAssertions;
using LeetCodeChallengers.RecursionBacktracking;

namespace LeetCodeChallengersTests.RecursionBacktracking;

public class SubsetsIISolution90Tests
{
    private SubsetsIISolution90 sut = new SubsetsIISolution90();

    [Fact]
    public void Test1()
    {
        var subsets = sut.SubsetsWithDup(new int[] { 1, 2, 2 });
        subsets.Should().BeEquivalentTo(
            new List<IList<int>>() {
                new List<int> { },
                new List<int> { 1 },
                new List<int> { 1, 2 },
                new List<int> { 1, 2, 2 },
                new List<int> { 2 },
                new List<int> { 2, 2 }
            }
        );
    }

    [Fact]
    public void Test2()
    {
        var subsets = sut.SubsetsWithDup(new int[] { 0 });
        subsets.Should().BeEquivalentTo(
            new List<IList<int>>() {
                new List<int> { },
                new List<int> { 0 }
            }
        );
    }
}

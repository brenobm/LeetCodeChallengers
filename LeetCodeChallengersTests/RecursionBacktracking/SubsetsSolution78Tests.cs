using FluentAssertions;
using LeetCodeChallengers.RecursionBacktracking;

namespace LeetCodeChallengersTests.RecursionBacktracking;

public class SubsetsSolution78Tests
{
    private SubsetsSolution78 sut = new SubsetsSolution78();

    [Fact]
    public void Test1()
    {
        var subsets = sut.Subsets(new int[] { 1, 2, 3 });
        subsets.Should().BeEquivalentTo(
            new List<IList<int>>() {
                new List<int> { },
                new List<int> { 1 },
                new List<int> { 2 },
                new List<int> { 1, 2 },
                new List<int> { 3 },
                new List<int> { 1, 3 },
                new List<int> { 2, 3 },
                new List<int> { 1, 2, 3 }
            }
        );
    }

    [Fact]
    public void Test2()
    {
        var subsets = sut.Subsets(new int[] { 0 });
        subsets.Should().BeEquivalentTo(
            new List<IList<int>>() {
                new List<int> { },
                new List<int> { 0 }
            }
        );
    }
}

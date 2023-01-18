using FluentAssertions;
using LeetCodeChallengers.DynamicProgramming;

namespace LeetCodeChallengersTests.DynamicProgramming;

public class UniquePathsSolution62Tests
{
    private UniquePathsSolution62 sut = new UniquePathsSolution62();

    [Fact]
    public void Test1()
    {
        var result = sut.UniquePaths(3, 7);
        result.Should().Be(28);
    }

    [Fact]
    public void Test2()
    {
        var result = sut.UniquePaths(3, 2);
        result.Should().Be(3);
    }
}

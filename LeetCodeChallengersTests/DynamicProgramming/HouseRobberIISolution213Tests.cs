using FluentAssertions;
using LeetCodeChallengers.DynamicProgramming;

namespace LeetCodeChallengersTests.DynamicProgramming;

public class HouseRobberIISolution213Tests
{
    private HouseRobberIISolution213 sut = new HouseRobberIISolution213();

    [Fact]
    public void Test1()
    {
        var result = sut.Rob(new int[] { 2, 3, 2 });
        result.Should().Be(3);
    }

    [Fact]
    public void Test2()
    {
        var result = sut.Rob(new int[] { 1, 2, 3, 1 });
        result.Should().Be(4);
    }

    [Fact]
    public void Test3()
    {
        var result = sut.Rob(new int[] { 1, 2, 3 });
        result.Should().Be(3);
    }
}

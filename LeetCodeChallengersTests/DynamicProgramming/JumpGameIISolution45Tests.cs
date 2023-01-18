using FluentAssertions;
using LeetCodeChallengers.DynamicProgramming;

namespace LeetCodeChallengersTests.DynamicProgramming;

public class JumpGameIISolution45Tests
{
    private JumpGameIISolution45 sut = new JumpGameIISolution45();

    [Fact]
    public void Test1()
    {
        var result = sut.Jump(new int[] { 2, 3, 1, 1, 4 });
        result.Should().Be(2);
    }

    [Fact]
    public void Test2()
    {
        var result = sut.Jump(new int[] { 2, 3, 0, 1, 4 });
        result.Should().Be(2);
    }
}

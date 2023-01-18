using FluentAssertions;
using LeetCodeChallengers.DynamicProgramming;

namespace LeetCodeChallengersTests.DynamicProgramming;

public class JumpGameSolution55Tests
{
    private JumpGameSolution55 sut = new JumpGameSolution55();

    [Fact]
    public void Test1()
    {
        var result = sut.CanJump(new int[] { 2, 3, 1, 1, 4 });
        result.Should().BeTrue();
    }

    [Fact]
    public void Test2()
    {
        var result = sut.CanJump(new int[] { 3, 2, 1, 0, 4 });
        result.Should().BeFalse();
    }
}

using FluentAssertions;
using LeetCodeChallengers.TwoPointer;

namespace LeetCodeChallengersTests.TwoPointer;

public class IsSubsequenceSolution392Tests
{
    private readonly IsSubsequenceSolution392 sut = new IsSubsequenceSolution392();

    [Fact]
    public void Test1()
    {
        var result = sut.IsSubsequence("abc", "ahbgdc");
        result.Should().BeTrue();
    }

    [Fact]
    public void Test2()
    {
        var result = sut.IsSubsequence("axc", "ahbgdc");
        result.Should().BeFalse();
    }
}

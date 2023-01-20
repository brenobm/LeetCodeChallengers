using FluentAssertions;
using LeetCodeChallengers.DynamicProgramming;

namespace LeetCodeChallengersTests.DynamicProgramming;

public class LongestPalindromicSubstringSolution05Tests
{
    private LongestPalindromicSubstringSolution05 sut = new LongestPalindromicSubstringSolution05();

    [Fact]
    public void Test1()
    {
        var result = sut.LongestPalindrome("babad");
        result.Should().Be("bab");
    }

    [Fact]
    public void Test2()
    {
        var result = sut.LongestPalindrome("cbbd");
        result.Should().Be("bb");
    }
}

using FluentAssertions;
using LeetCodeChallengers.SlidingWindow;

namespace LeetCodeChallengersTests.SlidingWindow;

public class MinimumWindowSubstringSolution76Tests
{
    private readonly MinimumWindowSubstringSolution76 sut = new MinimumWindowSubstringSolution76();

    [Fact]
    public void Test1()
    {
        var result = sut.MinWindow("ADOBECODEBANC", "ABC");
        result.Should().Be("BANC");
    }

    [Fact]
    public void Test2()
    {
        var result = sut.MinWindow("a", "a");
        result.Should().Be("a");
    }

    [Fact]
    public void Test3()
    {
        var result = sut.MinWindow("a", "aa");
        result.Should().Be("");
    }
}

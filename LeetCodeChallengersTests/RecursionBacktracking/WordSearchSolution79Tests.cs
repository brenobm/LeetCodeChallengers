using FluentAssertions;
using LeetCodeChallengers.RecursionBacktracking;

namespace LeetCodeChallengersTests.RecursionBacktracking;

public class WordSearchSolution79Tests
{
    private WordSearchSolution79 sut = new WordSearchSolution79();

    [Fact]
    public void Test1()
    {
        var result = sut.Exist(new char[][]
        {
            new char[] { 'A', 'B', 'C', 'E' },
            new char[] { 'S', 'F', 'C', 'S' },
            new char[] { 'A', 'D', 'E', 'E' }
        }, "ABCCED");
        result.Should().BeTrue();
    }

    [Fact]
    public void Test2()
    {
        var result = sut.Exist(new char[][]
        {
            new char[] { 'A', 'B', 'C', 'E' },
            new char[] { 'S', 'F', 'C', 'S' },
            new char[] { 'A', 'D', 'E', 'E' }
        }, "SEE");
        result.Should().BeTrue();
    }

    [Fact]
    public void Test3()
    {
        var result = sut.Exist(new char[][]
        {
            new char[] { 'A', 'B', 'C', 'E' },
            new char[] { 'S', 'F', 'C', 'S' },
            new char[] { 'A', 'D', 'E', 'E' }
        }, "ABCB");
        result.Should().BeFalse();
    }
}

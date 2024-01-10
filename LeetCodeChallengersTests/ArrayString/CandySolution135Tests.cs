using FluentAssertions;
using LeetCodeChallengers.ArrayString;

namespace LeetCodeChallengersTests.ArrayString;

public class CandySolution135Tests
{
    private readonly CandySolution135 sut = new CandySolution135();

    [Fact]
    public void Test1()
    {
        var result = sut.Candy([1, 0, 2]);
        result.Should().Be(5);
    }

    [Fact]
    public void Test2()
    {
        var result = sut.Candy([1, 2, 2]);
        result.Should().Be(4);
    }

    [Fact]
    public void Test3()
    {
        var result = sut.Candy([1, 2, 2, 3, 1, 1, 4, 4, 5, 2, 1, 5]);
        result.Should().Be(19);
    }

    [Fact]
    public void Test4()
    {
        var result = sut.Candy([3, 2, 1]);
        result.Should().Be(6);
    }

    [Fact]
    public void Test5()
    {
        var result = sut.Candy([1]);
        result.Should().Be(1);
    }
}

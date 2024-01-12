using FluentAssertions;
using LeetCodeChallengers.ArrayString;

namespace LeetCodeChallengersTests.ArrayString;

public class ZigzagConversionSolution6Tests
{
    private readonly ZigzagConversionSolution6 sut = new ZigzagConversionSolution6();

    [Fact]
    public void Test1()
    {
        var result = sut.Convert("PAYPALISHIRING", 3);
        result.Should().Be("PAHNAPLSIIGYIR");
    }

    [Fact]
    public void Test2()
    {
        var result = sut.Convert("PAYPALISHIRING", 4);
        result.Should().Be("PINALSIGYAHRPI");
    }

    [Fact]
    public void Test3()
    {
        var result = sut.Convert("A", 1);
        result.Should().Be("A");
    }

    [Fact]
    public void Test4()
    {
        var result = sut.Convert("ABCD", 2);
        result.Should().Be("ACBD");
    }
}

using FluentAssertions;
using LeetCodeChallengers.DynamicProgramming;

namespace LeetCodeChallengersTests.DynamicProgramming;

public class ArithmeticSlicesSolution413Tests
{
    private ArithmeticSlicesSolution413 sut = new ArithmeticSlicesSolution413();

    [Fact]
    public void Test1()
    {
        var result = sut.NumberOfArithmeticSlices(new int[] { 1, 2, 3, 4});
        result.Should().Be(3);
    }

    [Fact]
    public void Test2()
    {
        var result = sut.NumberOfArithmeticSlices(new int[] { 1 });
        result.Should().Be(0);
    }
}

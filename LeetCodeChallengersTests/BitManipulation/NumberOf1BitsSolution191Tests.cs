using FluentAssertions;
using LeetCodeChallengers.BitManipulation;

namespace LeetCodeChallengersTests.BitManipulation;

public class NumberOf1BitsSolution191Tests
{
    private readonly NumberOf1BitsSolution191 sut = new NumberOf1BitsSolution191();

    public static IEnumerable<object[]> GetTestData =>
        new List<object[]>
        {
                new object[] { 11, 3 },
                new object[] { 128, 1 },
                new object[] { 4294967293, 31 },
        };

    [Theory, MemberData(nameof(GetTestData))]
    public void Test(uint input, int output)
    {
        var result = sut.HammingWeight(input);
        result.Should().Be(output);
    }
}

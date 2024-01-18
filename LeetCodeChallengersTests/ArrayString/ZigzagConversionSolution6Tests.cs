using FluentAssertions;
using LeetCodeChallengers.ArrayString;

namespace LeetCodeChallengersTests.ArrayString;

public class ZigzagConversionSolution6Tests
{
    private readonly ZigzagConversionSolution6 sut = new ZigzagConversionSolution6();

    public static IEnumerable<object[]> GetTestData =>
    new List<object[]>
    {
            new object[] { "PAYPALISHIRING", 3, "PAHNAPLSIIGYIR" },
            new object[] { "PAYPALISHIRING", 4, "PINALSIGYAHRPI" },
            new object[] { "A", 1, "A" },
            new object[] { "ABCD", 2, "ACBD" },
    };


    [Theory, MemberData(nameof(GetTestData))]
    public void Test(string input1, int input2, string output)
    {
        var result = sut.Convert(input1, input2);
        result.Should().Be(output);
    }
}

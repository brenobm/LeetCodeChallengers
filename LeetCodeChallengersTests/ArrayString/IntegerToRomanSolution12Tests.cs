using FluentAssertions;
using LeetCodeChallengers.ArrayString;

namespace LeetCodeChallengersTests.ArrayString;

public class IntegerToRomanSolution12Tests
{
    private readonly IntegerToRomanSolution12 sut = new IntegerToRomanSolution12();

    public static IEnumerable<object[]> GetTestData =>
        new List<object[]>
        {
                new object[] { 3, "III" },
                new object[] { 58, "LVIII" },
                new object[] { 1994, "MCMXCIV" },
        };

    [Theory, MemberData(nameof(GetTestData))]
    public void Test(int input, string output)
    {
        var result = sut.IntToRoman(input);
        result.Should().Be(output);
    }
}

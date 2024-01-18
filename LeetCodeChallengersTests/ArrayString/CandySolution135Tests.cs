using FluentAssertions;
using LeetCodeChallengers.ArrayString;

namespace LeetCodeChallengersTests.ArrayString;

public class CandySolution135Tests
{
    private readonly CandySolution135 sut = new CandySolution135();

    public static IEnumerable<object[]> GetTestData =>
        new List<object[]>
        {
            new object[] { new int[] { 1, 0, 2 }, 5 },
            new object[] { new int[] { 1, 2, 2 }, 4 },
            new object[] { new int[] { 1, 2, 2, 3, 1, 1, 4, 4, 5, 2, 1, 5 }, 19 },
            new object[] { new int[] { 3, 2, 1 }, 6 },
            new object[] { new int[] { 1,  }, 1 },
        };


    [Theory, MemberData(nameof(GetTestData))]
    public void Test(int[] input, int output)
    {
        var result = sut.Candy(input);
        result.Should().Be(output);
    }
}

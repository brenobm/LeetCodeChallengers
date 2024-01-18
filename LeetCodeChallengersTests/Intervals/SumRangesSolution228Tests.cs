using FluentAssertions;
using LeetCodeChallengers.Intervals;

namespace LeetCodeChallengersTests.Intervals;

public class SumRangesSolution228Tests
{
    private readonly SumRangesSolution228 sut = new SumRangesSolution228();

    public static IEnumerable<object[]> GetTestData =>
        new List<object[]>
        {
            new object[] { new int[] { 0, 1, 2, 4, 5, 7 }, new List<string> { "0->2","4->5","7" } },
            new object[] { new int[] { 0, 2, 3, 4, 6, 8, 9 }, new List<string> { "0", "2->4", "6", "8->9" } },
            new object[] { new int[] { }, new List<string>() },
        };


    [Theory, MemberData(nameof(GetTestData))]
    public void Test(int[] input, IList<string> output)
    {
        var result = sut.SummaryRanges(input);
        result.Should().BeEquivalentTo(output);
    }
}

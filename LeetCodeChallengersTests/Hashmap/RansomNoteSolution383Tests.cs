using FluentAssertions;
using LeetCodeChallengers.Hashmap;

namespace LeetCodeChallengersTests.Hashmap;

public class RansomNoteSolution383Tests
{
    private readonly RansomNoteSolution383 sut = new RansomNoteSolution383();

    public static IEnumerable<object[]> GetTestData =>
        new List<object[]>
        {
                new object[] { "a", "b", false },
                new object[] { "aa", "ab", false },
                new object[] { "aa", "aab", true },
        };


    [Theory, MemberData(nameof(GetTestData))]
    public void Test(string input1, string input2, bool output)
    {
        var result = sut.CanConstruct(input1, input2);
        result.Should().Be(output);
    }
}

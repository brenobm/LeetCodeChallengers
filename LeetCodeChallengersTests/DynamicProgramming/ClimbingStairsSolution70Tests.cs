using FluentAssertions;
using LeetCodeChallengers.DynamicProgramming;

namespace LeetCodeChallengersTests.DynamicProgramming;

public class ClimbingStairsSolution70Tests
{
    private readonly ClimbingStairsSolution70 sut = new ClimbingStairsSolution70();

    public static IEnumerable<object[]> GetTestData =>
        new List<object[]>
        {
                new object[] { 2, 2 },
                new object[] { 3, 3 },
        };


    [Theory, MemberData(nameof(GetTestData))]
    public void Test(int input, int output)
    {
        var result = sut.ClimbStairs(input);
        result.Should().BeEquivalentTo(output);
    }
}

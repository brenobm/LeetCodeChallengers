using FluentAssertions;
using LeetCodeChallengers.RecursionBacktracking;

namespace LeetCodeChallengersTests.RecursionBacktracking;

public class PermutationsSolution46Tests
{
    private readonly PermutationsSolution46 sut = new PermutationsSolution46();

    public static IEnumerable<object[]> GetTestData =>
        new List<object[]>
        {
                new object[] { new int[] { 1, 2, 3 }, new int[][] { [1, 2, 3], [1, 3, 2], [2, 1, 3], [2, 3, 1], [3, 1, 2], [3, 2, 1] } },
                new object[] { new int[] { 0, 1 }, new int[][] { [0, 1], [1, 0] } },
                new object[] { new int[] { 1 }, new int[][] { [1] } },
        };


    [Theory, MemberData(nameof(GetTestData))]
    public void Test(int[] input, int[][] output)
    {
        var result = sut.Permute(input);
        result.Should().BeEquivalentTo(output);
    }
}

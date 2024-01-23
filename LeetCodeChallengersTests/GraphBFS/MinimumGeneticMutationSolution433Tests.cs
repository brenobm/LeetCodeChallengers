using FluentAssertions;
using LeetCodeChallengers.GraphBFS;

namespace LeetCodeChallengersTests.GraphBFS;

public class MinimumGeneticMutationSolution433Tests
{
    private readonly MinimumGeneticMutationSolution433 sut = new MinimumGeneticMutationSolution433();

    public static IEnumerable<object[]> GetTestData =>
        new List<object[]>
        {
                new object[] { "AACCGGTT", "AACCGGTA", new string[] { "AACCGGTA" }, 1 },
                new object[] { "AACCGGTT", "AAACGGTA", new string[] { "AACCGGTA", "AACCGCTA", "AAACGGTA" }, 2 },
                new object[] { "AAAAAAAA", "CCCCCCCC", new string[] { "AAAAAAAA", "AAAAAAAC", "AAAAAACC", "AAAAACCC", "AAAACCCC", "AACACCCC", "ACCACCCC", "ACCCCCCC", "CCCCCCCA" }, -1 },
                new object[] { "AAAAAAAT", "CCCCCCCC", new string[] { "AAAAAAAC", "AAAAAAAA", "CCCCCCCC" }, -1 },
        };


    [Theory, MemberData(nameof(GetTestData))]
    public void Test(string input1, string input2, string[] input3, int output)
    {
        var result = sut.MinMutation(input1, input2, input3);
        result.Should().Be(output);
    }
}

using FluentAssertions;
using LeetCodeChallengers.Hashmap;

namespace LeetCodeChallengersTests.Hashmap;

public class ValidAnagramSolution242Tests
{
    private readonly ValidAnagramSolution242 sut = new ValidAnagramSolution242();

    public static IEnumerable<object[]> GetTestData =>
        new List<object[]>
        {
                new object[] { "anagram", "anagram", true },
                new object[] { "rat", "cat", false },
        };


    [Theory, MemberData(nameof(GetTestData))]
    public void Test(string input1, string input2, bool output)
    {
        var result = sut.IsAnagram(input1, input2);
        result.Should().Be(output);
    }
}

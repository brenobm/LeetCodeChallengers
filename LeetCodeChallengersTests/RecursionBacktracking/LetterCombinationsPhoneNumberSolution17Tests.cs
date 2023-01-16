using FluentAssertions;
using LeetCodeChallengers.RecursionBacktracking;

namespace LeetCodeChallengersTests.RecursionBacktracking;

public class LetterCombinationsPhoneNumberSolution17Tests
{
    private LetterCombinationsPhoneNumberSolution17 sut = new LetterCombinationsPhoneNumberSolution17();

    [Fact]
    public void Test1()
    {
        var result = sut.LetterCombinations("23");
        result.Should().BeEquivalentTo(new List<string>
        {
            "ad","ae","af","bd","be","bf","cd","ce","cf"
        });
    }

    [Fact]
    public void Test2()
    {
        var result = sut.LetterCombinations("");
        result.Should().BeEquivalentTo(new List<string>());
    }

    [Fact]
    public void Test3()
    {
        var result = sut.LetterCombinations("2");
        result.Should().BeEquivalentTo(new List<string>() { "a", "b", "c" });
    }
}

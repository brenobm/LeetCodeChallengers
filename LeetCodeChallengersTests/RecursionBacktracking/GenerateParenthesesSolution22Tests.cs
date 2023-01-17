using FluentAssertions;
using LeetCodeChallengers.RecursionBacktracking;

namespace LeetCodeChallengersTests.RecursionBacktracking;

public class GenerateParenthesesSolution22Tests
{
    private GenerateParenthesesSolution22 sut = new GenerateParenthesesSolution22();

    [Fact]
    public void Test1()
    {
        var result = sut.GenerateParenthesis(3);
        result.Should().BeEquivalentTo(new List<string>
        {
            "((()))","(()())","(())()","()(())","()()()"
        });
    }

    [Fact]
    public void Test2()
    {
        var result = sut.GenerateParenthesis(1);
        result.Should().BeEquivalentTo(new List<string>
        {
            "()"
        });
    }
}

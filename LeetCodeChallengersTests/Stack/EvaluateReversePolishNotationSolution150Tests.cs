using FluentAssertions;
using LeetCodeChallengers.Stack;

namespace LeetCodeChallengersTests.Stack;

public class EvaluateReversePolishNotationSolution150Tests
{
    private readonly EvaluateReversePolishNotationSolution150 sut = new EvaluateReversePolishNotationSolution150();

    [Fact]
    public void Test1()
    {
        var result = sut.EvalRPN(["2", "1", "+", "3", "*"]);
        result.Should().Be(9);
    }

    [Fact]
    public void Test2()
    {
        var result = sut.EvalRPN(["4", "13", "5", "/", "+"]);
        result.Should().Be(6);
    }

    [Fact]
    public void Test3()
    {
        var result = sut.EvalRPN(["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"]);
        result.Should().Be(22);
    }

    [Fact]
    public void Test4()
    {
        var result = sut.EvalRPN(["2"]);
        result.Should().Be(2);
    }
}

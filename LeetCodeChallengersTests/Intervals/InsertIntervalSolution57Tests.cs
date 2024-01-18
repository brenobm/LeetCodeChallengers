using FluentAssertions;
using LeetCodeChallengers.Intervals;

namespace LeetCodeChallengersTests.Intervals;

public class InsertIntervalSolution57Tests
{
    private readonly InsertIntervalSolution57 sut = new InsertIntervalSolution57();

    [Fact]
    public void Test1()
    {
        var result = sut.Insert([[1, 3], [6, 9]], [2, 5]);
        ValidateMatrix(result, [[1, 5], [6, 9]]);
    }

    [Fact]
    public void Test2()
    {
        var result = sut.Insert([[1, 2], [3, 5], [6, 7], [8, 10], [12, 16]], [4, 8]);
        ValidateMatrix(result, [[1, 2], [3, 10], [12, 16]]);
    }

    [Fact]
    public void Test3()
    {
        var result = sut.Insert([[1,5]], [5, 7]);
        ValidateMatrix(result, [[1, 7]]);
    }

    [Fact]
    public void Test4()
    {
        var result = sut.Insert([[5, 7]], [1, 5]);
        ValidateMatrix(result, [[1, 7]]);
    }

    private static void ValidateMatrix(int[][] actual, int[][] expected)
    {
        actual.Length.Should().Be(expected.Length);

        for (int i = 0; i < expected.Length; i++)
        {
            actual[i].Length.Should().Be(expected[i].Length);
            for (int j = 0; j < expected[i].Length; j++)
            {
                actual[i][j].Should().Be(expected[i][j]);
            }
        }
    }
}

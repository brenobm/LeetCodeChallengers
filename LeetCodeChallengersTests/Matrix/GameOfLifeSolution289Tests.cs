using FluentAssertions;
using LeetCodeChallengers.Matrix;

namespace LeetCodeChallengersTests.Matrix;

public class GameOfLifeSolution289Tests
{
    private readonly GameOfLifeSolution289 sut = new GameOfLifeSolution289();

    [Fact]
    public void Test1()
    {
        int[][] matrix = [[0, 1, 0], [0, 0, 1], [1, 1, 1], [0, 0, 0]];
        sut.GameOfLife(matrix);
        ValidateMatrix(matrix, [[0, 0, 0], [1, 0, 1], [0, 1, 1], [0, 1, 0]]);
    }

    [Fact]
    public void Test2()
    {
        int[][] matrix = [[1, 1], [1, 0]];
        sut.GameOfLife(matrix);
        ValidateMatrix(matrix, [[1, 1], [1, 1]]);
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

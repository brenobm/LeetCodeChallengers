using FluentAssertions;
using LeetCodeChallengers.BreadthFirstDepthFirstSearch;

namespace LeetCodeChallengersTests.BreadthFirstDepthFirstSearch;

public class ShortestPathInBinaryMatrixSolution1091Tests
{
    private ShortestPathInBinaryMatrixSolution1091 sut = new ShortestPathInBinaryMatrixSolution1091();

    [Fact]
    public void Test1()
    {
        var distance = sut.ShortestPathBinaryMatrix(
            new int[][]
            {
                new int[]
                {
                    0, 1
                },
                new int[]
                {
                    1, 0
                }
            });
        distance.Should().Be(2);
    }

    [Fact]
    public void Test2()
    {
        var distance = sut.ShortestPathBinaryMatrix(
            new int[][]
            {
                new int[]
                {
                    0, 0, 0
                },
                new int[]
                {
                    1, 1, 0
                },
                new int[]
                {
                    1, 1, 0
                }
            });
        distance.Should().Be(4);
    }


    [Fact]
    public void Test3()
    {
        var distance = sut.ShortestPathBinaryMatrix(
            new int[][]
            {
                new int[]
                {
                    1, 0, 0
                },
                new int[]
                {
                    1, 1, 0
                },
                new int[]
                {
                    1, 1, 0
                }
            });
        distance.Should().Be(-1);
    }
}

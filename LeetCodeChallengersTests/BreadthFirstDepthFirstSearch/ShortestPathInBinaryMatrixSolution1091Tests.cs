using FluentAssertions;
using LeetCodeChallengers.BreadthFirstDepthFirstSearch;

namespace LeetCodeChallengersTests.BreadthFirstDepthFirstSearch;

public class ShortestPathInBinaryMatrixSolution1091Tests
{
    private ShortestPathInBinaryMatrixSolution1091 sut = new ShortestPathInBinaryMatrixSolution1091();

    public static IEnumerable<object[]> GetTestData =>
        new List<object[]>
        {
            new object[] {
                new int[][]
                {
                    [ 0, 1 ],
                    [ 1, 0 ],
                },
                2,
            },
            new object[] {
                new int[][]
                {
                    [ 0, 0, 0 ],
                    [ 1, 1, 0 ],
                    [ 1, 1, 0 ],
                },
                4,
            },
            new object[] {
                new int[][]
                {
                    [ 1, 0, 0 ],
                    [ 1, 1, 0 ],
                    [ 1, 1, 0 ],
                },
                -1,
            },
    };  


    [Theory, MemberData(nameof(GetTestData))]
    public void Test(int[][] input, int output)
    {
        var distance = sut.ShortestPathBinaryMatrix(input);
        distance.Should().Be(output);
    }
}

using FluentAssertions;
using LeetCodeChallengers.BreadthFirstDepthFirstSearch;

namespace LeetCodeChallengersTests.BreadthFirstDepthFirstSearch;

public class SurroundedRegionsSolution130Tests
{
    private SurroundedRegionsSolution130 sut = new SurroundedRegionsSolution130();

    [Fact]
    public void Test1()
    {
        var board = new char[][]
            {
                new char[] { 'X', 'X', 'X', 'X' },
                new char[] { 'X', 'O', 'O', 'X' },
                new char[] { 'X', 'X', 'O', 'X' },
                new char[] { 'X', 'O', 'X', 'X' }
            };
        sut.Solve(board);

        board.Should().BeEquivalentTo(new char[][]
            {
                new char[] { 'X', 'X', 'X', 'X' },
                new char[] { 'X', 'X', 'X', 'X' },
                new char[] { 'X', 'X', 'X', 'X' },
                new char[] { 'X', 'O', 'X', 'X' }
            });
    }


    [Fact]
    public void Test2()
    {
        var board = new char[][]
            {
                new char[] { 'X', 'X', 'X', 'X' },
                new char[] { 'X', 'O', 'O', 'X' },
                new char[] { 'X', 'X', 'O', 'X' },
                new char[] { 'X', 'O', 'X', 'X' }
            };
        sut.Solve(board);

        board.Should().BeEquivalentTo(new char[][]
            {
                new char[] { 'X', 'X', 'X', 'X' },
                new char[] { 'X', 'X', 'X', 'X' },
                new char[] { 'X', 'X', 'X', 'X' },
                new char[] { 'X', 'O', 'X', 'X' }
            });
    }
}

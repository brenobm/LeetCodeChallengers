using FluentAssertions;
using LeetCodeChallengers.BreadthFirstDepthFirstSearch;

namespace LeetCodeChallengersTests.BreadthFirstDepthFirstSearch;

public class SurroundedRegionsSolution130Tests
{
    private SurroundedRegionsSolution130 sut = new SurroundedRegionsSolution130();

    public static IEnumerable<object[]> GetTestData =>
        new List<object[]>
        {
            new object[] 
            {
                new char[][]
                {
                    ['X', 'X', 'X', 'X'],
                    ['X', 'O', 'O', 'X'],
                    ['X', 'X', 'O', 'X'],
                    ['X', 'O', 'X', 'X']
                },
                new char[][]
                {
                    ['X', 'X', 'X', 'X'],
                    ['X', 'X', 'X', 'X'],
                    ['X', 'X', 'X', 'X'],
                    ['X', 'O', 'X', 'X']
                },
            },
            new object[]
            {
                new char[][]
                {
                    ['X', 'X', 'X', 'X'],
                    ['X', 'O', 'O', 'X'],
                    ['X', 'X', 'O', 'X'],
                    ['X', 'O', 'X', 'X']
                },
                new char[][]
                {
                    ['X', 'X', 'X', 'X'],
                    ['X', 'X', 'X', 'X'],
                    ['X', 'X', 'X', 'X'],
                    ['X', 'O', 'X', 'X']
                },
            },
    };


    [Theory, MemberData(nameof(GetTestData))]
    public void Test1(char[][] input, char[][] output)
    {
        sut.Solve(input);

        input.Should().BeEquivalentTo(output);
    }
}

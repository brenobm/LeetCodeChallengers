using FluentAssertions;
using LeetCodeChallengers.Matrix;

namespace LeetCodeChallengersTests.Matrix;

public class SetMatrixZeroesSolution73Tests
{
    private readonly SetMatrixZeroesSolution73 sut = new SetMatrixZeroesSolution73();

    public static IEnumerable<object[]> GetTestData =>
        new List<object[]>
        {
                new object[] { new int[][] { [1, 1, 1], [1, 0, 1], [1, 1, 1] }, new int[][] { [1, 0, 1], [0, 0, 0], [1, 0, 1] } },
                new object[] { new int[][] { [0, 1, 2, 0], [3, 4, 5, 2], [1, 3, 1, 5] }, new int[][] { [0, 0, 0, 0], [0, 4, 5, 0], [0, 3, 1, 0] } },
        };


    [Theory, MemberData(nameof(GetTestData))]
    public void Test(int[][] input1, int[][] output)
    {
        sut.SetZeroes(input1);
        input1.Should().BeEquivalentTo(output);
    }
}

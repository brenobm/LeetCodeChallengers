using FluentAssertions;
using LeetCodeChallengers.ArrayString;

namespace LeetCodeChallengersTests.ArrayString;

public class MergeSortedArraySolution88Tests
{
    private readonly MergeSortedArraySolution88 sut = new MergeSortedArraySolution88();

    public static IEnumerable<object[]> GetTestData =>
        new List<object[]>
        {
            new object[] { new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6  }, 3, new int[] { 1, 2, 2, 3, 5, 6 } },
            new object[] { new int[] { 1 }, 1, new int[] { }, 0, new int[] { 1 } },
            new object[] { new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 } },
        };


    [Theory, MemberData(nameof(GetTestData))]
    public void Test1(int[] input1, int input2, int[] input3, int input4, int[] output)
    {
        int[] resultArray = [1, 2, 3, 0, 0, 0];
        sut.Merge(input1, input2, input3, input4);
        input1.Should().BeEquivalentTo(output);
    }
}

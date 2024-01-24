using FluentAssertions;
using LeetCodeChallengers.ArrayString;

namespace LeetCodeChallengersTests.ArrayString;

public class RemoveDuplicatesFromSortedArraySolution26Tests
{
    private readonly RemoveDuplicatesFromSortedArraySolution26 sut = new RemoveDuplicatesFromSortedArraySolution26();

    public static IEnumerable<object[]> GetTestData =>
        new List<object[]>
        {
                new object[] { new int[] { 1, 1, 2 }, 2, new int[] { 1, 2 } },
                new object[] { new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5, new int[] { 0, 1, 2, 3, 4 } },
        };


    [Theory, MemberData(nameof(GetTestData))]
    public void Test(int[] input, int output1, int[] output2)
    {
        var result = sut.RemoveDuplicates(input);
        result.Should().Be(output1);
        input.Take(output1).ToArray().Should().BeEquivalentTo(output2);
    }
}

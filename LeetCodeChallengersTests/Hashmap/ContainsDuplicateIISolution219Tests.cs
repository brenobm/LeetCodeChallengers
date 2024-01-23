using FluentAssertions;
using LeetCodeChallengers.Hashmap;

namespace LeetCodeChallengersTests.Hashmap;

public class ContainsDuplicateIISolution219Tests
{
    private readonly ContainsDuplicateIISolution219 sut = new ContainsDuplicateIISolution219();

    public static IEnumerable<object[]> GetTestData =>
        new List<object[]>
        {
                new object[] { new int[] { 1, 2, 3, 1 }, 3, true },
                new object[] { new int[] { 1, 0, 1, 1 }, 1, true },
                new object[] { new int[] { 1, 2, 3, 1, 2, 3 }, 2, false },
        };


    [Theory, MemberData(nameof(GetTestData))]
    public void Test(int[] input1, int input2, bool output)
    {
        var result = sut.ContainsNearbyDuplicate(input1, input2);
        result.Should().Be(output);
    }

}

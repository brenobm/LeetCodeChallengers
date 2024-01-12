using FluentAssertions;
using LeetCodeChallengers.ArrayString;

namespace LeetCodeChallengersTests.ArrayString;

public class MergeSortedArraySolution88Tests
{
    private readonly MergeSortedArraySolution88 sut = new MergeSortedArraySolution88();

    [Fact]
    public void Test1()
    {
        int[] resultArray = [1, 2, 3, 0, 0, 0];
        sut.Merge(resultArray, 3, [2, 5, 6], 3);
        resultArray.Should().BeEquivalentTo([1, 2, 2, 3, 5, 6]);
    }

    [Fact]
    public void Test2()
    {
        int[] resultArray = [1];
        sut.Merge(resultArray, 1, [], 0);
        resultArray.Should().BeEquivalentTo([1]);
    }

    [Fact]
    public void Test3()
    {
        int[] resultArray = [0];
        sut.Merge(resultArray, 0, [1], 1);
        resultArray.Should().BeEquivalentTo([1]);
    }
}

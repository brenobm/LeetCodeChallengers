using FluentAssertions;
using LeetCodeChallengers.BreadthFirstDepthFirstSearch;

namespace LeetCodeChallengersTests.BreadthFirstDepthFirstSearch;

public class BinaryTreeRightSideViewSolution199Tests
{
    private readonly BinaryTreeRightSideViewSolution199 sut = new BinaryTreeRightSideViewSolution199();

    public static IEnumerable<object[]> GetTestData =>
    new List<object[]>
    {
            new object[] {
                new TreeNode
                {
                    val = 1,
                    left = new TreeNode
                    {
                        val = 2,
                        right = new TreeNode
                        {
                            val = 5
                        },
                    },
                    right = new TreeNode
                    {
                        val = 3,
                        right = new TreeNode
                        {
                            val = 4
                        },
                    },
                },
                new List<int> { 1, 3, 4 },
            },
            new object[] {
                new TreeNode
                {
                    val = 1,
                    right = new TreeNode
                    {
                        val = 3,
                    },
                },
                new List<int> { 1, 3 },
            },
            new object[] {
                null,
                new List<int>(),
            },
    };


    [Theory, MemberData(nameof(GetTestData))]
    public void Test1(TreeNode input, IList<int> output)
    {
        var result = sut.RightSideView(input);
        result.Should().BeEquivalentTo(output);
    }
}

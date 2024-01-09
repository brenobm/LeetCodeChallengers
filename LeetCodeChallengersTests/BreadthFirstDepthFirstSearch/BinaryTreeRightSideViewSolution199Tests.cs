using FluentAssertions;
using LeetCodeChallengers.BreadthFirstDepthFirstSearch;

namespace LeetCodeChallengersTests.BreadthFirstDepthFirstSearch;

public class BinaryTreeRightSideViewSolution199Tests
{
    private readonly BinaryTreeRightSideViewSolution199 sut = new BinaryTreeRightSideViewSolution199();

    [Fact]
    public void Test1()
    {
        var tree = new TreeNode
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
        };

        var result = sut.RightSideView(tree);
        result.Should().BeEquivalentTo(new List<int> { 1, 3, 4 });
    }

    [Fact]
    public void Test2()
    {
        var tree = new TreeNode
        {
            val = 1,
            right = new TreeNode
            {
                val = 3,
            },
        };

        var result = sut.RightSideView(tree);
        result.Should().BeEquivalentTo(new List<int> { 1, 3 });
    }

    [Fact]
    public void Test3()
    {
        var result = sut.RightSideView(null);
        result.Should().BeEquivalentTo(new List<int>());
    }
}

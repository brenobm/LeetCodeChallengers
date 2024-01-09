namespace LeetCodeChallengers.BreadthFirstDepthFirstSearch;

/*
 * 199. Binary Tree Right Side View
 * Given the root of a binary tree, imagine yourself standing on the right side of it, return the values of the nodes you can see ordered from top to bottom.
 * 
 * Example 1:
 * Input: root = [1,2,3,null,5,null,4]
 * Output: [1,3,4]
 * 
 * Example 2:
 * Input: root = [1,null,3]
 * Output: [1,3]
 * 
 * Example 3:
 * Input: root = []
 * Output: []
 * 
 * Constraints:
 * The number of nodes in the tree is in the range [0, 100].
 * -100 <= Node.val <= 100
 */
public class BinaryTreeRightSideViewSolution199
{
    public IList<int> RightSideView(TreeNode root)
    {
        var result = new List<int>();

        if (root == null)
        {
            return result;
        }

        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);
        result.Add(root.val);
        queue.Enqueue(null);

        var last = root.val;
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();

            if (node == null && queue.Count > 0)
            {
                result.Add(last);
                queue.Enqueue(null);
            }
            if (node?.left != null)
            {
                last = node.left.val;
                queue.Enqueue(node.left);
            }
            if (node?.right != null)
            {
                last = node.right.val;
                queue.Enqueue(node.right);
            }
        }

        return result;
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

namespace LeetCodeChallengers.BreadthFirstDepthFirstSearch;

/*
 * 797. All Paths From Source to Target
 * 
 * Given a directed acyclic graph (DAG) of n nodes labeled from 0 to n - 1, find all possible paths from node 0 to node n - 1 and return them in any order.
 * The graph is given as follows: graph[i] is a list of all nodes you can visit from node i (i.e., there is a directed edge from node i to node graph[i][j]).
 * 
 * 
 * Example 1:
 * Input: graph = [[1,2],[3],[3],[]]
 * Output: [[0,1,3],[0,2,3]]
 * Explanation: There are two paths: 0 -> 1 -> 3 and 0 -> 2 -> 3.
 * 
 * Example 2:
 * Input: graph = [[4,3,1],[3,2,4],[3],[4],[]]
 * Output: [[0,4],[0,3,4],[0,1,3,4],[0,1,2,3,4],[0,1,4]]
 * 
 * Constraints:
 * n == graph.length
 * 2 <= n <= 15
 * 0 <= graph[i][j] < n
 * graph[i][j] != i (i.e., there will be no self-loops).
 * All the elements of graph[i] are unique.
 * The input graph is guaranteed to be a DAG.
 */
public class AllPathsFromSourceToTarget797
{
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
    {
        var target = graph.Length - 1;
        var result = new List<IList<int>>();

        var stack = new Stack<Tuple<int, int>>(); // Item, Distance
        var stackPath = new Stack<Tuple<int, int>>();

        var first = new Tuple<int, int>(0, 1);
        stack.Push(first);

        var lastSize = -1;
        while (stack.Count > 0)
        {
            var item = stack.Pop();
            if (item.Item2 <= lastSize)
            {
                Tuple<int, int>? tmp = null;
                do
                {
                    tmp = stackPath.Pop();
                } while (tmp.Item2 > item.Item2 && stackPath.Count > 0);

            }
            stackPath.Push(item);

            lastSize = item.Item2;

            if (item.Item1 == target)
            {
                var path = stackPath.Select(t => t.Item1).ToList();
                path.Reverse();
                result.Add(path);
            }

            foreach (var next in graph[item.Item1])
            {
                var nextTuple = new Tuple<int, int>(next, item.Item2 + 1);
                stack.Push(nextTuple);
            }
        }

        return result;
    }
}

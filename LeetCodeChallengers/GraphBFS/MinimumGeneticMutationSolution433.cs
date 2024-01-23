namespace LeetCodeChallengers.GraphBFS;

/*
 * 433. Minimum Genetic Mutation
 * 
 * A gene string can be represented by an 8-character long string, with choices from 'A', 'C', 'G', and 'T'.
 * Suppose we need to investigate a mutation from a gene string startGene to a gene string endGene where one mutation is defined as one single character changed in the gene string.
 * For example, "AACCGGTT" --> "AACCGGTA" is one mutation.
 * There is also a gene bank bank that records all the valid gene mutations. A gene must be in bank to make it a valid gene string.
 * Given the two gene strings startGene and endGene and the gene bank bank, return the minimum number of mutations needed to mutate from startGene to endGene. If there is no such a mutation, return -1.
 * Note that the starting point is assumed to be valid, so it might not be included in the bank.
 * 
 * Example 1:
 * Input: startGene = "AACCGGTT", endGene = "AACCGGTA", bank = ["AACCGGTA"]
 * Output: 1
 * 
 * Example 2:
 * Input: startGene = "AACCGGTT", endGene = "AAACGGTA", bank = ["AACCGGTA","AACCGCTA","AAACGGTA"]
 * Output: 2
 * 
 * Constraints:
 * 0 <= bank.length <= 10
 * startGene.length == endGene.length == bank[i].length == 8
 * startGene, endGene, and bank[i] consist of only the characters ['A', 'C', 'G', 'T'].
 */
public class MinimumGeneticMutationSolution433
{
    public int MinMutation(string startGene, string endGene, string[] bank)
    {
        if (startGene == endGene)
        {
            return 0;
        }

        if (bank.Length == 0)
        {
            return -1;
        }

        if (!bank.Contains(endGene))
        {
            return -1;
        }

        var necessaryMutations = 0;
        var graph = BuildGraph(startGene, endGene, bank);
        var visited = new HashSet<string>();

        var queue = new Queue<GraphNode>();

        queue.Enqueue(graph[0][0]);

        queue.Enqueue(null);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            if (current == null)
            {
                necessaryMutations++;
                if (queue.Count > 0)
                {
                    queue.Enqueue(null);
                }                
            }
            else
            {
                if (visited.Contains(current.Val))
                {
                    continue;
                }

                if (current.Val == endGene)
                {
                    return necessaryMutations;
                }

                for (int i = 1; i < graph[current.Pos].Count; i++)
                {
                    queue.Enqueue(graph[current.Pos][i]);
                }

                visited.Add(current.Val);
            }
        }

        return -1;
    }

    private IList<GraphNode>[] BuildGraph(string startGene, string endGene, string[] bank)
    {
        var graph = new List<GraphNode>[bank.Length + 2];
        graph[0] = new List<GraphNode> 
        { 
            new()
            {
                Val = startGene,
                Pos = 0,
            }
        };
        graph[graph.Length - 1] = new List<GraphNode> 
        { 
            new() 
            { 
                Val = endGene, 
                Pos = graph.Length - 1, 
            } 
        };

        for (int i = 0; i < bank.Length; i++)
        {
            graph[i + 1] = new List<GraphNode>
            {
                new()
                {
                    Val = bank[i],
                    Pos = i + 1,
                }
            };
        }

        for (int i = 0; i < graph.Length - 1; i++)
        {
            for (int j = 1; j < graph.Length; j++)
            {
                if (graph[i][0] != graph[j][0] && CalculateDistance(graph[i][0].Val, graph[j][0].Val) == 1)
                {
                    graph[i].Add(graph[j][0]);
                }
            }
        }

        return graph;
    }

    private int CalculateDistance(string stringA, string stringB)
    {
        var distance = 0;

        for (int i = 0; i < stringA.Length; i++)
        {
            if (stringA[i] != stringB[i])
            {
                distance++;
            }
        }

        return distance;
    }
}

public class GraphNode
{
    public string Val { get; set; }
    public int Pos { get; set; }
    public override bool Equals(object? obj)
    {
        var node = obj as GraphNode;

        if (node == null) 
            return false;

        return node.Val == Val;
    }
    public override int GetHashCode()
    {
        return Val?.GetHashCode() ?? -1;
    }
}
using FluentAssertions;
using LeetCodeChallengers.DivideAndConquer;

namespace LeetCodeChallengersTests.DivideAndConquer;

public class MergeKSortedListsSolution23Tests
{
    private readonly MergeKSortedListsSolution23 sut = new MergeKSortedListsSolution23();

    public static IEnumerable<object[]> GetTestData =>
        new List<object[]>
        {
            new object[]
            {
                new ListNode[3]
                {
                    new() 
                    {
                        val = 1,
                        next = new()
                        {
                            val = 4,
                            next = new()
                            {
                                val = 5,
                            },
                        },
                    },
                    new() 
                    {
                        val = 1,
                        next = new()
                        {
                            val = 3,
                            next = new()
                            {
                                val = 4,
                            },
                        },
                    },
                    new() 
                    {
                        val = 2,
                        next = new()
                        {
                            val = 6,
                        },
                    },
                },
                new int[]
                {
                    1, 1, 2, 3, 4, 4, 5, 6
                },
            },
            new object[]
            {
                Array.Empty<ListNode>(),
                Array.Empty<int>(),
            },
            new object[]
            {
                new ListNode[] { null },
                Array.Empty<int>(),
            },
    };


    [Theory, MemberData(nameof(GetTestData))]
    public void Test(ListNode[] input, int[] output)
    {
        var result = sut.MergeKLists(input);

        ValidateListNode(result, output);
    }

    private static void ValidateListNode(ListNode linkedList, int[] values)
    {
        if (values.Length == 0)
        {
            linkedList.Should().BeNull();
            return;
        }

        var current = linkedList;

        for (int i = 0; i < values.Length; i++)
        {
            current.val.Should().Be(values[i]);

            if (i  == values.Length - 1)
            {
                current.next.Should().BeNull();
            }
            else
            {
                current.next.Should().NotBeNull();
            }

            current = current.next;
        }
    }
}

using FluentAssertions;
using LeetCodeChallengers.DivideAndConquer;

namespace LeetCodeChallengersTests.DivideAndConquer;

public class MergeKSortedListsSolution23Tests
{
    private readonly MergeKSortedListsSolution23 sut = new MergeKSortedListsSolution23();

    [Fact]
    public void Test1()
    {
        var lists = new ListNode[3]
        {
            new ListNode
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
            new ListNode
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
            new ListNode
            {
                val = 2,
                next = new()
                {
                    val = 6,
                },
            },
        };

        var result = sut.MergeKLists(lists);

        ValidateListNode(result, [1, 1, 2, 3, 4, 4, 5, 6]);
    }

    [Fact]
    public void Test2()
    {
        var lists = new ListNode[0];

        var result = sut.MergeKLists(lists);

        ValidateListNode(result, []);
    }



    [Fact]
    public void Test3()
    {
        var lists = new ListNode[1] { null };

        var result = sut.MergeKLists(lists);

        ValidateListNode(result, []);
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

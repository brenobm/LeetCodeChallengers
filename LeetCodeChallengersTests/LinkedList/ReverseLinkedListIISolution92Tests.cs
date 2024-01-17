using FluentAssertions;
using LeetCodeChallengers.LinkedList;

namespace LeetCodeChallengersTests.LinkedList;

public class ReverseLinkedListIISolution92Tests
{
    private readonly ReverseLinkedListIISolution92 sut = new ReverseLinkedListIISolution92();

    [Fact]
    public void Test1()
    {
        var list = new ListNode
        {
            val = 1,
            next = new()
            {
                val = 2,
                next = new()
                {
                    val = 3,
                    next = new()
                    {
                        val = 4,
                        next = new()
                        {
                            val = 5
                        }
                    }
                }
            }
        };

        var result = sut.ReverseBetween(list, 2, 4);

        ValidateLinkedList(result, [1, 4, 3, 2, 5]);
    }

    [Fact]
    public void Test2()
    {
        var list = new ListNode
        {
            val = 5
        };

        var result = sut.ReverseBetween(list, 1, 1);

        ValidateLinkedList(result, [5]);
    }

    [Fact]
    public void Test3()
    {
        var list = new ListNode
        {
            val = 3,
            next = new()
            {
                val = 5,
            },
        };

        var result = sut.ReverseBetween(list, 1, 2);

        ValidateLinkedList(result, [5, 3]);
    }

    private static void ValidateLinkedList(ListNode head, int[] expected)
    {
        if (expected.Length == 0)
        {
            head.Should().BeNull();
        }

        for (int i = 0; i < expected.Length; i++)
        {
            head.Should().NotBeNull();
            head.val.Should().Be(expected[i]);

            if (i == expected.Length - 1)
            {
                head.next.Should().BeNull();
            }

            head = head.next;
        }
    }
}

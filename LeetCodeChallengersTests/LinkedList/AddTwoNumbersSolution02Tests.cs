using LeetCodeChallengers.LinkedList;
using FluentAssertions;


namespace LeetCodeChallengersTests.LinkedList;

public class AddTwoNumbersSolution02Tests
{
    private AddTwoNumbersSolution02 sut = new AddTwoNumbersSolution02();

    [Fact]
    public void Test1()
    {
        var l1 = CreateList(new List<int> { 2, 4, 3 });
        var l2 = CreateList(new List<int> { 5, 6, 4 });

        var sum = sut.AddTwoNumbers(l1, l2);

        VerifyResult(sum, new List<int> { 7, 0, 8 });
    }

    [Fact]
    public void Test2()
    {
        var l1 = CreateList(new List<int> { 0 });
        var l2 = CreateList(new List<int> { 0 });

        var sum = sut.AddTwoNumbers(l1, l2);

        VerifyResult(sum, new List<int> { 0 });
    }


    [Fact]
    public void Test3()
    {
        var l1 = CreateList(new List<int> { 9, 9, 9, 9, 9, 9, 9 });
        var l2 = CreateList(new List<int> { 9, 9, 9, 9 });

        var sum = sut.AddTwoNumbers(l1, l2);

        VerifyResult(sum, new List<int> { 8, 9, 9, 9, 0, 0, 0, 1 });
    }

    private void VerifyResult(ListNode listNode, IEnumerable<int> list)
    {
        foreach(var num in list)
        {
            listNode.Should().NotBeNull();
            listNode.val.Should().Be(num);
            listNode = listNode.next;
        }

        listNode.Should().BeNull();
    }

    private ListNode CreateList(IEnumerable<int> list)
    {
        ListNode last = null;
        ListNode head = null;
        foreach(var item in list)
        {
            var node = new ListNode
            {
                val = item
            };

            if (last != null)
            {
                last.next = node;
            } else
            {
                head = node;
            }
            last = node;
        }

        return head;
    }
}

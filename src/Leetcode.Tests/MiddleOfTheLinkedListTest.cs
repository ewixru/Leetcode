namespace Leetcode.Tests;

public class MiddleOfTheLinkedListTest
{
    [Fact]
    public void FirstExampleTest()
    {
        ListNode head = RecursiveFill(
            new ListNode(5));

        MiddleOfTheLinkedList middleOfTheLinkedList = new();

        string expectedValues = "345";
        string result = "";
        ListNode? currentNode = middleOfTheLinkedList.MiddleNode(head);
        while (currentNode != null)
        {
            result += currentNode.val;
            currentNode = currentNode.next;
        }
        Assert.Equal(expectedValues, result);
    }
    [Fact]
    public void SecondExampleTest()
    {
        ListNode head = RecursiveFill(
            new ListNode(6));      

        MiddleOfTheLinkedList middleOfTheLinkedList = new();

        string expectedValues = "456";
        string result = "";
        ListNode? currentNode = middleOfTheLinkedList.MiddleNode(head);
        while (currentNode != null)
        {
            result += currentNode.val;
            currentNode = currentNode.next;
        }
        Assert.Equal(expectedValues, result);
    }
    [Fact]
    public void ThirdExampleTest()
    {
        ListNode head = new ListNode(1);

        MiddleOfTheLinkedList middleOfTheLinkedList = new();

        string expectedValues = "1";
        string result = "";
        ListNode? currentNode = middleOfTheLinkedList.MiddleNode(head);
        while (currentNode != null)
        {
            result += currentNode.val;
            currentNode = currentNode.next;
        }
        Assert.Equal(expectedValues, result);
    }

    public ListNode RecursiveFill(ListNode parent)
    {
        if (parent.val - 1 != 0)
            return RecursiveFill(new ListNode(parent.val - 1, parent));
        else return parent ?? throw new NullReferenceException();
    }
}

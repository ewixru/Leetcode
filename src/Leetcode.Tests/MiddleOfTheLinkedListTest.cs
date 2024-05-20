namespace Leetcode.Tests;

public class MiddleOfTheLinkedListTest
{
    [Fact]
    public void FirstExampleTest()
    {
        //WTF IS THAT INPUT
        ListNode head = 
            new(1,
            new(2, 
            new(3, 
            new(4, 
            new(5
            )))));

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
        //WTF IS THAT INPUT
        ListNode head =
            new(1,
            new(2,
            new(3,
            new(4,
            new(5,
            new(6
            ))))));

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
}

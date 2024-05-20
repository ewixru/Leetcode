namespace Leetcode;

public class MiddleOfTheLinkedList
{
    public ListNode? MiddleNode(ListNode head)
    {
        int nodesCount = 0;
        ListNode? currentNode = head;
        while (currentNode?.next != null) 
        {
            currentNode = currentNode?.next;
            nodesCount++;
        }
        int targetNode = (nodesCount / 2) + (nodesCount % 2);
        nodesCount = 0;
        currentNode = head;
        while (nodesCount != targetNode)
        {
            currentNode = currentNode?.next;
            nodesCount++;
        }
        return currentNode;
    }
}

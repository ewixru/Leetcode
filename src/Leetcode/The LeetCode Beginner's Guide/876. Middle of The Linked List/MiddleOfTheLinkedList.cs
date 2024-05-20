namespace Leetcode;

public class MiddleOfTheLinkedList
{
    //public ListNode? MiddleNode(ListNode head)
    //{
    //    int nodesCount = 0;
    //    ListNode? currentNode = head;
    //    while (currentNode?.next != null) 
    //    {
    //        currentNode = currentNode?.next;
    //        nodesCount++;
    //    }
    //    int targetNode = (nodesCount / 2) + (nodesCount % 2);
    //    nodesCount = 0;
    //    currentNode = head;
    //    while (nodesCount != targetNode)
    //    {
    //        currentNode = currentNode?.next;
    //        nodesCount++;
    //    }
    //    return currentNode;
    //}

    /// <summary>
    /// Probably it's cheese solution 
    /// </summary>
    /// <param name="head">First node of linked list</param>
    /// <returns>Middle node</returns>
    public ListNode? MiddleNode(ListNode head)
    {
        ListNode currentNode = head;
        List<ListNode> list = [];
        while (true)
        {
            list.Add(currentNode);
            if(currentNode.next == null)
            {
                int targetNode = list.Count / 2;
                return list[targetNode];
            }
            currentNode = currentNode.next;
        }
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val, ListNode next)
    {
        this.val = val;
        this.next = next;
    }
}

public class LinkedList
{
    private ListNode head;
    private ListNode tail;
    public LinkedList()
    {   
    }

    public int Get(int index)
    {
        var currIndex = 0;
        var tempNode = head;
        while (currIndex < index)
        {
            tempNode = tempNode?.next;
            currIndex++;
        }
        return tempNode?.val ?? -1;
    }

    public void InsertHead(int val)
    {
        this.head = new ListNode(val, head);
        if(this.tail == null)
        {
            this.tail = head;
        }
    }

    public void InsertTail(int val)
    {
        if(this.head == null) { 
            InsertHead(val); 
        }
        else
        {
            this.tail.next = new ListNode(val, null);
            this.tail = this.tail.next;
        }
      
    }

    public bool Remove(int index)
    {
        if(Get(index) == -1) { 
            return false; 
        }
        if(index == 0)
        {
            this.head = head.next;
            return true;
        }
        var currIndex = 0;
        var tempNode = head;
        while (currIndex < index - 1)
        {
            tempNode = tempNode.next;
            currIndex++;
        }
        tempNode.next = tempNode?.next?.next;
        if(tempNode?.next == null)
        {
            tail = tempNode;
        }

        return true;
    }

    public List<int> GetValues()
    {
        var valueList = new List<int>();
        var currNode = head;
        while (currNode != null)
        {
            valueList.Add(currNode.val);
            currNode = currNode.next;
        }
        return valueList;
    }
}

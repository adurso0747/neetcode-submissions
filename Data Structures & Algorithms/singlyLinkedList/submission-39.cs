public class LinkedList
{
    public int val;
    public LinkedList next;
    public int length = 0;
    public LinkedList()
    {

    }

    public int Get(int index)
    {
        if(index > length - 1)
        {
            return -1;
        }
        var currIndex = 0;
        var tempNode = this;
        while (currIndex <= index - 1)
        {
            tempNode = tempNode.next;
            currIndex++;
        }
        return tempNode.val;
    }

    public void InsertHead(int val)
    {
        var currNode = new LinkedList();
        currNode.val = this.val;
        currNode.next = this.next;
        this.val = val;
        this.next = currNode;
        length++;
    }

    public void InsertTail(int val)
    {
        if(length == 0)
        {
           this.val = val;
        } else
        {
            var currIndex = 0;
            var currNode = this;
            while (currIndex < length - 1)
            {
                currNode = currNode.next;
                currIndex++;
            }
            var newNode = new LinkedList();
            newNode.val = val;
            currNode.next = newNode;
        }
        length++;
    }

    public bool Remove(int index)
    {
        if (index > length - 1)
        {
            return false;
        }
        if(index == 0)
        {
            this.val = this.next.val;
            this.next = this.next.next;
            length--;
            return true;
        }
        var currNode = this;
        var currIndex = 0;
        while (currIndex < index - 1)
        {
            currNode = currNode.next;
            currIndex++;
        }
        currNode.next = currNode.next.next;
        length--;
        return true;
    }

    public List<int> GetValues()
    {
        var valueList = new List<int>();
        var currNode = this;
        var currIndex = 0;
        while (currIndex <= length - 1 && currNode != null)
        {
            valueList.Add(currNode.val);
            currNode = currNode?.next;
            currIndex++;
        }
        return valueList;
    }
}
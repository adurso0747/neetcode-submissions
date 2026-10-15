/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if(list1 == null && list2 == null) {
            return null;
        }
        ListNode dummyNode = new ListNode(0, new ListNode());
        var tail = dummyNode;
        while (list1 != null || list2 != null)
        {
            if (list1 != null && list2 != null)
            {
                if (list1.val > list2.val)
                {
                    tail.next = new ListNode(list2.val);
                    list2 = list2.next;
                }
                else
                {
                    tail.next = new ListNode(list1.val);
                    list1 = list1.next;
                }
            }
            else if (list1 != null)
            {
                tail.next = new ListNode(list1.val);
                list1 = list1.next;
            }
            else if (list2 != null)
            {
                tail.next = new ListNode(list2.val);
                list2 = list2.next;
            }
            tail = tail.next;
        }
        return dummyNode.next;
    }
}
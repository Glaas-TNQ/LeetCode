/* 
21. Merge Two Sorted Lists
Easy

You are given the heads of two sorted linked lists list1 and list2.

Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.

Example 1:

Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]
Example 2:

Input: list1 = [], list2 = []
Output: []
Example 3:

Input: list1 = [], list2 = [0]
Output: [0]
 

Constraints:

The number of nodes in both lists is in the range [0, 50].
-100 <= Node.val <= 100
Both list1 and list2 are sorted in non-decreasing order. */

namespace LeetCodeSolutions.Problems
{
    public static class _21_MergeTwoSortedLists_Easy
    {
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
        public class ListNode
        {
            public int val;
            public ListNode next;
            #pragma warning disable CS8625 // Non è possibile convertire il valore letterale Null in tipo riferimento che non ammette i valori Null.
            public ListNode(int val=0, ListNode next=null) {
                 this.val = val;
                 this.next = next;
            }
            #pragma warning restore CS8625 // Non è possibile convertire il valore letterale Null in tipo riferimento che non ammette i valori Null.

        }
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2) 
        {
            ListNode solution=new ListNode();  
            //Need to cycle on the list THEN do this:
            //if the val of the current node is=to the val of the node on the other list, put them both in sequence,
            //else increase the counter for the list with the node of smaller value and move to the next cycle
            foreach(ListNode node in list1)
            {

            }
            return solution;
        }
    }

}
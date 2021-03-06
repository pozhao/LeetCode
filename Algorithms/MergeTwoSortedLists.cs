// Source : https://leetcode.com/problems/merge-two-sorted-lists/ 
// Author : codeyu 
// Date : 2016年10月9日 16:03:06 

/***************************************************************************************
*
* Merge two sorted linked lists and return it as a new list. 
* The new list should be made by splicing together the nodes of the first two lists.
*
**********************************************************************************/

using Algorithms.Utils;
namespace Algorithms
{
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int Val;
 *     public ListNode Next;
 *     public ListNode(int x) { Val = x; }
 * }
 */
    public class Solution021 
    {
        public static ListNode<int> MergeTwoLists2(ListNode<int> l1, ListNode<int> l2) 
        {
            ListNode<int> dummy = new ListNode<int>(0);
            ListNode<int> lastNode = dummy;
            
            while (l1 != null && l2 != null) {
                if (l1.Val < l2.Val) {
                    lastNode.Next = l1;
                    l1 = l1.Next;
                } else {
                    lastNode.Next = l2;
                    l2 = l2.Next;
                }
                lastNode = lastNode.Next;
            }
            
            if (l1 != null) {
                lastNode.Next = l1;
            } else {
                lastNode.Next = l2;
            }
            
            return dummy.Next;
        }
        public static ListNode<int> MergeTwoLists(ListNode<int> l1, ListNode<int> l2) 
        {
            if(l1 == null)
            {
                return l2;
            }
            if(l2 == null)
            {
                return l1;
            }
            var MergedHead = new ListNode<int>(0);
            if(l1.Val < l2.Val)
            {
                MergedHead = l1;
                MergedHead.Next = MergeTwoLists(l1.Next, l2);
            }
            else
            {
                MergedHead = l2;
                MergedHead.Next = MergeTwoLists(l1, l2.Next);
            }
            return MergedHead;
        }
    }
}


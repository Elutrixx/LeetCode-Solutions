using LeetCode_Solutions.DataStructures.Lists;

namespace LeetCode_Solutions.Manipulators;

public class ListManipulator
{
    /// <summary>
    /// Solves the <see href="https://leetcode.com/problems/add-two-numbers/description/">Add Two Numbers</see> problem.
    /// </summary>
    /// <param name="first">The first singly linked List</param>
    /// <param name="second">The second singly linked List</param>
    /// <returns>A new singly linked list containing the result of the addition</returns>
    public static SingleLinkedListNode<int> AddTwoNumbers(SingleLinkedListNode<int>? first, SingleLinkedListNode<int>? second)
    {
        bool carry = false;
        var head = new SingleLinkedListNode<int>(0, null);
        var current = head;
        while (first != null && second != null)
        {
            current.Value = first.Value + second.Value + (carry ? 1 : 0);
            if(current.Value >= 10)
            {
                current.Value -= 10;
                carry = true;
            }
            else
            {
                carry = false;
            }
            first = first.Next;
            second = second.Next;
            if (first != null || second != null || carry)
            {
                current.Next = new SingleLinkedListNode<int>(0, null);
                current = current.Next;
            }
        }

        if (first == null && second != null)
        {
            first = second;
        }
        
        while (first != null)
        {
            current.Value = first.Value + (carry ? 1 : 0);
            if(current.Value >= 10)
            {
                current.Value -= 10;
                carry = true;
            }
            else
            {
                carry = false;
            }
            first = first.Next;
            if (first != null || carry)
            {
                current.Next = new SingleLinkedListNode<int>(0, null);
                current = current.Next;
            }
        }

        if (carry)
        {
            current.Value = 1;
        }

        return head;
    }
}
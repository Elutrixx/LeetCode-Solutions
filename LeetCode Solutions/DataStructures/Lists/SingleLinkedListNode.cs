namespace LeetCode_Solutions.DataStructures.Lists;

public class SingleLinkedListNode<T>(T value, SingleLinkedListNode<T>? next)
{
    public T Value = value;
    public SingleLinkedListNode<T>? Next { get; set; } = next;
    
    public static SingleLinkedListNode<T> FromArray(T[] array)
    {
        if (array.Length == 0) throw new ArgumentException("Array cannot be empty", nameof(array));
        var head = new SingleLinkedListNode<T>(array[0], null);
        var current = head;
        for (int i = 1; i < array.Length; i++)
        {
            current.Next = new SingleLinkedListNode<T>(array[i], null);
            current = current.Next;
        }
        return head;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType())
            return false;
        var other = (SingleLinkedListNode<T>) obj;
        var valueEquality = (Value == null && other.Value == null) || (Value != null && Value.Equals(other.Value));
        if (Next == null && other.Next == null && valueEquality)
        {
            return true;
        }
        if ((other.Next == null ^ Next == null) || !valueEquality)
        {
            return false;
        }
        return Next?.Equals(other.Next) ?? false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Value, Next);
    }
}
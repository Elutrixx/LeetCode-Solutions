using LeetCode_Solutions.DataStructures.Lists;
using LeetCode_Solutions.Manipulators;

namespace LeetCode_Unit_Tests;

public class ListManipulatorTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void AddTwoNumbers_ShouldSucceed(SingleLinkedListNode<int> first, SingleLinkedListNode<int> second, SingleLinkedListNode<int> expected)
    {
        var result = ListManipulator.AddTwoNumbers(first, second);
        var equality = expected.Equals(result);
        Assert.True(equality);
    }
    
    #region TestData

    public static IEnumerable<object[]> TestData
    {
        get
        {
            yield return
            [
                SingleLinkedListNode<int>.FromArray([2, 4, 3]),
                SingleLinkedListNode<int>.FromArray([5, 6, 4]),
                SingleLinkedListNode<int>.FromArray([7, 0, 8])
            ];
            yield return
            [
                SingleLinkedListNode<int>.FromArray([0]),
                SingleLinkedListNode<int>.FromArray([0]),
                SingleLinkedListNode<int>.FromArray([0])
            ];
            yield return
            [
                SingleLinkedListNode<int>.FromArray([9, 9, 9, 9, 9, 9, 9]),
                SingleLinkedListNode<int>.FromArray([9, 9, 9, 9]),
                SingleLinkedListNode<int>.FromArray([8, 9, 9, 9, 0, 0, 0, 1])
            ];
        }
    }
    
    #endregion
}
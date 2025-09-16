using LeetCode_Solutions;

namespace LeetCode_Unit_Tests;

public class ArrayManipulatorTests
{
    [Theory]
    [InlineData(new[] {2,7,11,15},9,new[] {0,1})]
    [InlineData(new[] {3,2,4},6,new[] {1,2})]
    [InlineData(new[] {3,3},6,new[] {0,1})]
    public void TwoSums_ShouldSucceed(int[] nums, int target, int[] expected)
    {
        Assert.Equal(ArrayManipulator.TwoSums(nums, target),expected);
    }
    
    [Theory]
    [InlineData(null,2,typeof(ArgumentNullException))]
    [InlineData(new int[0],2,typeof(ArgumentException))]
    [InlineData(new [] {1,2},100,typeof(ArgumentException))]
    public void TwoSums_ShouldThrow(int[] nums, int target, Type expectedException)
    {
        var exception = Record.Exception(() => ArrayManipulator.TwoSums(nums, target));
        Assert.NotNull(exception);
        Assert.IsType(expectedException, exception);
    }
}
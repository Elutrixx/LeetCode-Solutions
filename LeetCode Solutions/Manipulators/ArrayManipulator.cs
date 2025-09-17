namespace LeetCode_Solutions.Manipulators;

public static class ArrayManipulator
{
    /// <summary>
    /// Solves the <see href="https://leetcode.com/problems/two-sum/description/">Two Sum Problem</see>.
    /// </summary>
    /// <param name="nums">An array of integers</param>
    /// <param name="target">The target integer</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static int[] TwoSums(int[] nums, int target)
    {
        if (nums.Length == 0)
            throw new ArgumentException("Array cannot be empty", nameof(nums));
        
        var numDict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (numDict.TryGetValue(complement, out int value))
            {
                return [value, i];
            }
            numDict[nums[i]] = i;
        }
        throw new ArgumentException("No two sum solution");
    }
}
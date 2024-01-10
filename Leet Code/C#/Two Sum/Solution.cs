namespace TwoSum;

public static class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var dictionary = new Dictionary<int, int>();

        for (var index = 0; index < nums.Length; index++)
        {
            var complement = target - nums[index];
            if (dictionary.TryGetValue(complement, out int value))
            {
                return [value, index];
            }
            dictionary[nums[index]] = index;
        }

        throw new ArgumentException("No two sum solution found");
    }

    public static int[] NaiveTwoSum(int[] nums, int target)
    {
        var possibleValues = nums.ToList();

        for (var indexSum1 = 0; indexSum1 < possibleValues.Count; indexSum1++)
        {
            for (var indexSum2 = indexSum1 + 1; indexSum2 < possibleValues.Count; indexSum2++)
            {
                if (possibleValues[indexSum1] + possibleValues[indexSum2] == target)
                    return [indexSum1, indexSum2];
            }
        }

        throw new ArgumentException("No two sum solution");
    }
}
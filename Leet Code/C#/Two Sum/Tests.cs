using NUnit.Framework;

class Tests
{
    [TestCase(new int[] {2, 7, 11, 15}, 9, new int[] {0, 1})]
    [TestCase(new int[] {3, 2, 4}, 6, new int[] {1, 2})]
    [TestCase(new int[] {3, 3}, 6, new int[] {0, 1})]
    [TestCase(new int[] {2, 5, 5, 11}, 10, new int[] {0, 1})]
    public void ShouldReturnExpectedResult(int[] nums, int target, int[] expected)
    {
        var actual = Solution.TwoSum(nums, target);

        Assert.That(nums[expected[0]], Is.EqualTo(nums[actual[0]]));
        Assert.That(nums[expected[1]], Is.EqualTo(nums[actual[1]]));
    }
}
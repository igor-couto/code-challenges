using NUnit.Framework;

namespace TwoSum.Tests;

[TestFixture]
class Tests
{
    [TestCase(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [TestCase(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [TestCase(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    [TestCase(new[] { 2, 5, 5, 11 }, 10, new[] { 0, 1 })]
    public void ShouldReturnExpectedResult(int[] nums, int target, int[] expected)
    {
        var actual = Solution.TwoSum(nums, target);
        
        Assert.Multiple(() =>
        {
            Assert.That(nums[expected[0]], Is.EqualTo(nums[actual[0]]));
            Assert.That(nums[expected[1]], Is.EqualTo(nums[actual[1]]));
        });
    }
}
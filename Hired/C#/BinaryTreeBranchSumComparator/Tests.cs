using NUnit.Framework;

namespace BinaryTreeBranchSumComparator.Tests;

[TestFixture]
class Tests
{
    [TestCase(new long[] {3,6,2,9,-1,10}, "Left")]
    [TestCase(new long[] {0}, "")]
    [TestCase(new long[] {-1}, "")]
    [TestCase(new long[] {10, 5, 5, -1, -1, -1, -1}, "")]
    [TestCase(new long[] {5, 3, 7, -1, -1, 6, 9}, "Right")]
    [TestCase(new long[] {1, -1, 2, -1, -1, -1, 3}, "Right")]
    [TestCase(new long[] {10, 20, 5, 10, -1, -1, -1}, "Left")]
    [TestCase(new long[] {1, 2, 3, -1, -1, -1, 4, -1, -1, -1, -1, -1, -1, -1, 5}, "Right")]
    [TestCase(new long[] {10, -1, 20, -1, -1, -1, 30}, "Right")]
    [TestCase(new long[] {8, 3, 10, 1, 6, -1, 14, -1, -1, 9, 7}, "Left")]
    [TestCase(new long[] {100, 200, 300, 400, 500, 600, 700}, "Right")]
    public void BinaryTreeBranchSumComparatorTests(long[] treeAsArray, string expected)
    {
        var result = Solution.BinaryTreeBranchSumComparator(treeAsArray);   
        Assert.That(result, Is.EqualTo(expected));
    }
}
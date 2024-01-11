using NUnit.Framework;

namespace AbsoluteValuesSumMinimization.Tests;

[TestFixture]
class Tests
{
    [TestCase(new [] { 2, 4, 7 }, 4)]
    [TestCase(new [] { 2, 3 }, 2)]
    [TestCase(new [] { 1, 3, 6, 8, 10 }, 6)]
    [TestCase(new [] { -5, -3, 0, 2, 4 }, 0)]
    [TestCase(new [] { 1, 2, 3, 4, 5, 6 }, 3)]
    public void AbsoluteValuesSumMinimizationShouldBeAsExpected_Naive(int[] a, int expectedResult)
    {
        var result = Solution.AbsoluteValuesSumMinimization_Naive(a);
           
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [TestCase(new [] { 2, 4, 7 }, 4)]
    [TestCase(new [] { 2, 3 }, 2)]
    [TestCase(new [] { 1, 3, 6, 8, 10 }, 6)]
    [TestCase(new [] { -5, -3, 0, 2, 4 }, 0)]
    [TestCase(new [] { 1, 2, 3, 4, 5, 6 }, 3)]
    public void AbsoluteValuesSumMinimization_SecondAttempt(int[] a, int expectedResult)
    {
        var result = Solution.AbsoluteValuesSumMinimization_SecondAttempt(a);
           
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
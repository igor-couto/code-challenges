using NUnit.Framework;

class Tests
{
    [TestCase(new int[] { 1, 2, 3, 4, 3, 2, 1 } , 4)]
    [TestCase(new int[] { 1 } , 1)]
    [TestCase(new int[] { 1, 1, 2 } , 2)]
    [TestCase(new int[] { 0, 0, 1, 2, 1 } , 2)]
    public void ShouldReturnExpectedResult(int [] array, int resultExpected) 
    {
        var actualResult = Result.LonelyInteger(array.ToList());

        Assert.That(actualResult, Is.EqualTo(resultExpected));
    }
}
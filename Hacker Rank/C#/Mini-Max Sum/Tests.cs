using NUnit.Framework;

class Tests
{
    [TestCase(new int[] { 7, 69, 2, 221, 8974 } , "299 9271")]
    [TestCase(new int[] { 1, 3, 5, 7, 9 } , "16 24")]
    [TestCase(new int[] { 1, 2, 3, 4, 5 } , "10 14")]
    public void ShouldReturnExpectedResult(int [] array, string resultExpected) 
    {
        var actualResult = Result.Resolve(array.ToList());

        Assert.AreEqual(resultExpected, actualResult);
    }
}
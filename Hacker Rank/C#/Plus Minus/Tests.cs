using NUnit.Framework;

class Tests
{
    [TestCase(new int[] { 1, 1, 0, -1, -1 } , "0.400000", "0.400000", "0.200000")]
    [TestCase(new int[] { -4, 3, -9, 0, 4, 1 } , "0.500000", "0.333333", "0.166667")]
    public void ShouldReturnExpectedResult(int [] array, string positiveRatioExpected, string negativeRatioExpected, string zeroRatioExpected) 
    {
        (var positiveRatioActual, var negativeRatioActual, var zeroRatioActual) = Result.GetRatios(array.ToList());

        Assert.AreEqual(positiveRatioExpected, positiveRatioActual);
        Assert.AreEqual(negativeRatioExpected, negativeRatioActual);
        Assert.AreEqual(zeroRatioExpected, zeroRatioActual);
    }
}
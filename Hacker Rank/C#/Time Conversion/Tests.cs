using NUnit.Framework;

class Tests
{
    [TestCase("07:05:45PM", "19:05:45")]
    [TestCase("12:01:00PM", "12:01:00")]
    [TestCase("12:01:00AM", "00:01:00")]
    [TestCase("12:00:00AM", "00:00:00")]
    [TestCase("12:00:00PM", "12:00:00")]
    public void ShouldReturnExpectedResult(string input, string expected)
    {
        var actual = Result.TimeConversion(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
}
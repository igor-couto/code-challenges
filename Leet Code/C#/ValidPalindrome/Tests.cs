using NUnit.Framework;

namespace ValidPalindrome.Tests;

[TestFixture]
class Tests
{

    private string[] _palindromes = new string[] {"ana", "otto", "Civic","Level","Madam","Radar","Noon","Racecar","Redder", "Borrow or Rob", "No Devil lived on"};
    private string[] _notPalindromes = new string[] {"igor", "car", "ab", "abcdefg"};


    [Test]
    public void ValidPalindrome_ShouldBeTrue()
    {
        foreach (var palindrome in _palindromes)
            Assert.That(Solution.ValidPalindrome(palindrome), Is.Equals(false));
    }

    [Test]
    public void ValidPalindrome_ShouldBeTrue()
    {
        foreach (var notPalindrome in _notPalindromes)
            Assert.That(Solution.ValidPalindrome(notPalindrome), Is.Equals(false));
    }
}
namespace ValidPalindrome;

public static class Solution
{
    public static int[] ValidPalindrome(string s)
    {
        var word = wordToCheck.ToLower().Replace(" ", string.Empty);
        var isPalindrome = true;
        var middleCharacterIndex = word.Length/2;

        for(var i = 0; i < middleCharacterIndex; i++)
        {
            if(word[i] != word[word.Length -1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        return isPalindrome;
    }
}
using NUnit.Framework;

namespace LeafSimilarTrees.Tests;

[TestFixture]
class Tests
{
    private static int?[] ParseTreeFromString(string tree)
    {
        return tree
                   .Replace(" ", "")
                   .Replace("[", "")
                   .Replace("]", "")
                   .Split(',')
                   .Select(node => node == "null" ? (int?) null : int.Parse(node))
                   .ToArray();
    }

    [TestCase("[3, 5, 1, 6, 2, 9, 8, null, null, 7, 4]", "[3, 5, 1, 6, 7, 4, 2, null, null, null, null, null, null, 9, 8]")]
    [TestCase("[1]", "[1]")]
    [TestCase("[5]", "[6, null, 5]")]
    [TestCase("[1, 2]", "[1, null, 2]")]

    public void TestLeafSimilarShouldBeTrue(string input1, string input2)
    {
        var tree1 = TreeBuilder.BuildTree(ParseTreeFromString(input1));
        var tree2 = TreeBuilder.BuildTree(ParseTreeFromString(input2));

        var result = Solution.LeafSimilar(tree1,  tree2);
        
        Assert.That(result, Is.True);
    }

    [TestCase("[1, 2, 3]", "[1, 3, 2]")]
    [TestCase("[1, 2, 3, 4, 5]", "[1, 2, 3, 5, 4]")]
    [TestCase("[1, 2, 3, 4]", "[1, 3, 2, 4]")]
    public void TestLeafSimilarShouldBeFalse(string input1, string input2)
    {
        var tree1 = TreeBuilder.BuildTree(ParseTreeFromString(input1));
        var tree2 = TreeBuilder.BuildTree(ParseTreeFromString(input2));

        var result = Solution.LeafSimilar(tree1,  tree2);
        
        Assert.That(result, Is.False);
    }
}
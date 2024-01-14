using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class Solution {
    public static string BinaryTreeBranchSumComparator(long[] arr) {
        
        if(arr.Length <= 1)
            return string.Empty;
        
        var tree = new BinaryTree(arr);
        
        return tree.LargerBranch();
    }
}

public class BinaryTree
{
    private readonly long[] _tree;

    public BinaryTree(long[] tree) => _tree = tree;

    public string LargerBranch() {
        if (_tree == null || _tree.Length == 0 || (_tree.Length == 1 && _tree[0] == -1))
            return string.Empty;

        var leftSum = SumBranch(0 * 2 + 1);
    var rightSum = SumBranch(0 * 2 + 2);

        if (leftSum == rightSum)
            return string.Empty;

        return leftSum > rightSum ? "Left" : "Right";
    }

    private long SumBranch(long index) {
        if (index >= _tree.Length || _tree[index] == -1) 
            return 0;

        var leftChild = 2 * index + 1;
        var rightChild = 2 * index + 2;

        return _tree[index] + SumBranch(leftChild) + SumBranch(rightChild);
    }
}
namespace LeafSimilarTrees;

public static class Solution {
    public static bool LeafSimilar(TreeNode root1, TreeNode root2) {
        
        var leaves1 = new List<int>();
        var leaves2 = new List<int>();
        
        GetLeaves(root1, leaves1);
        GetLeaves(root2, leaves2);

        return leaves1.SequenceEqual(leaves2);
    }

    private static void GetLeaves(TreeNode node, List<int> leaves) {
        
        if (node == null) return;

        if (node.Left == null && node.Right == null)
        {
            leaves.Add(node.Value);
        } 
        else 
        {
            GetLeaves(node.Left, leaves);
            GetLeaves(node.Right, leaves);
        }
    }
}
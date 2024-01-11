namespace LeafSimilarTrees;

public class TreeBuilder {
    public static TreeNode BuildTree(int?[] arr)
    {
        if (arr == null || arr.Length == 0 || arr[0] == null) 
            return null;

        var root = new TreeNode(arr[0].Value);
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        for (var i = 1; i < arr.Length; i += 2) 
        {
            var current = queue.Dequeue();

            if (arr[i] != null)
            {
                current.Left = new TreeNode(arr[i].Value);
                queue.Enqueue(current.Left);
            }

            if (i + 1 < arr.Length && arr[i + 1] != null) 
            {
                current.Right = new TreeNode(arr[i + 1].Value);
                queue.Enqueue(current.Right);
            }
        }

        return root;
    }
}
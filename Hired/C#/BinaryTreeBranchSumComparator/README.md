# Binary Tree Branch Sum Comparator

Suppose you're given a binary tree represented as an array. For exemple, [3, 6, 2, 9, -1, 10] represents the folowing binary tree (where -1 is a non-existent node):

![](https://github.com/igor-couto/code-challenges/blob/main/Hired/C%23/BinaryTreeBranchSumComparator/Images/tree.png)

Write a function that determines whether the left or right branch of the tree is larger. The size of each branch is the sum of the node values. The function should return the string "Right" if the right side is larger and "Left" if the left side is larger. If the tree has 0 nodes or if the size of the branches are equal, return the empty string.

Example Input:
`[3,6,2,9,-1,10]`

Example Output:
`Left`
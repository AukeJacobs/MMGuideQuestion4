using BinaryTreeApp;

var tree = new BinaryTree<int>();

foreach (var value in new[] { 50, 76, 17, 9, 23, 54, 14, 19, 72, 12, 67 })
{
    tree.Add(value);
}

BinaryTree<int>.PrintNodesWithOneChildAfter(tree.Root);
    
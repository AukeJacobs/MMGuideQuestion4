namespace BinaryTreeApp
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public Node<T> Root { get; private set; } = null!;

        public void Add(T value)
        {
            if (Root == null)
            {
                Root = new Node<T>(value);
            }
            else
            {
                Root.Add(value);
            }
        }

        public static void PrintNodesWithOneChildAfter(Node<T> node)
        {
            if (node == null)
                return;

            if (IsNextNodeEndNode(node) && ((node.Left != null && node.Right == null) || (node.Left == null && node.Right != null)))
            {
                Console.WriteLine($"Found parent node with a single end note child: {node.Value}");
            }
                
            PrintNodesWithOneChildAfter(node.Left);
            PrintNodesWithOneChildAfter(node.Right);
        }

        private static bool IsNextNodeEndNode(Node<T> node)
        {
            if (node.Left != null)
            {
                if (node.Left.Left == null && node.Left.Right == null && node.Right == null)
                {
                    return true;
                }
            }

            if (node.Right != null)
            {
                if (node.Right.Left == null && node.Right.Right == null && node.Left == null)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

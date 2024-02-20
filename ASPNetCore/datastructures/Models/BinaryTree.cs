namespace datastructures.Models
{
    public class BinaryTree
    {
        public TreeNode? Root { get; set; } //References th Root node

        // Construtor
        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(int data)
        {
            Root = InsertRecursive(Root, data);
        }

        /// <summary>
        /// Insert Data recursively
        /// </summary>
        /// <param name="root">Node to consider for inserting the data</param>
        /// <param name="data">Data to be inserted</param>
        /// <returns></returns>
        private static TreeNode InsertRecursive(TreeNode? root, int data)
        {
            // Root is null -> create new node with data.
            if (root == null)
            {
                root = new TreeNode(data);
                return root;
            } 
            // data is less than node.Data -> insert on the left
            if (data < root.Data)
            {
                root.Left = InsertRecursive(root.Left, data);
            }
            // data is greater than node.Data -> insert on the right
            if (data > root.Data)
            {
                root.Right = InsertRecursive(root.Right, data);
            }
            return root;
        }

        public bool BinarySearch(TreeNode? node, int target)
        {
            // Node is null -> not found
            if (node == null)
            {
                return false;
            }
            // target is node.Data -> found
            if (target == node.Data)
            {
                return true;
            }
            // target is less than node.Data -> search in left
            else if (target < node.Data)
            {
                return BinarySearch(node.Left, target);
            }
            // target is greater than node.Data -> search in right
            else
            {
                return BinarySearch(node.Right, target);
            }
        }

        public void InOrderTraversal(TreeNode? node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);    // Recursively traverse left
                Console.Write(node.Data + " "); // Display node data
                InOrderTraversal(node.Right);   // Recursively traverse righ
            }
        }
    }
}

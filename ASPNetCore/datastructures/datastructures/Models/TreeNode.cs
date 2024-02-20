namespace datastructures.Models
{
    public class TreeNode(int data)
    {
        public int Data { get; set; } = data;
        public TreeNode? Left { get; set; } = null;
        public TreeNode? Right { get; set; } = null;

    }
}

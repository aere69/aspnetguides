namespace datastructures.Models
{
    // --------------------------------------------
    //    public class Node<T>
    //    {
    //        public T Data { get; set; }
    //        public Node<T> Next { get; set; }

    //        public Node(T data)
    //        {
    //            Data = data;
    //            Next = null;
    //        }
    //    }
    // ---- Make Node<T> nullable
    // ---- Use simplified code version.
    //----------------------------------------------
    public class Node<T>(T data)
    {
        public T Data { get; set; } = data;
        public Node<T>? Next { get; set; } = null;
    }
}

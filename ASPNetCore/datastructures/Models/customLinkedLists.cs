namespace datastructures.Models
{
    public class CustomLinkedLists<T>
    {
        private Node<T>? head;

        public void Add(T data)
        {
            //------------------------------------
            //Node<T> newNode = new Node<T>(data);
            //Simplified version
            //------------------------------------
            Node<T>? newNode = new (data);
            if (head == null)
                head = newNode;
            else
            {
                Node<T>? current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void Display()
        {
            Node<T>? current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}

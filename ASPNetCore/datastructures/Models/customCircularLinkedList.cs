namespace datastructures.Models
{
    public class CustomCircularLinkedList<T>
    {
        private Node<T>? head;
        private Node<T>? tail;

        public void Add(T data)
        {
            Node<T>? newNode = new (data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
                tail.Next = head;   // Make it circular.
            } else {
                newNode.Next = head;
                tail.Next = newNode;
                tail = newNode;
            }
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Circular Linked List is empty.");
                return;
            }

            Node<T> current = head;
            do
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            } while (current != head);

            Console.WriteLine(" (Back to head)");
        }
    }
}

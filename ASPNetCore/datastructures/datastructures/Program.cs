using datastructures.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Collections;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

#region Arrays

int[] intArray = { 1, 2, 3, 4 }; // Array of integer elements
string[] stringArray = {"red", "blue", "yellow", "white", "black" }; // Array of string elements

int[] staticSizeArray = new int[5] { 1, 2, 3, 4, 5}; // Number of elemnts is fixed
int[] dynamicSizeArray = new int[] { }; // Dynamic size array. Number of elements can change

// Vector - 1 Dimension Array
int[] vector = new int[5];
vector[0] = 1;
vector[1] = 2;
vector[2] = 3;
vector[3] = 4;
vector[4] = 5;

// Matrix - n dimension Array
int[,] matrix = new int[3, 3]; // Create a 3x3 matrix on integer
matrix[0, 0] = 1;
matrix[0, 1] = 2;
matrix[0, 2] = 3;
matrix[1, 0] = 4;
matrix[1, 1] = 5;
matrix[1, 2] = 6;
matrix[2, 0] = 7;
matrix[2, 1] = 8;
matrix[2, 2] = 9;

int[,,] cube = new int[2, 2, 2]; // Create a 2x2x2 cube of integer
cube[0, 0, 0] = 1;
cube[0, 0, 1] = 2;
cube[0, 1, 0] = 3;
cube[0, 1, 1] = 4;
cube[1, 0, 0] = 5;
cube[1, 0, 1] = 6;
cube[1, 1, 0] = 7;
cube[1, 1, 1] = 8;

#endregion

#region Linked lists

//Singly linked list
CustomLinkedLists<int> myList = new CustomLinkedLists<int>();
myList.Add(1);
myList.Add(2);
myList.Add(3);

Console.WriteLine("Singly Linked List:");
myList.Display();
Console.WriteLine("");

//Custom Circular (Double) linked list
CustomCircularLinkedList<int> circularLinkedList = new CustomCircularLinkedList<int>();

circularLinkedList.Add(1);
circularLinkedList.Add(2);
circularLinkedList.Add(3);

Console.WriteLine("Custom Circular List:");
circularLinkedList.Display();
Console.WriteLine("");


// Create a LinkedList of integers
LinkedList<int> dblLinkList = new LinkedList<int>();

dblLinkList.AddLast(1);
dblLinkList.AddLast(2);
dblLinkList.AddLast(3);

// Display the elements in the list
Console.WriteLine("Double LinkedList:");
foreach (int item in dblLinkList)
{
    Console.Write(item + " <-> ");
}
Console.WriteLine("null");
Console.WriteLine("");
Console.WriteLine("");


#region Stack
//LIFO : Last In First Out
Stack<int> stack = new Stack<int>();

//Push elements into the stack
stack.Push(1);
stack.Push(2);
stack.Push(3);

//Peek at the top element
int topElement = stack.Peek();
Console.WriteLine("Top element in the stack: %d", topElement);

//Pop elements from the Stack
int popElement1 = stack.Pop();
int popElement2 = stack.Pop();

//Display popped elements
Console.WriteLine("Popped Element 1: " + popElement1);
Console.WriteLine("Popped Element 2: " + popElement2);

//Peek again to see top element
int newTopElement = stack.Peek();
Console.WriteLine("Top element in the stack: %d", newTopElement);

#endregion

#region Queue
//FIFO : First In First Out
Queue<int> queue = new Queue<int>();

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);

// Dequeue and process elements in FIFO order
while (queue.Count > 0)
{
    int item = queue.Dequeue();
    Console.WriteLine($"Dequeued: {item}");
}
Console.WriteLine("");


#endregion

app.Run();

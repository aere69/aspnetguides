# ASPNet Core - Data Structures

## Primitive types

- int: Represents signed integers
- short: Represents short integers
- float: Represents single-precision floating-point numbers
- char: Represents a single Unicode character
- bool: Represents a logical value, which can be true or false

## Composite types

- Arrays: Arrays are composite data structures that store a collection of elements of the same type. Elements in an array are accessed through numeric indices.
- Dictionaries: The Dictionary<TKey, TValue> class represents a collection of key-value pairs, where each key is unique. It allows efficient retrieval of values based on their keys.
- Queues and stacks: The queue and stack data structures are used to organize data according to the principle of “first in, first out” (queue) or “last in, first out” (stack).
- Tuples: Tuples are data structures that can store a heterogeneous collection of elements of different types. They are useful when you need to group related values together but don’t want to create a custom class.
- Interfaces: Although they do not store data directly, interfaces are composite types that define contracts for classes that must implement certain methods and properties.

## What are Data Structures?

Data structures are a way of organizing and storing data in a structured and efficient way so that it can be accessed and manipulated easily.

Data structures define how data is organized, stored and operated in a computer’s memory.

## Arrays

An array is used to store a collection of elements of the same data type under a single variable name. These elements are stored in contiguous memory locations, making their access and manipulation efficient. Each element in an array is identified by an index or position, starting from 0 for the first element, 1 for the second, and so on.

Arrays are commonly used to store lists of data, such as numbers, strings or objects.

### Advantages

- Efficient access: Access to the elements of an array is fast and constant (O(1)) because you can directly access an element through its index.
- Memory efficiency: Arrays allocate memory for a fixed number of elements, which can be more memory efficient than other data structures such as linked lists or dynamic arrays.
- Sequential storage: The elements of an array are stored sequentially in memory, making them ideal for situations where data needs to be accessed in order.
- Predictable performance: Accessing elements in an array has consistent and predictable performance characteristics, which makes it suitable for many applications.
- Simple syntax: Most programming languages have straightforward syntax for creating, initializing and accessing arrays, making them easy to work with.
- Fixed size: In some cases, having a fixed-size array can be an advantage because it enforces a limit on the number of elements, which can help prevent memory issues and improve predictability.

### Limitations

Mainly with regard to size.

### Disadvantages

- Fixed size: The fixed size of arrays can also be a disadvantage when the number of elements is unknown or can change over time. Resizing an array can be inefficient and may require creating a new, larger array and copying elements.
- Wasted memory: Arrays allocate memory for the maximum number of elements they can hold, even if the actual number of elements is smaller. This can lead to wasted memory if the array size significantly exceeds the data size.
- Inefficient insertions and deletions: Inserting or deleting elements in the middle of an array can be inefficient because it requires shifting elements to accommodate the change, resulting in a time complexity of O(n), where n is the number of elements.
- Lack of built-in functions: Arrays often lack built-in functions for common operations like searching, sorting or filtering. You may need to implement these functions manually or use external libraries.
- Homogeneous elements: Arrays typically store elements of the same data type. If you need to store elements of different types, you might need to use an array of objects or a more complex data structure.
- Inflexible data structures: Arrays are not always the best choice for complex data structures or when you need dynamic resizing, efficient insertions/deletions or key-value associations (which are better handled by data structures like lists, dictionaries or hash tables).

## Types of Arrays

- One-dimensional arrays (1-D arrays):
Also known as a vector, it is an array with only one dimension. Elements are organized linearly.
- Two-dimensional arrays (2-D arrays):
Also called a matrix, a two-dimensional array is organized into rows and columns. It can be viewed as a table or grid.
- Three-dimensional array (3-D arrays):
A three-dimensional array is organized into layers, rows and columns. It can be useful for representing three-dimensional data, such as cubes.

## Where to Use Arrays?

Arrays are used to store and manipulate collections of data.

- Storing lists of data: Arrays are often used to store collections of data such as numbers, strings or objects. For example, you can use an array to store a list of integers that represent test scores.
- Sorting and searching: Arrays can be used for sorting and searching operations. You can sort an array of elements in ascending or descending order using algorithms like bubble sort or quicksort. Search algorithms such as binary search can be applied to find specific elements in sorted arrays efficiently.
- Implementing data structures: Arrays are building blocks for implementing more complex data structures such as lists, stacks, queues and hash tables. Many data structures rely on arrays to store and manage their elements.
- Arrays and grids: Two-dimensional arrays are commonly used to represent matrices and grids. They are useful in graphics programming, game development and scientific simulations.
- Input/output handling: Arrays are used to buffer data read from or written to files, databases or network sockets. This allows efficient processing of data in blocks.
- Algorithm implementation: Many algorithms, such as dynamic programming or backtracking, use arrays to store intermediate results or memorization tables.
- Managing collections: Arrays can be used to store collections of objects or data structures. For example, you can use arrays to implement a simple database, a contact list or a book collection in a library management system.
- Graphics and game development: Arrays are essential for storing and manipulating pixel data, managing game state, and creating levels and game maps.

## Linked Lists

A linked list is a data structure consisting of a sequence of elements, where each element (node) contains a value and a reference (or link) to the next element in the sequence.

Thus we can define that each node contains the following elements:

Data - Each node can store data.
Address − Each node contains an address for the next node, called Next.
Head − The first node of a linked list is referenced by a pointer called Head.

There are three main types of linked lists:

1. Singly Linked Lists
2. Double Linked Lists
3. Circular Linked Lists

### Singly Linked Lists

Each node contains a value and a reference to the next node in the list. The last node in the list usually has a reference to null, indicating the end of the list.

Singly linked lists are efficient for operations that involve adding or removing elements from the beginning of the list, but less efficient for operations that involve accessing elements by index.

### Double Linked Lists

Each node contains two links—the first points to the previous node, and the second points to the next node in the sequence.

The previous pointer of the first node and the next pointer of the last node will point to null.

### Circular Linked Lists

The last element (node) of the list points back to the first element, forming a closed loop or cycle.

In other words, unlike a traditional linear linked list, where the “next” pointer to the last element is typically set to null, in a circular linked list, the “next” pointer to the last element points to the first element of the list.

## Stacks

A “stack” is an abstract data type that follows the Last-In-First-Out (LIFO) principle and is represented by a collection of elements that has the following main operations:

- Push: This operation adds an element to the top of the stack.
- Pop: This operation removes and returns the top element from the stack.
- Peek (or Top): This operation allows you to view the top element of the stack without removing it.

Stacks are commonly used to manage data collections where insertion and removal order is important.

The most recently added item is the first to be removed.

## Queues

Elements are added to one end (back) and removed from the other end (front).

A queue follows the “first in, first out” (FIFO) principle, which means that the element that has been in the queue the longest is the first to be removed.

A queue has two main operations:

- Enqueue (also known as “push” or “insert”): This operation adds an element to the end of the queue.
- Dequeue (also known as “pop” or “remove”): This operation removes and returns the element at the beginning of the queue.

In addition to these fundamental operations, queues often also provide methods for checking whether the queue is empty and for inspecting the element in front without removing it, commonly called “peek” or “front.”

We can use queues in a wide variety of scenarios, including:

- Task scheduling: Queues can be used to manage tasks or jobs to be performed in a specific order.
- Print job management: In a print queue, print jobs are processed in the order they are received.
- Breadth First Search (BFS) algorithm: Queues are often used to traverse and search breadth-first graphs or trees.

Common variations of queues include priority queues (where elements have associated priorities), double queues (deque or dequeues) and circular queues, each with their own specific use cases and variations in behavior.

## Tree Data Structures

Trees are a type of data structure used to represent hierarchical relationships between elements.

Examples: Binary trees, AVL trees, red-black trees, B trees and others

## Binary Trees

Data structures where each node has at most two child nodes, typically referred to as the left and right child. Binary trees can be used in various applications, including binary search and expression trees.

We can perform the following operations on binary trees:

1. Insert an element
2. Remove an element
3. Search for an element
4. Delete from an element
5. Traversing an element

### Binary Tree Traversals

Tree traversal algorithms can be classified into two main categories:

- Depth-first search (DFS) algorithms
- Breadth-first search (BFS) algorithms

Traversing a binary tree means visiting each tree node in a specific order. There are different ways to traverse a binary tree, and the choice of traversal method depends on the specific task you want to perform. The three most common binary tree traversal methods are:

    1. **In-Order Traversal**

    In an in-order traversal, you visit the nodes of the tree in the following order:

    - Visit the left subtree.
    - Visit the current node.
    - Visit the right subtree.

    In a binary search tree (BST), an in-order traversal will visit the nodes in ascending order, which is useful for tasks like retrieving elements in sorted order.

    2. **Pre-Order Traversal**

    In a pre-order traversal, you visit the nodes of the tree in the following 
    order:

    - Visit the current node.
    - Visit the left subtree.
    - Visit the right subtree.

    Pre-order traversal is useful for creating a copy of the tree or serializing it into a format that can be easily reconstructed.

    3. **Post-Order Traversal**

    In a post-order traversal, you visit the nodes of the tree in the following order:

    - Visit the left subtree.
    - Visit the right subtree.
    - Visit the current node.

    Post-order traversal is commonly used for deleting all nodes in the tree or for evaluating expressions in a mathematical expression tree.

## Binary Search Tree

Binary search is a search algorithm that can be applied to a sorted array or a binary search tree (BST).

## Heap Data Structures

A heap in data structures refers to a specialized data structure that is used to store and manage elements in a way that allows the highest priority element to be easily accessed and removed.

There are two main types of heaps:

- “binary heap”
- “Fibonacci heap.”

## Binary Heap

A binary heap is a special binary tree that meets two main properties:

1. Partial order property: For each node in the tree, the key (value) stored in the node is greater (or smaller, depending on the heap type) than the keys stored in its children. This means that the highest priority element will be at the root of the tree.
2. Complete tree structure: The tree is filled from left to right at all levels, except possibly the last level, which is filled from left to right.

In binary heaps, we have two main types:

    1. **Max-heap:** In a max-heap, the element with the highest value (key) has the highest priority. This means that the root of the tree is the highest valued element and all elements are smaller than the parent. Therefore, as you remove elements from the max-heap, the largest elements are processed first.

    Uused when you need to find the highest value element quickly, also useful in sorting algorithms like Heapsort where you need to sort in descending order.

    2. **Min-heap:** In a min-heap, the element with the lowest value (key) has the highest priority. This means that the root of the tree is the element with the lowest value and all elements are greater than the parent. Therefore, as you remove elements from the min-heap, the smaller elements are processed first.

    Used when you need to find the lowest value element quickly.

The choice between using a max-heap or a min-heap depends on the needs of your algorithm or application.

Implementing a max-heap or min-heap in C# can be accomplished using a class like `PriorityQueue` from the `System.Collections.Generic` library

## Hashing Data Structures

Hashing involves transforming input data into a fixed-size value, often called a “hash” or “hash code,” using a mathematical function known as a hash function.

The main feature of hash functions is that they produce a fixed-size output regardless of the size of the input. This hash is used to represent the original input in a compact way, facilitating efficient searching and storing of data in data structures such as hash tables.

The biggest advantage of using hashing data structures is that they allow you to store data and search it in constant time, that is, in O(1) time.

Hash functions must meet some important properties:

- **Deterministic**: For the same input, a hash function must always produce the same hash.
- **Efficient**: The hash function must be computationally efficient to calculate the hash of an input.
- **Uniform distribution**: The hash function must distribute the hash values evenly, to minimize collisions (when two different inputs have the same hash).
- **Irreversible**: It must be difficult or impossible to regenerate the original input from the hash (this is important for cryptographic hash functions).

The hash is basically made up of three components:

1. **Key**: The key is the value you want to store or fetch from the hash data structure. It is used as input to the hash function to calculate the index where the associated value will be stored or looked up in the hash table.
2. **Hash function**: The hash function is the mathematical formula or algorithm that transforms the key into a hash value (index) in the hash table. This function is designed to be deterministic and to distribute keys in order to minimize collisions evenly.
3. **Hash table**: The hash table is the data structure that stores the values associated with the keys. It consists of an array of lists, where each list is associated with an index generated by the hash function. When you want to store or look up a value, the hash function is used to determine which list of the hash table the value should be stored or looked up in.

To implement the creation of a hash table in C#, we can use the `Hashtable` class which is part of the `System.Collections` set.

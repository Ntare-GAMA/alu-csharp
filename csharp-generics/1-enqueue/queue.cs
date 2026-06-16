using System;

/// <summary>
/// Represents a generic first-in-first-out (FIFO) collection.
/// </summary>
/// <typeparam name="T">The type of elements stored in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Represents a single node in the queue's underlying linked list.
    /// </summary>
    public class Node
    {
        /// <summary>The value stored in this node.</summary>
        public T value;

        /// <summary>A reference to the next node in the queue.</summary>
        public Node next;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="value">The value to store in the node.</param>
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    /// <summary>The first node in the queue.</summary>
    public Node head;

    /// <summary>The last node in the queue.</summary>
    public Node tail;

    /// <summary>The number of elements currently in the queue.</summary>
    public int count;

    /// <summary>Returns the type of elements stored in the queue.</summary>
    /// <returns>The <see cref="Type"/> of <typeparamref name="T"/>.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>Adds a value to the end of the queue.</summary>
    /// <param name="value">The value to add to the queue.</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (count == 0)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }

        count++;
    }

    /// <summary>Returns the number of elements currently in the queue.</summary>
    /// <returns>The number of elements in the queue.</returns>
    public int Count()
    {
        return count;
    }
}
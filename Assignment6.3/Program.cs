// Test the CallerQueue
var queue = new CallerQueue();

// Test 1: Enqueue and Peek single caller
Console.WriteLine("Test 1: Enqueue and Peek");
var caller1 = new Caller { PhoneNumber = "555-0001", Name = "Alice" };
queue.Enqueue(caller1);
Console.WriteLine($"Peeked: {queue.Peek().Name} ({queue.Peek().PhoneNumber})");
Console.WriteLine();

// Test 2: Enqueue multiple callers
Console.WriteLine("Test 2: Enqueue multiple callers");
queue.Enqueue(new Caller { PhoneNumber = "555-0002", Name = "Bob" });
queue.Enqueue(new Caller { PhoneNumber = "555-0003", Name = "Charlie" });
queue.Enqueue(new Caller { PhoneNumber = "555-0004" }); // Caller with no name
Console.WriteLine($"Peeked: {queue.Peek().Name ?? "(No Name)"} ({queue.Peek().PhoneNumber})");
Console.WriteLine();

// Test 3: Dequeue operations (FIFO order)
Console.WriteLine("Test 3: Dequeue operations (FIFO)");
while (true)
{
    try
    {
        var caller = queue.Dequeue();
        Console.WriteLine($"Dequeued: {caller.Name ?? "(No Name)"} ({caller.PhoneNumber})");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"Exception caught: {ex.Message}");
        break;
    }
}
Console.WriteLine();

// Test 4: Peek on empty queue
Console.WriteLine("Test 4: Peek on empty queue");
try
{
    queue.Peek();
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Exception caught: {ex.Message}");
}
Console.WriteLine();



public class Caller
{
    public required string PhoneNumber;
    public string? Name;
}

public class CallerQueue()
{
    internal class QueueNode
    {
        internal required Caller Data { get; set; }
        internal QueueNode? Next { get; set; } = null;
    }

    private QueueNode? _head = null, _tail = null;

    public Caller Dequeue()
    {
        // delete front
        if (_head == null)
        {
            throw new InvalidOperationException("Dequeue: No Items in queue");
        }

        Caller result = _head.Data;

        _head = _head.Next;

        // If Queue is now empty, _tail still points to the dequeued node
        // _tail needs to be manually null'ed in this case
        if(_head == null)
        {
            _tail = null;
        }

        return result;
    }

    public Caller Peek()
    {
        if(_head == null)
        {
            throw new InvalidOperationException("Peek: No Items in queue");
        }

        return _head.Data;
    }

    public void Enqueue(Caller c)
    {
        // add to back

        // This happens when Queue is empty,
        // _head needs to be manually updated in this case
        if(_tail == null)
        {
            _head = _tail = new QueueNode() { Data = c };
        }
        else
        {
            _tail.Next = new QueueNode() { Data = c };
            _tail = _tail.Next;
        }
    }
}




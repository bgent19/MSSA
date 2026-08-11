Console.WriteLine("Stack Functionality Tests");
Console.WriteLine();

// Test 1: Basic Push and Pop
Console.WriteLine("Test 1: Basic Push and Pop");
var stack = new FixedIntStack(5);
stack.Push(10);
stack.Push(20);
stack.Push(30);
Console.WriteLine($"  Pushed: 10, 20, 30 | Count: {stack.Count()}");
Console.WriteLine($"  Pop: {stack.Pop()} (expected 30)");
Console.WriteLine($"  Count after pop: {stack.Count()}");
Console.WriteLine();

// Test 2: Peek (doesn't remove)
Console.WriteLine("Test 2: Peek");
Console.WriteLine($"  Peek: {stack.Peek()} (expected 20)");
Console.WriteLine($"  Count after peek: {stack.Count()} (unchanged)");
Console.WriteLine();

// Test 3: LIFO order
Console.WriteLine("Test 3: LIFO Order");
Console.WriteLine($"  Pop: {stack.Pop()} (expected 20)");
Console.WriteLine($"  Pop: {stack.Pop()} (expected 10)");
Console.WriteLine($"  IsEmpty: {stack.IsEmpty}");
Console.WriteLine();

// Test 4: Full stack exception
Console.WriteLine("Test 4: Full Stack Exception");
stack = new FixedIntStack(2);
stack.Push(1);
stack.Push(2);
try
{
    stack.Push(3);
    Console.WriteLine("  ERROR: Should have thrown exception");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"  Caught: {ex.Message}");
    Console.WriteLine();
}

// Test 5: Empty stack exception
Console.WriteLine("Test 5: Empty Stack Exception");
stack = new FixedIntStack(3);
try
{
    stack.Pop();
    Console.WriteLine("  ERROR: Should have thrown exception");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"  Caught: {ex.Message}");
    Console.WriteLine();
}

// Test 6: Multiple operations
Console.WriteLine("Test 6: Multiple Operations");
stack = new FixedIntStack(5);
stack.Push(5);
stack.Push(15);
stack.Push(25);
Console.WriteLine($"  After push 5,15,25: Count = {stack.Count()}");
stack.Pop();
stack.Push(35);
Console.WriteLine($"  After pop and push 35: Count = {stack.Count()}");
Console.WriteLine($"  Top element: {stack.Peek()} (expected 35)");
Console.WriteLine();


class FixedIntStack
{
    private readonly int[] _arr;
    public int Capacity { get; }

    private int _top;

    public bool IsEmpty { get; private set; }

    public FixedIntStack(int cap)
    {
        Capacity = cap;
        _arr = new int[cap];
        _top = 0;
        IsEmpty = true;
    }

    public int Pop()
    {
        if(IsEmpty == true)
        {
            throw new InvalidOperationException("Cannot pop on an empty stack.");
        }

        int result = _arr[_top--];

        if(_top == -1)
        {
            _top = 0;
            IsEmpty = true;
        }

        return result;
    }

    public void Push(int val)
    {
        if(_top == Capacity - 1)
        {
            throw new InvalidOperationException("Cannot push onto a full stack.");
        }

        if(IsEmpty)
        {
            IsEmpty = false;
            _arr[_top] = val;
        }
        else
        {
            _arr[++_top] = val;
        }
    }
    public int Peek()
    {
        if (IsEmpty == true)
        {
            throw new InvalidOperationException("There is nothing on the stack to peek at.");
        }

        return _arr[_top];
    }

    public int Count()
    {
        return IsEmpty ? 0: _top + 1;
    }
}
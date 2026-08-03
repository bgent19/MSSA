Console.WriteLine(isPalindromic(121)); // true
Console.WriteLine(isPalindromic(-121)); // false
Console.WriteLine(isPalindromic(10)); // false


static bool isPalindromic(int x)
{
    if(x < 0)
    {
        return false;
    }


    Stack<int> reverse = new();
    Queue<int> forward = new();

    while(x > 0)
    {
        int n = x % 10;
        reverse.Push(n);
        forward.Enqueue(n);
        x /= 10;
    }

    while(reverse.Count > 0)
    {
        if(reverse.Pop() != forward.Dequeue())
        {
            return false;
        }

    }

    return true;
}
//example 1: [1,2,3,4,5]
//example 2: [1,2]
//example 3: []

// Example 1: [1,2,3,4,5]
ListNode example1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
Console.Write("Example 1 original: ");
PrintList(example1);
Console.WriteLine();
ListNode reversed1 = ReverseList(example1);
Console.Write("Example 1 reversed: ");
PrintList(reversed1);
Console.WriteLine("\n");

// Example 2: [1,2]
ListNode example2 = new ListNode(1, new ListNode(2));
Console.Write("Example 2 original: ");
PrintList(example2);
Console.WriteLine();
ListNode reversed2 = ReverseList(example2);
Console.Write("Example 2 reversed: ");
PrintList(reversed2);
Console.WriteLine("\n");

// Example 3: []
ListNode example3 = null;
Console.Write("Example 3 original: ");
PrintList(example3);
Console.WriteLine();
ListNode reversed3 = ReverseList(example3);
Console.Write("Example 3 reversed: ");
PrintList(reversed3);
Console.WriteLine("\n");

ListNode ReverseList(ListNode head)
{
    ListNode newHead = null;

    while (head != null)
    {
        ListNode temp = head;
        head = head.next;
        temp.next = newHead;
        newHead = temp;
    }

    return newHead;
}

void PrintList(ListNode head)
{
    if(head == null)
    {
        Console.Write("(empty)");
        return;
    }

    ListNode i = head;

    while (i != null)
    {
        Console.Write(i.val);

        if (i.next != null)
        {
            Console.Write(", ");
        }

        i = i.next;
    }
}


//Definition for singly - linked list.
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
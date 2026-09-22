ListNode list = ListFromArray([1, 2, 2, 1]);
Console.WriteLine(IsPalindrome(list)); // True

list = ListFromArray([1, 2]);
Console.WriteLine(IsPalindrome(list)); // false


static bool IsPalindrome(ListNode head)
{

    Stack<int> reversed = new();

    ListNode itr = head;

    while (itr != null)
    {
        reversed.Push(itr.val);
        itr = itr.next;
    }

    itr = head;

    while (itr != null)
    {
        if (reversed.Pop() != itr.val)
        {
            return false;
        }
        itr = itr.next;
    }


    return true;
}

static ListNode ListFromArray(int[] array)
{
    ListNode head = null;

    foreach(int num in array.Reverse())
    {
        ListNode toAdd = new() { val = num, next = head };
        head = toAdd;
    }

    return head;
}

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


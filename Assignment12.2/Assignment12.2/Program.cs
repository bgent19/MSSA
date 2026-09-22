// head = [1, 2, 6, 3, 4, 5, 6]

ListNode head = new() { val = 1,
                        next = new()
                        {
                            val = 2,
                            next = new()
                            {
                                val = 6,
                                next = new()
                                {
                                    val = 3,
                                    next = new()
                                    {
                                        val = 4,
                                        next = new()
                                        {
                                            val = 5,
                                            next = new() { val = 6, next = null }
                                        }
                                    }
                                }
                            }
                        }
};

head = RemoveElements(head, 6);

PrintList(head);

static ListNode RemoveElements(ListNode head, int val)
{
    for (ListNode itr = head, prev = null; itr != null; itr = itr.next)
    {
        if (itr.val == val)
        {
            if (prev == null)
            {
                head = itr.next;
            }
            else
            {
                prev.next = itr.next;
            }
        }
        else
        {
            prev = itr;
        }
    }

    return head;

}

static void PrintList(ListNode head)
{
    ListNode itr = head;

    while(itr != null)
    {
        Console.Write(itr.val);

        if(itr.next != null)
        {
            Console.Write(", ");
        }

        itr = itr.next;
    }
}


public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}


using System.Collections;
using System.Collections.Generic;

LinkedList myList = new();

myList.AddLast(new House() { HouseNumber = 1, StreetName = "Winning Drive", TypeOfHouse = "Facility" });
myList.AddLast(new House() { HouseNumber = 2, StreetName = "First Loser Lane", TypeOfHouse = "Sad" });

Console.WriteLine(SearchByNumber(myList, 2));
Console.WriteLine(SearchByNumber(myList, 3));

House? SearchByNumber(LinkedList l, int num)
{
    foreach (House h in myList)
    {
        if(h.HouseNumber == num)
        {
            return h;
        }
       
    }

    return null;
}




class House
{
    public int HouseNumber { get; set; }
    public string? StreetName { get; set; }

    public string? TypeOfHouse { get; set; }

    public override string ToString()
    {
        return $"{HouseNumber} {StreetName} ({TypeOfHouse})";
    }
}

class ListNode
{
    public House Data { get; set; }
    public ListNode? Next { get; set; }

    public ListNode(House data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList : IEnumerable<House>
{
    private ListNode? _head;
    public int Count { get; private set; }

    public void AddLast(House data)
    {
        ListNode newNode = new ListNode(data);

        // empty list
        if(_head == null)
        {
            _head = newNode;
        }
        else
        {
            ListNode cur = _head;
            while(cur.Next != null)
            {
                cur = cur.Next;
            }
            cur.Next = newNode;
        }

        Count++;
    }

    public IEnumerator<House> GetEnumerator()
    {
        ListNode cur = _head;
        while (cur != null)
        {
            yield return cur.Data;
            cur = cur.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

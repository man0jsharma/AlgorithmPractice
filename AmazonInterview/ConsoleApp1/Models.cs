using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmzMain
{
    public class Point : List<Point>
    {
        public int XAxis { get; set; }
        public int YAxis { get; set; }
        public int Value { get; set; }

        public bool IsVisited { get; set; }
        public Point(int x, int y, int value)
        {
            XAxis = x;
            YAxis = y;
            Value = value;
        }
    }


    public class myLinkedList<T>
    {
        public T data { get; set; }
        public myLinkedList<T> Next { get; set; }

        public myLinkedList()
        {

        }
        public myLinkedList(T val)
        {
            data = val;
        }
    }

    public class EmployeeParkingInfo
    {
        public string EmployeeName { get; set; }
        public string FromBuildingName { get; set; }
        public string ToBuildingName { get; set; }
    }

    public class BinaryTree<T>
    {
        public bool IsVisited { get; set; }

        public T Node { get; set; }
        public BinaryTree<T> Left { get; set; }

        public BinaryTree<T> Right { get; set; }
    }


    public class Node<T>
    {
        public Node<T> next;
        public T data;
    }

    public class LinkedList
    {
        private Node<int> head;

        public void printAllNodes()
        {
            Node<int> current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void AddFirst(int data)
        {
            Node<int> toAdd = new Node<int>();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }

        public void AddLast(int data)
        {
            if (head == null)
            {
                head = new Node<int>();

                head.data = data;
                head.next = null;
            }
            else
            {
                Node<int> toAdd = new Node<int>()
                {
                    data = data
                };
                Node<int> current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }

        
    }

    public class Equation
    {
        public string LHS { get; set; }
        public string RHS { get; set; }
    }


    public class Interval
    {
        public int Start { get; set; }

        public int End { get; set; }


        public bool IsDealt { get; set; }
        public Interval(int Start, int End)
        {
            this.Start = Start;
            this.End = End;
        }
    }

    public class PriorityQueue<T>
    {
        private List<T> Items { get; set; }

        private List<int> Priorities { get; set; }

        public PriorityQueue()
        {
            this.Items = new List<T>();
            this.Priorities = new List<int>();
        }

        public int Push(T itemToInsert, int Rank)
        {
            var i = 0;
            foreach(var priority in Priorities)
            {
                if(priority > Rank)
                {
                    Items.Insert(i, itemToInsert);
                    Priorities.Insert(i, Rank);
                    return i;
                }
                ++i;
            }
            Items.Add(itemToInsert);
            Priorities.Add(Rank);
            return Items.Count - 1;
        }

        public T Pop()
        {
            if (Items.Count == 0) return default(T);
            var lastElement = Items[Items.Count - 1];
            Items.Remove(lastElement);
            Priorities.Remove(Priorities[Priorities.Count - 1]);
            return lastElement;
        }

        internal bool IsEmpty()
        {
            return Items.Count == 0;
        }
    }
}


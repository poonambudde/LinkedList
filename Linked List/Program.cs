using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Data structure program using Linked List");

            LinkListOperation linklistOperation = new LinkListOperation();
            linklistOperation.Add(56);
            linklistOperation.Add(30);
            linklistOperation.Add(70);
            linklistOperation.Display();
            linklistOperation = new LinkListOperation();
            linklistOperation.Add2(70);
            linklistOperation.Add2(30);
            linklistOperation.Add2(56);
            linklistOperation.Display();
            linklistOperation = new LinkListOperation();
            linklistOperation.Add(56);
            linklistOperation.Add(70);
            linklistOperation.Display();
            Console.WriteLine("\n");
            linklistOperation.InsertAtParticularPoistion(2, 30);
            linklistOperation.Display();
            Console.WriteLine("First element is poped out from linked list = " + linklistOperation.removeFirstNode().data);
            linklistOperation.Display();
            linklistOperation.InsertAtParticularPoistion(1, 56);
            linklistOperation.Display();
            Console.WriteLine("Last element is poped out from linked list = " + linklistOperation.removeLastNode().data);
            linklistOperation.Display();
            SortedLinkedList sortedLinkedList = new SortedLinkedList();
            sortedLinkedList.Add(56);
            sortedLinkedList.Add(30);
            sortedLinkedList.Add(40);
            sortedLinkedList.Add(70);
            sortedLinkedList.Display();
        }
    }
}

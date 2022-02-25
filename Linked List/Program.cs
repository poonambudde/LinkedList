using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Data structure program using Linked List");

            LinkListOperation listOperation = new LinkListOperation();
            listOperation.Add(70);
            listOperation.Add(30);
            listOperation.Add(56);
            listOperation.display();
        }
    }
}

using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Data structure program using Linked List");

            LinkListOperation listOperation = new LinkListOperation();
            listOperation.insert(56);
            listOperation.insert(30);
            listOperation.insert(70);
            listOperation.display();
        }
    }
}

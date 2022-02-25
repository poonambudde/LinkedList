using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Data structure program using Linked List");

            LinkListOperation listOperation = new LinkListOperation();
            listOperation.append(56);
            listOperation.append(30);
            listOperation.append(70);
            listOperation.display();
        }
    }
}

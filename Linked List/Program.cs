using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Data structure program using Linked List");

            //Ablity To Create Linked List By Appending
            LinkListOperation linkistOperation = new LinkListOperation();
            linkistOperation.Add(56);
            linkistOperation.Add(30);
            linkistOperation.Add(70);
            linkistOperation.Display();
            linkistOperation = new LinkListOperation();
            linkistOperation.Add2(70);
            linkistOperation.Add2(30);
            linkistOperation.Add2(56);
            linkistOperation.Display();
            linkistOperation = new LinkListOperation();
            linkistOperation.Add(56);
            linkistOperation.Add(70);
            linkistOperation.Display();
            Console.WriteLine("\n");
            linkistOperation.InsertAtParticularPoistion(2, 30);
            linkistOperation.Display();
            Console.WriteLine("First element is poped out from linked list = " + linkistOperation.removeFirstNode().data);
            linkistOperation.Display();
        }
    }
}
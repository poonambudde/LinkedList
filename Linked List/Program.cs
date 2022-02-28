using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Data structure program using Linked List");

            LinkListOperation linklistoperation = new LinkListOperation();
            //linklistoperation.Add(56);
            //linklistoperation.Add(30);
            //linklistoperation.Add(70);
            //linklistoperation.Display();
            //linklistoperation = new LinkListOperation();
            //linklistoperation.Add2(70);
            //linklistoperation.Add2(30);
            //linklistoperation.Add2(56);
            //linklistoperation.Display();
            //linklistoperation = new LinkListOperation();
            //linklistoperation.Add(56);
            //linklistoperation.Add(70);
            //linklistoperation.Display();
            //Console.WriteLine("\n");
            //linklistoperation.InsertAtParticularPoistion(2, 30);
            //linklistoperation.Display();
            //Console.WriteLine("First element is poped out from linked list = " + linklistoperation.removeFirstNode().data);
            //linklistoperation.Display();
            //linklistoperation.InsertAtParticularPoistion(1, 56);
            //Console.WriteLine("last element is poped out from linked list = " + linklistoperation.removeLastNode().data);
            //linklistoperation.Display();
            //linklistoperation.Add(70);
            //Console.WriteLine("The list before inserting 30 is : ");
            //linklistoperation.Display();
            //linklistoperation.InsertAtParticularPoistion(2, 30);
            ////Console.WriteLine("The list after inserting 30 is : ");
            ////list.Display();
            ////list.InsertAtParticularPoistion(3, 40);
            ////Console.WriteLine("The list after inserting 40 is :  ");
            //linklistoperation.Display();
            linklistoperation.Add(56);
            linklistoperation.Add(30);
            linklistoperation.Add(70);
            linklistoperation.Display();
            linklistoperation.InsertAtParticularPoistion(3, 40);      //insert 40 after 30
            linklistoperation.Display();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class LinkListOperation
    {
        internal Node head;

        // Add methode to add the specific data into linked list
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("inserted into the linked list", node.data);
        }
        
        // Add2 methode to add the specified data into linked list
        public void Add2(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                node.next = head;
                this.head = node;
            }
            Console.WriteLine("inserted into the linked list", node.data);
        }

        // Display methode for display the specific data
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            Console.WriteLine("Squence of linked list");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        // Inserts at particular poistion i,e 2
        public Node InsertAtParticularPoistion(int poistion, int data)
        {
            if (poistion < 1)
                Console.WriteLine("Invalid Poistion");
            if (poistion == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (poistion-- != 0)
                {
                    if (poistion == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (poistion != 1)
                    Console.WriteLine("poistion out of range");
            }
            return head;
        }
        public Node removeFirstNode()
        {
            if (this.head == null)
                return null;
            Node temp = head;
            head = head.next;
            return temp;
        }
    }
}



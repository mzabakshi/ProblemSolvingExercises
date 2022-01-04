using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LinkedList
{
    public class LinkedList
    {

        public Node head;

        public void PrintList()
        {
            Node n = head;
            while (n != null)
            {
                Console.Write(n.data + " ");
                n = n.next;
            }
        }

        /// <summary>
        /// Inserts node in the begning
        /// </summary>
        /// <param name="data"></param>
        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        /// <summary>
        /// Inserts new node after a selected node
        /// </summary>
        /// <param name="prevNode"></param>
        /// <param name="data"></param>
        public void InsertAfter(Node prevNode, int data)
        {
            if (prevNode == null)
            {
                Console.WriteLine("Previous node can not be empty");
                return;
            }

            Node newNode = new Node(data);
            newNode.next = prevNode.next;
            prevNode.next = newNode;
        }

        /// <summary>
        /// Adds the new node to the last
        /// </summary>
        /// <param name="data"></param>
        public void Append(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = new Node(data);
                return; 
            }

            Node prev = null;
            Node temp = head;
            while (temp != null)
            {
                prev = temp;
                temp = temp.next;
            }
            prev.next = newNode;
            temp = prev.next;
        }


        public class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }
    }
}

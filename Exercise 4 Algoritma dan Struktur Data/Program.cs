﻿using System;

namespace Exercise_4
{
    
    class Node
    {
        public int info;
        public Node next;
        public Node(int i, Node n)
        {
            info = 1;
            next = n;
        }
    }

    class Stacks
    {
        Node top;
        public Stacks()
        {
            top = null;
        }

        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }

        public void push(int element)
        {
            Node fresh;
            fresh = new Node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + " pushed.");
        }

        public void pop()
        {
            Console.WriteLine("\nThe popped element is: " + top.info);
            top = top.next; 
        }

       public void display()
        {
            Node tmp;
            if (empty()) 
                Console.WriteLine("\nStack Empty");
            else
            {
                for(tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
                Console.WriteLine();
            }
        }

    }
}



    
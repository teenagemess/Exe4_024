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
        static readonly int MAX = 42;
        int top;
        int[] stack = new int[MAX];
        public Stacks()
        {
            top = -1;
        }

        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }

        public bool push(int element)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = element;
                return true;
            }
            Console.WriteLine("\n" + element + " pushed.");
        }

        internal int pop()
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
        
        static void Main(string[] args)
        {
            Stacks s = new Stacks();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***\n");
                Console.WriteLine("1. Push.");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.WriteLine("\nEnter your choice: ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        Console.Write("\nEnter a number: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.push(num);
                        break;
                    case '2':
                        if (s.empty())
                        {
                            Console.WriteLine("\nStack Empty");
                            break;
                        }
                        s.pop();
                        break;
                    case '3':
                        s.display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }

            }
        }
    }
}



    
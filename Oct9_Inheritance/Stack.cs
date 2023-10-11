using Microsoft.VisualBasic;
using System;
using System.Collections;

namespace Global
{
    class Stack
    {
        ArrayList list1 = new ArrayList();

        public void push(object obj)
        {
            if(obj == null)
            {
                throw new InvalidOperationException("Cannot store NULL on the stack");
            }
            else
            {
                list1.Add(obj); 
            }
        }

        public object pop() {
            if (list1.Count <= 0)
            {
                Console.WriteLine("Stack Underflow");

            }
            else
            {
                Console.WriteLine($"Popped the {list1[list1.Count - 1]}");
                list1.Remove(list1[list1.Count - 1]);
            }
            return list1;
        }

        public void clear()
        {
            list1.Clear();
        }
    }
    //class Program
    //{
    //   static void Main(string[] args) { 

    //        Stack stack = new Stack();

    //        stack.push(1);
    //        stack.push(2);
    //        stack.push("Akshat");
    //        //stack.push(null);

    //        stack.pop();
    //        stack.pop();
    //        stack.pop();
    //        stack.pop();
    //        //stack.clear();

    //        //Console.WriteLine();

    //    }

    }
//}
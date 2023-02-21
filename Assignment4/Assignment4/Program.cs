using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class StackException : Exception
    {
        public StackException(string message) : base(message)
        {

        }
    }
    public class Stack
    {
        static int max = 3;
        static int[] array = new int[max];
        int top;
        int count;

        public Stack()
        {
            top = -1;
        }

        public bool Push(int value)
        {

            if (count >= max)
            {
                throw new StackException("Stack Overflow");

            }
            else
            {
                array[++top] = value
                    ;
                ++count;
                return true;
            }
        }
        public int Pop()
        {
            if (top < 0)
            {
                throw new StackException("Stack Underflow");
                //return 0;
            }
            else
            {
                int value = array[top--];
                count--;
                Console.WriteLine("{0} Popped from stack", value);
                return value;
            }

        }
        public void PrintStack()
        {
            if (top < 0)
            {
                throw new StackException("Stack Underflow");

            }
            else
            {
                Console.WriteLine("Values in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }

    }
    public class MyStack : Stack
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Enter your Choice  1)Push 2)Pop  3)Print  4)Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter number of elements you want to push:");
                        int element = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter number to push into Stack:");
                        int num = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < element; i++)
                        {
                            try
                            {
                                stack.Push(num);
                            }
                            catch (StackException e)
                            {
                                Console.WriteLine("StackExecption: {0}", e.Message);
                            }

                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter number of elements you want to POP():");
                        int ele = Convert.ToInt32(Console.ReadLine());
                        for (int j = 0; j < ele; j++)
                        {
                            try
                            {
                                stack.Pop();
                            }
                            catch (StackException e)
                            {
                                Console.WriteLine("StackExecption: {0}", e.Message);
                            }

                        }
                        break;
                    case 3:
                        try
                        {
                            stack.PrintStack();
                        }
                        catch (StackException e)
                        {
                            Console.WriteLine("StackExecption: {0}", e.Message);
                        }
                        break;
                    case 4:
                        loop = false;
                        Console.WriteLine("Press any Key to Exit!");
                        break;
                    default:
                        Console.WriteLine("Enter valid choice!");
                        break;

                }
            }
        }
    }
}

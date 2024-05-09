using System;
using System.Collections.Generic;

namespace IntCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //List
            List<int> list = new List<int>(){1, 10, -30, 10, -5};
            //Stack
            Stack<int> stack = new Stack<int>();
            //Queue
            Queue<int> queue = new  Queue<int>();
            //HashSet
            HashSet<int> hashSet = new  HashSet<int>(){1, 10, -30, 10, -5};

            int[] numbers = new int[]{1, 10, -30, 10, -5};

            foreach (int num in numbers)
            {
                stack.Push(num);
                queue.Enqueue(num);
            }

            //List
            string finalList = "List: ";
            foreach (int n in list)
            {
                finalList += n + ", ";
            }
            finalList = finalList.TrimEnd(',', ' ');
            Console.WriteLine(finalList);

            //Stack
            string finalStack = "Stack: ";
            foreach (int n in stack)
            {
                finalStack += n + ", ";
            }
            finalStack = finalStack.TrimEnd(',', ' ');
            Console.WriteLine(finalStack);

            //Queue
            string finalQueue = "Queue: ";
            foreach (int n in queue)
            {
                finalQueue += n + ", ";
            }
            finalQueue = finalQueue.TrimEnd(',', ' ');
            Console.WriteLine(finalQueue);

            //HashSet
            string finalHashSet = "HashSet: ";
            foreach (int n in hashSet)
            {
                finalHashSet += n + ", ";
            }
            finalHashSet = finalHashSet.TrimEnd(',', ' ');
            Console.WriteLine(finalHashSet);
        }
    }
}

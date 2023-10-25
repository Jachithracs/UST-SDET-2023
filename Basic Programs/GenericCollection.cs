using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class GenericCollection
    {
        public void ListHandling()
        {
            List<int> numbers = new List<int>();

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(66);
            numbers.Add(55);
            numbers.Add(1234);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            numbers.Reverse();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            numbers.RemoveAt(3);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine();
            numbers.Sort();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine();

            Console.WriteLine(numbers.Contains(1234));//returns boolean value
            Console.WriteLine(numbers.IndexOf(20));
            numbers.Clear();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }
        public void StackHandling()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            //stack.Push("AA");
            //stack.Push("false");
            //stack.Push("12.34");
            stack.Push(66);
            stack.Push(99);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Pop " + stack.Pop());//remove 


            Console.WriteLine();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Peek " + stack.Peek());
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Count " + stack.Count);
        }
        public void QueueHandling()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(10);//adding
            queue.Enqueue(20);
            queue.Enqueue(30);
           // queue.Enqueue(88.3467);


            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Dequeue " + queue.Dequeue());//remove 


            Console.WriteLine();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Peek " + queue.Peek());
            Console.WriteLine();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Count " + queue.Count);
        }

        public void DictionaryHandling()
        {
            Dictionary<string,int> dictionary = new Dictionary<string,int>();
            dictionary.Add("Jachithra", 90);
            dictionary.Add("Shirin", 99);
            dictionary.Add("Gokul", 95);
            dictionary.Add("Vishnu", 92);

            foreach (string item in dictionary.Keys)
            {
                Console.WriteLine(item);
                //Console.WriteLine(dictionary.ElementAt(item));
            }
            dictionary.Remove("Vishnu");//remove 


            Console.WriteLine();
            foreach (string item in dictionary.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine(dictionary.ContainsKey("Shirin"));


            Console.WriteLine();
            foreach (string item in dictionary.Keys)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();
            foreach (int item in dictionary.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count "+ dictionary.Count);
        }

        public void SortedListHandling()
        {
            //Sorted
        }

    }

}
    

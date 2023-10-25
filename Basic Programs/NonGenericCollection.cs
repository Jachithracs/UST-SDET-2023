using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class NonGenericCollection
    {
        public void ArrayListHandling()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add(30);

            /*
            for(int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            */

            /*
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            */

            arrayList.Add("AA");
            arrayList.Add("true");
            arrayList.Add("false");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            arrayList.Reverse();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            arrayList.RemoveAt(3);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();
            arrayList.Clear();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            
            Console.WriteLine(arrayList.Contains(10));//returns boolean value
            Console.WriteLine(arrayList.IndexOf(20));

        }

        public void StackHandling()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            stack.Push("AA");
            stack.Push("false");
            stack.Push("12.34");
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
            Console.WriteLine("Peek "+stack.Peek());
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Count "+stack.Count);
            //Console.WriteLine();
            
        }

        public void QueueHandling()
        {
            Queue queue = new Queue();
            
            queue.Enqueue(10);//adding
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(88.3467);


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
        public void HashHandling()
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Add(1, 10);
            hashtable.Add(2, 20);
            hashtable.Add(3, 30);
            hashtable.Add("3", "AA");
            hashtable.Add(4, "BB");


            foreach (var item in hashtable)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            hashtable.Remove(3);//remove 


            Console.WriteLine();
            foreach (var item in hashtable)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine(hashtable.ContainsKey("6"));
           
            
            Console.WriteLine();
            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();
            foreach (var item in hashtable.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count " + hashtable.Count);
        }


        public void SortedListHandling()
        {
            SortedList sortedList = new SortedList();

            sortedList.Add(4, "AA");
            sortedList.Add(2, 20);
            sortedList.Add(1, 10);
            sortedList.Add(3, "30"); ;
            
           
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }

            
        }

    }
}

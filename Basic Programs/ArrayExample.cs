using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class ArrayExample
    {
        // int[] numbers = {10,20,30};
        //readonly cannot be applied to local variable

        //readonly int[] numbers = new int[5];
       int[] numbers = new int[5];
       // int[,] nums = new int[2, 2];





        public void OneDimensional()
        {
            numbers[0] = 100;
            numbers[1] = 200;
            numbers[2] = 300;


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);

            }
            Console.WriteLine("2nd");
           // numbers = new int[8];
            numbers[1] = 123;


           // Array.Clear(numbers);//clear all values
           Array.Sort(numbers);

           // for (int i = 0; i < numbers.Length; i++)

            foreach(var num in numbers)

            {
                Console.WriteLine(num);

            }

            Array.Clear(numbers);

            foreach (var num in numbers)

            {
                Console.WriteLine(num);

            }

        }

        public void Twodimensional()
        {
             /*
            nums[0, 0] = 100;
            nums[0, 1] = 200;
            nums[1, 0] = 300;
            nums[1, 1] = 400;
            */
           int[,] nums ={ { 100, 200 }, {300, 400 } };

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }

        public void JaggedArray()
        {
            int[][,] array = new int[][,]
            {

              new int[,] {{1,2},{3,4}},
              new int[,] {{100,200},{ 300, 400 },{ 1000, 2000 } },
               new int[,] {{7,8,8},{ 3,1,7 },{ 0,6,8} },
               new int[,] {{11,22},{ 99,88 },{ 0,9} }

            };

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item[1,1]);
                
            //}

            for(int i=0;i<array.Length; i++)
            {
                int x = 0;
                for(int j = 0; j < array[i].GetLength(x);j++)
                {
                    for(int k = 0;k < array[j].Rank;k++)
                    {
                        Console.Write(array[i][j, k] + "");
                    }
                    Console.WriteLine();

                }
                x++;
                Console.WriteLine();
            }
        }
    }
}

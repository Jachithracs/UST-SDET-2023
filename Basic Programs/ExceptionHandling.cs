using Basic_Programs.ExceptionMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class ExceptionHandling
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public ExceptionHandling(int num1, int num2)
        {
           Num1 = num1;
           Num2 = num2;
        }
        //public int Num1 { get; set; }
        //public double Num2 { get; set; }
        //public ExceptionHandling(int num1, double num2)
        //{
        //    Num1 = num1;
        //    Num2 = num2;
        //}
        public void Divide()
        {
              int[] num = {10,20,30};
            int res = Num1 / Num2;
            Console.WriteLine(res);
            //double res = Num1 / Num2;

            //foreach(var item in num)
            //{
            //    res = item / Num2;
            //    Console.WriteLine(res);
            //}
            // for(int i =0;i<=3;i++)
            
             for (int i = 0; i <= 3; i++)
             {
                    res = num[i] / Num2;
                   Console.WriteLine(res);
             }
         
        }
        MyExceptions exceptions = new MyExceptions();
        public void NumCheck1()
        {
            
            if (Num1 >= 100)
            {
                Console.WriteLine("Congratz");
            }
            else
            {
                throw new Num1Exception(exceptions.exmesslist["Not 100"]);
            }
           
        }
        public void NumCheck2()
        {
           
           
            if (Num2 < 100)
            {
                Console.WriteLine("Congratz");
            }
            else
            {
                throw new Num2Exception(exceptions.exmesslist["Not1002"]);
            }
        }

    }
}

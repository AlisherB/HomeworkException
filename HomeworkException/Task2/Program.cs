using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task2
{
    class Program
    {
        /*
         2.	Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы. 
         После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.
        */
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 10, 25, 67, 74, 12 };
            foreach(var i in arr)
            {
                Write(i + "\t");
            }
            try
            {
                WriteLine("\nВведите индекс:");
                int index = Convert.ToInt32(ReadLine());
                if (index > arr.Length)
                {
                    throw new IndexOutOfRangeException($"Индекс находится за пределами массива!");
                }
                else
                {
                    WriteLine(arr[index]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                WriteLine(ex);
            }
            ReadLine();
        }
    }
}

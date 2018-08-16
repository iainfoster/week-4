using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*----------Task1----------*/
            Console.WriteLine("please enter a start number:");
            int Begin = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter a end number:");
            int End = int.Parse(Console.ReadLine());
            Console.WriteLine("For Loops");
            Console.WriteLine("N\t/10xN\t/100xN\t/1000xN");
            for (int i = Begin; i <= End; i++)
            {
                Console.WriteLine($"{i}\t {i * 10}\t {i * 100}\t {i * 1000}");
       
            }
            Console.ReadKey();


            /*-------Task1 end--------*/

            /*----------Task2---------*/



            /*-------Task2 end--------*/
        }

    }
}

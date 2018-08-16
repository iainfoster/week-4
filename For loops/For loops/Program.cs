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
            Console.WriteLine("While Loops");
            Console.WriteLine("N\t/10xN\t/100xN\t/1000xN");
            int  j = Begin;
            while (j <= End)
            {
                Console.WriteLine($"{j}\t {j * 10}\t {j * 100}\t {j * 1000}");
                j++;
            }
            Console.WriteLine("Do/While Loops");
            Console.WriteLine("N\t/10xN\t/100xN\t/1000xN");
            int f = Begin;
            do
            {
                Console.WriteLine($"{f}\t {f * 10}\t {f * 100}\t {f * 1000}");
                f++;
            } while (f <= End);
            Console.ReadKey();

            /*-------Task1 end--------*/

            /*----------Task2---------*/
            Console.WriteLine("Please enter a starting Point:");
            int Input = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a finish point:");
            int Endput = int.Parse(Console.ReadLine());
            Console.WriteLine("7 times table:");
            Console.WriteLine("--------------");
            Console.WriteLine(">>>For Loops<<<");
            for (int i = Input; i <= Endput; i++)
            {
                Console.WriteLine($"{i}x 7 = {i * 7}");
            }
            Console.WriteLine("7 times table:");
            Console.WriteLine("--------------");
            Console.WriteLine(">>>While Loops<<<");
            int q = Input;
            while (q <= Endput)
            {
                Console.WriteLine($"{q}x 7 = {q * 7}");
                q++;
            }
            Console.WriteLine("7 times table:");
            Console.WriteLine("--------------");
            Console.WriteLine(">>>Do/While Loops<<<");
            int a = Input;
            do
            {
                Console.WriteLine($"{a}x 7 = {a * 7}");
                a++;
            } while (a <= End);        
            Console.ReadKey();



            /*-------Task2 end--------*/

            /*-------Task3 start------*/

            int x;
            Console.WriteLine("Number\t Square\t Cube");
            Console.WriteLine("------\t ------\t ----");
            Console.WriteLine("for Loops");
            for ( x = 0; x <= 10; x++)
            {
                Console.WriteLine($"{x}\t {x * x}\t {x * x * x}");
            }
            Console.WriteLine("While Loops");
            x = 0;
            while ( x <= 10)
            {
                Console.WriteLine($"{x}\t {x * x}\t {x * x * x}");
                x++;
            }
                
            Console.ReadKey();

        }

    }
}

using System;

namespace SummingEachElementWithTheCorrespondingOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.Write("a[0] = ");
            a[0] = int.Parse(Console.ReadLine());
            Console.Write("a[1] = ");
            a[1] = int.Parse(Console.ReadLine());
            Console.Write("a[2] = ");
            a[2] = int.Parse(Console.ReadLine());
            Console.Write("a[3] = ");
            a[3] = int.Parse(Console.ReadLine());
            Console.Write("a[4] = ");
            a[4] = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            int[] b = new int[5];
            Console.Write("b[0] = ");
            b[0] = int.Parse(Console.ReadLine());
            Console.Write("b[1] = ");
            b[1] = int.Parse(Console.ReadLine());
            Console.Write("b[2] = ");
            b[2] = int.Parse(Console.ReadLine());
            Console.Write("b[3] = ");
            b[3] = int.Parse(Console.ReadLine());
            Console.Write("b[4] = ");
            b[4] = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            int[] c = new int[5];
            
            c[0] = a[0] + b[0];
            Console.WriteLine("c[0] = " + c[0]);
            
            c[1] = a[1] + b[1];
            Console.WriteLine("c[1] = " + c[1]);
            
            c[2] = a[2] + b[2];
            Console.WriteLine("c[2] = " + c[2]);
            
            c[3] = a[3] + b[3];
            Console.WriteLine("c[3] = " + c[3]);
            
            c[4] = a[4] + b[4];
            Console.WriteLine("c[4] = " + c[4]);
        }
    }
}

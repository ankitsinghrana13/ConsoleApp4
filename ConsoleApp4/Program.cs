using System;
namespace ConsoleApp4

{
    class program
    {
        static void Main(string[] arg)
        {
            int[] x = { 20, 10, 30, 50, 40 };
            Array.Sort(x);

            foreach(int i in x)
            {
                Console.Write(i);
            }
            Console.ReadLine();


            Console.WriteLine("after sort elenments in decending order");

        }

    }
}


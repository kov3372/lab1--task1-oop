using System;

namespace task1
{
    class Program
    {
        delegate void oprration(int x);
        static oprration[] arr = new oprration[3];
        static void Main(string[] args)
        {
            arr[0] = (x) => Console.WriteLine(Math.Sqrt(Math.Abs(x)));
            arr[1] = (x) => Console.WriteLine(Math.Pow(x, 3));
            arr[2] = (x) => Console.WriteLine(x + 3.5);


            /* 0 -- sqrt(abs(x))
               1 -- x^3
               2 -- x + 3,5 
           */


            while (true)
            {
                string[] str = Console.ReadLine().Split(' ');

                try
                {
                    int firstNum = int.Parse(str[0]);
                    int x = int.Parse(str[1]);

                    arr[firstNum](x);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("упс");
                    break;
                }
            }
        }
    }
}

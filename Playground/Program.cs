using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C# 8!");
            var p = new Point
            {
                X = 2,
                Y = 3
            };
            Console.WriteLine(p.ToString());
        }
    }
}

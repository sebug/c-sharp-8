﻿using System;

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
            int x = 5;
            int y = x switch
            {
                5 => 6,
                _ => 7
            };
            Console.WriteLine(y);

            var s = "catty";
            var t = s[..^2];
            Console.WriteLine(t);
        }
    }
}

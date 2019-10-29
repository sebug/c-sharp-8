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

            string? s2 = null;
            if (new Random().Next(2) > 0)
            {
                s2 = "first";
            }

            if (s2 != null)
            {
                var person = new Person(s2, "lastname");
            }

            var words = new string[]
            {
                "sphinx",
                "of",
                "black",
                "quartz",
                "judge",
                "my",
                "vow"
            };

            var s3 = words[1 .. ^1];

            Console.WriteLine(String.Join(" ", s3));
        }
    }
}

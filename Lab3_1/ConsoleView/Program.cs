using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleHistogram;

namespace ConsoleView
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = new Dictionary<string, int>()
            {
                {"газманов1", 10},
                {"газманов2", 5 },
                {"газманов3", 12 },
                {"газманов4", 7 },
                {"ааааaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", 19 }
            };

            Histogram histogram = new Histogram();
            histogram.Height = 20;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine();
            Console.WriteLine(histogram.GetHistogram(d));

            Console.Read();

        }
    }
}

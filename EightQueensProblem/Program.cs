using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EightQueensProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<Point>> solutions;
            EightQueens eightQueens = new EightQueens();

            solutions = eightQueens.Solutions();
            foreach (var list in solutions)
                Print(list);

            Console.ReadKey();
        }
        static void Print(List<Point> list)
        {
            foreach (var point in list)
                Console.Write($"({point.X}, {point.Y}) ");
            Console.WriteLine();
        }
    }
}

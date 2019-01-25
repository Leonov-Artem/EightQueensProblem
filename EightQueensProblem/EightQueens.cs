using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EightQueensProblem
{
    partial class EightQueens : IEightQueens
    {
        private List<List<Point>> solutions;

        public EightQueens() => solutions = new List<List<Point>>();
    }
}

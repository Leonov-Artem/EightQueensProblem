using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EightQueensProblem
{
    interface IEightQueens
    {
        int AmountSolutions();
        List<List<Point>> Solutions();
    }
}

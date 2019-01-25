using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EightQueensProblem
{
    partial class EightQueens
    {
        /// <summary>
        /// Метод проверяет, можно ли добавить ферзя в нововую позицию
        /// </summary>
        /// <param name="new_point"></param>
        /// <param name="points"></param>
        /// <returns></returns>
        private bool CanAdd(Point new_point, List<Point> points)
        {
            foreach (var point in points)
            {
                if (point.X == new_point.X || point.Y == new_point.Y 
                                           || new_point.X + new_point.Y == point.X + point.Y
                                           || new_point.X - new_point.Y == point.X - point.Y)
                    return false;
            }
            return true;
        }

    }
}

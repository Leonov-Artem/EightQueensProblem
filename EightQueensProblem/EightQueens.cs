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
        private List<Point> qeens_positioned;

        public EightQueens() => solutions = new List<List<Point>>();

        public List<List<Point>> Solutions() { return new List<List<Point>>(); }

        private List<Point> GetSolutionForPoint(Point new_point)
        {
            qeens_positioned = new List<Point>();
            qeens_positioned.Add(new_point);
            if (SolutionProblem(new_point, 1))
                return qeens_positioned;
            else return new List<Point>();
        }
        // Поиск решения алгоритмом с возвратом
        private bool SolutionProblem(Point new_qeen, int num_qeens_positioned)
        {
            if (!CanAdd(new_qeen, qeens_positioned)) return false;  // проверяем частичное решение на допустимость
            if (num_qeens_positioned == 8) return true;             // проверяе решение на полноту

            // расширяем частичное решение 
            for (int row = 1; row <= 8; row++)
            {
                for (int col = 1; col <= 8; col++)
                {
                    Point qeen = new Point(row, col);
                    if (!qeens_positioned.Contains(qeen))
                    {
                        qeens_positioned.Add(qeen);
                        if (SolutionProblem(qeen, num_qeens_positioned + 1)) return true;               // проверяем частичное решение                       
                        qeens_positioned.Remove(qeen);
                    }
                }
            }

            // если дошли до этой строчки, то решения нет
            return false;
        }
    }
}

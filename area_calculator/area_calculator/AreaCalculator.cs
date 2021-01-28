using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_calculator
{
    public class AreaCalculator
    {
        /// <summary>
        /// Площадь круга
        /// </summary>
        /// <param name="rad"></param>
        /// <returns></returns>
        public double GetArea(double rad)
        {
            return 3.14 * rad * rad;
        }

        /// <summary>
        /// Площадь прямоугольника
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double GetArea(double a, double b)
        {
            return a * b;
        }
        /// <summary>
        /// Площадь треугольника
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public double GetArea(double a, double b,double c)
        {
            double p = (a + b + c) / 2; //по герону
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        /// <summary>
        /// Проверка на прямоугольность
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool CheckTriangle(double a, double b, double c)
        {
            if ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b))
                return true;
            return false;

        }

    }
}

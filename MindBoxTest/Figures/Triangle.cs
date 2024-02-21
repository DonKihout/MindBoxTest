using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest.Figures
{
    public  class Triangle : Figure
    {
        public List<double> SidesLengthList { get; set; }

        public Triangle(List<double> SidesLengthList)
        {
            this.SidesLengthList = SidesLengthList;
        }
        public override double GetArea()
        {
            if (SidesLengthList.Count == 3)
            {
                var semiperimeter = SidesLengthList.Sum() / 2;
                var area =  Math.Sqrt(semiperimeter * (semiperimeter - SidesLengthList[0]) *
                                                (semiperimeter - SidesLengthList[1]) *
                                                (semiperimeter - SidesLengthList[2]));
                return area == 0 ? throw new Exception("Such Triangle Not Exist") : area;
            }
            else throw new Exception("Incorrect Number Of Sides");
        }

        /*Проверка на то, является ли треугольник прямоугольным*/
        public bool IsRightTriangle() {
            if (SidesLengthList.Count == 3)
            {
                var SidesLengthListBySqr = SidesLengthList.Select(s => s*s).ToList();
                var maxSideSqr = SidesLengthListBySqr.Max();

                if (SidesLengthListBySqr.Any(s => s < maxSideSqr))
                {
                    var cathetersSqrSum = SidesLengthListBySqr.Where(s => s != maxSideSqr).ToList().Sum();
                    if (cathetersSqrSum == maxSideSqr) return true;
                    else return false;
                }
                else return false;
            }
            else throw new Exception("Incorrect Number Of Sides");
        }
    }
}

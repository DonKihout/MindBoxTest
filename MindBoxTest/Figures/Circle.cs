using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest.Figures
{
    public class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public override double GetArea()
        {
            if (Radius > 0)
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
            else throw new Exception("Incorrect Radius Value");
        }

    }
}

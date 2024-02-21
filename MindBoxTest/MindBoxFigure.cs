using MindBoxTest.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    public class MindBoxFigure
    {
        public double GetFigureArea(Figure figure) {
            try {
                switch (figure)
                {
                    case Circle circle:
                        return circle.GetArea();
                    case Triangle triangle:
                        return triangle.GetArea();
                    default: throw new Exception("Incorrect Figure Type");

                        /* Не совсем понятен пункт "Легкость добавления других фигур".
                         Если имеется ввиду в коде, то создать нужный класс, реализовать "Figure", прописать в конструкции switch-case */
                }
            }
            catch(Exception ex) {
                throw ex;
            }
          
        }
    }
}

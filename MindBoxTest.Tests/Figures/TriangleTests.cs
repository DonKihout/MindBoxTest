using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxTest.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest.Figures.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void Area_1and1and2_exceptionReturned()
        {
            Triangle triangle = new Triangle(new List<double> {1,1,2});
            try{
                var area = triangle.GetArea();
            }
            catch (Exception ex) {
                Assert.AreEqual("Such Triangle Not Exist", ex.Message);
            }         
        }

        [TestMethod()]
        public void Area_3and4and5_6Returned()
        {
            Triangle triangle = new Triangle(new List<double> { 3, 4, 5 });
            var area = triangle.GetArea();
            Assert.AreEqual(6, area);
        }

        [TestMethod()]
        public void Sides_3and4and5_RightTriangleTrueReturned()
        {
            Triangle triangle = new Triangle(new List<double> { 3, 4, 5 });
            var IsRightTriangle = triangle.IsRightTriangle();
            Assert.AreEqual(true, IsRightTriangle);
        }

        [TestMethod()]
        public void Sides_3and4and5_RightTriangleFalseReturned()
        {
            Triangle triangle = new Triangle(new List<double> { 2, 4, 5 });
            var IsRightTriangle = triangle.IsRightTriangle();
            Assert.AreEqual(false, IsRightTriangle);
        }
    }
}
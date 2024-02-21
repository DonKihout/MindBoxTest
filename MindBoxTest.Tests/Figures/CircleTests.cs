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
    public class CircleTests
    {
        [TestMethod()]
        public void Area_radius0_exceptionReturned()
        {
            Circle circle = new Circle(0);
            try{
                var area = circle.GetArea();
            }
            catch (Exception ex) {
                Assert.AreEqual("Incorrect Radius Value", ex.Message);
            }         
        }

        [TestMethod()]
        public void Area_radius1_PIReturned()
        {
            Circle circle = new Circle(1);
            var area = circle.GetArea();
            Assert.AreEqual(area, Math.PI);
        }
    }
}
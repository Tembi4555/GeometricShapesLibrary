using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesLibrary.Tests
{
    public class CheckingTest
    {
        [Fact]
        public void TestCheckCreateTreangle()
        {
            Assert.Throws<ArgumentException>(() => { Triangle t = new Triangle(0, 1, 1); });
        }

        [Fact]
        public void TestCheckCreateCircle()
        {
            Assert.Throws<ArgumentException>(() => { Circle c = new Circle(0); });

        }
    }
}

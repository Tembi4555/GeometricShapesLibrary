using System.Net.Http.Headers;
using System.Runtime.Intrinsics.Arm;

namespace GeometricShapesLibrary
{
    public class Triangle : ACheckZeroOrNegatives, IShape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;
        public Triangle(double sideA, double sideB, double sideC)
        {
            if(!CheckZeroOrNegativesParameterValues(new double[] { sideA, sideA, sideC }))
            {
                throw new ArgumentException("Стороны треугольника не могут" +
                    " быть отрицательными или равными 0.");
            }

            if(!CheckItTreangle(sideA, sideB, sideC))
            {
                throw new ArgumentException("Данная фигура не является треугольником." +
                    "Так как сумма 2-х сторном меньше или равна третей");
            }
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double AreaShape()
        {
            double semiPerimeter = (_sideA + _sideB + _sideC) /2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) 
                * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));
            return Math.Round(area, 3);
        }

        public bool CheckItTreangle(double sideA, double sideB, double sideC)
        {
            if((sideA + sideB) <= sideC)
                return false;

            if((sideA + sideC) <= sideB)
                return false;

            if((sideB + sideC) <= sideA)
                return false;

            return true;
        }

        public bool IsRightAngledTriangle()
        {
            if ((Math.Pow(_sideA, 2.0) + Math.Pow(_sideB, 2.0) == Math.Pow(_sideC, 2)) 
                || (Math.Pow(_sideB, 2.0) + Math.Pow(_sideC, 2.0) == Math.Pow(_sideA, 2))
                || (Math.Pow(_sideA, 2.0) + Math.Pow(_sideC, 2.0) == Math.Pow(_sideB, 2)))
                return true;

            return false;

        }
    }
}


namespace GeometricShapesLibrary
{
    public class Circle : ACheckZeroOrNegatives, IShape
    {
        private readonly double _radius;
        public Circle(double radius)
        {
            if (!CheckZeroOrNegativesParameterValues(new double[] { radius }))
            {
                throw new ArgumentException("Радиус не может" +
                    " быть отрицательными или равными 0.");
            }

            _radius = radius;
        }
        public double AreaShape()
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2), 3);
        }

    }
}

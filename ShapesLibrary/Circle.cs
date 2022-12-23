namespace Shapes
{
    public class Circle: IShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (doubleLess(radius, 0, true))
            {
                throw new ArgumentException("The parameter must be positive");
            }
            _radius = radius;
        }

        public double GetArea()
        {
            return PI * Pow(_radius, 2);
        }
    }
}

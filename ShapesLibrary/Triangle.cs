namespace Shapes
{
    public class Triangle: IShape
    {
        private double[] _sides;
        private bool _isRightCalculated=false;
        private bool _isRight;

        public Triangle(double a, double b, double c)
        {
            if (doubleLess(a, 0, true) 
                || doubleLess(b, 0, true) || doubleLess(c, 0, true))
            {
                throw new ArgumentException("The parameters must be positive");
            }
            if (doubleLess(a + b, c, true)
                || doubleLess(b + c, a, true) || doubleLess(a + c, b, true))
            {
                throw new ArgumentException("The sides do not form a triangle");
            }
            _sides = new double[3] { a, b, c };
        }

        public double GetArea()
        {
            double hp = _sides.Sum() / 2; // half perimeter
            return Sqrt(hp * (hp - _sides[0]) * (hp - _sides[1]) * (hp - _sides[2]));
        }

        public bool IsRight 
        {
            get
            {
                if (! _isRightCalculated)
                {
                    Array.Sort(_sides);
                    _isRight = doubleEquals(Pow(_sides[0], 2) + Pow(_sides[1], 2), Pow(_sides[2], 2));
                    _isRightCalculated = true;
                }
                return _isRight;
            }
        }
    }
}

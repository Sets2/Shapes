namespace MathUtils
{
    public static class MathUtil
    {
        private const double epsilon = 1E-12;
        public static bool doubleEquals(double x, double y)
        {
            return Abs(x - y) <= epsilon;
        }
        public static bool doubleLess(double x, double y, bool orequal = false)
        {
            if (Abs(x - y) < epsilon) return (orequal);
            return (x < y);
        }
        public static bool doubleGreater(double x, double y, bool orequal = false)
        {
            if (Abs(x - y) < epsilon) return (orequal);
            return (x > y);
        }
    }
}

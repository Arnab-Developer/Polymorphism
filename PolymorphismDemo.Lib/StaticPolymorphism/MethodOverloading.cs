namespace PolymorphismDemo.Lib.StaticPolymorphism
{
    public class MethodOverloading
    {
        public int Addition(int x, int y)
        {
            return (x + y);
        }

        public int Addition(int x, int y, int z)
        {
            return (x + y + z);
        }

        public int Addition(params int[] values)
        {
            int sum = 0;
            foreach (int v in values)
            {
                sum += v;
            }

            return sum;
        }

        public double Addition(double x, double y)
        {
            return (x + y);
        }

        public double Addition(double x, double y, double z)
        {
            return (x + y + z);
        }

        public double Addition(params double[] values)
        {
            double sum = 0;
            foreach (double v in values)
            {
                sum += v;
            }

            return sum;
        }
    }
}

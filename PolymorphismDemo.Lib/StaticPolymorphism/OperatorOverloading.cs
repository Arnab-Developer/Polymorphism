namespace PolymorphismDemo.Lib.StaticPolymorphism
{
    public class OperatorOverloading
    {
        public double X { get; set; }

        public double Y { get; set; }

        public OperatorOverloading()
        {
        }

        public OperatorOverloading(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static OperatorOverloading operator +(OperatorOverloading obj1, OperatorOverloading obj2)
        {
            OperatorOverloading theOperatorOverloading = new()
            {
                X = obj1.X + obj2.X,
                Y = obj1.Y + obj2.Y
            };
            return theOperatorOverloading;
        }

        public static OperatorOverloading operator -(OperatorOverloading obj1, OperatorOverloading obj2)
        {
            OperatorOverloading theOperatorOverloading = new()
            {
                X = obj1.X - obj2.X,
                Y = obj1.Y - obj2.Y
            };
            return theOperatorOverloading;
        }

        public static OperatorOverloading operator *(OperatorOverloading obj1, OperatorOverloading obj2)
        {
            OperatorOverloading theOperatorOverloading = new()
            {
                X = obj1.X * obj2.X,
                Y = obj1.Y * obj2.Y
            };
            return theOperatorOverloading;
        }

        public static OperatorOverloading operator /(OperatorOverloading obj1, OperatorOverloading obj2)
        {
            OperatorOverloading theOperatorOverloading = new()
            {
                X = obj1.X / obj2.X,
                Y = obj1.Y / obj2.Y
            };
            return theOperatorOverloading;
        }
    }
}

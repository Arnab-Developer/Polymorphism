namespace PolymorphismDemo.Lib.DynamicPolymorphism.PropertyOverriding
{
    public class CollegeStudent : Student
    {
        private int _age;
        public override int Age
        {
            get { return _age; }
            set
            {
                if (IsAgeValid(value))
                {
                    _age = value;
                }
                else
                {
                    throw new BelowAgeLimitException();
                }
            }
        }

        private bool IsAgeValid(int age)
        {
            if (age >= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

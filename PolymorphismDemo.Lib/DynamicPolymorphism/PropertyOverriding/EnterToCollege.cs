namespace PolymorphismDemo.Lib.DynamicPolymorphism.PropertyOverriding
{
    public class EnterToCollege
    {
        public string EnterBelowAgeStudent(IStudent student)
        {
            student.Name = "Rahul";
            student.Age = 16;
            return student.ToString();
        }

        public string EnterValidAgeStudent(IStudent student)
        {
            student.Name = "Rahul";
            student.Age = 25;
            return student.ToString();
        }
    }
}

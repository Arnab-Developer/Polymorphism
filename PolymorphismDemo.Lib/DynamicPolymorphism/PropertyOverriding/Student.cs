namespace PolymorphismDemo.Lib.DynamicPolymorphism.PropertyOverriding
{
    public class Student : IStudent
    {
        public string Name { get; set; }

        public virtual int Age { get; set; }

        public Student()
        {
            Name = string.Empty;
        }

        public override string ToString()
        {
            return string.Format("Student name: {0}\nStudent age: {1}", Name, Age);
        }
    }
}

// ----------------------------------------------+
// This file containing a specific type of student 
// 'CollegeStudent' class which is for a demo of 
// DynamicPolymorphism by property overriding.
// ----------------------------------------------+

namespace PolymorphismClassLibrary.DynamicPolymorphism.PropertyOverriding
{
    /// <summary>
    /// CollegeStudent class.
    /// </summary>
    public class CollegeStudent : Student
    {
        private int _age;
        /// <summary>
        /// Age of the college student.
        /// </summary>
        public override int Age
        {
            get { return this._age; }
            set
            {
                if (this.IsAgeValid(value))
                {
                    this._age = value;
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

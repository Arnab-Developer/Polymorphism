using PolymorphismDemo.Lib.DynamicPolymorphism.PropertyOverriding;
using Xunit;

namespace PolymorphismDemo.Test.DynamicPolymorphismTests
{
    public class PropertyOverridingTest
    {
        [Fact]
        public void Can_EnterToCollege_ReturnProperMessage_ForValidAgeCollegeStudent()
        {
            IStudent student = new CollegeStudent();
            EnterToCollege enterToCollege = new();
            string message = enterToCollege.EnterValidAgeStudent(student);
            Assert.Equal("Student name: Rahul\nStudent age: 25", message);
        }

        [Fact]
        public void Can_EnterToCollege_ThrowsException_ForBelowAgeCollegeStudent()
        {
            IStudent student = new CollegeStudent();
            EnterToCollege enterToCollege = new();

            Assert.Throws<BelowAgeLimitException>(() =>
            {
                enterToCollege.EnterBelowAgeStudent(student);
            });
        }

        [Fact]
        public void Can_EnterToCollege_ReturnProperMessage_ForValidAgeStudent()
        {
            IStudent student = new Student();
            EnterToCollege enterToCollege = new();
            string message = enterToCollege.EnterValidAgeStudent(student);
            Assert.Equal("Student name: Rahul\nStudent age: 25", message);
        }

        [Fact]
        public void Can_EnterToCollege_ReturnProperMessage_ForBelowAgeStudent()
        {
            IStudent student = new Student();
            EnterToCollege enterToCollege = new();
            string message = enterToCollege.EnterBelowAgeStudent(student);
            Assert.Equal("Student name: Rahul\nStudent age: 16", message);
        }
    }
}

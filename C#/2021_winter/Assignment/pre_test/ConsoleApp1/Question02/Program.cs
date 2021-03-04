using System;

namespace Question02
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.FullName = "John Smith";
            person.DateOfBirth = new DateTime(1986, 06, 28);
            person.IsStudent = false;
            person.Sex = Sex.Male;

            Console.WriteLine(person);
        }
    }
    public class Person { 
        public string PersonID { get; set; }
        public string FullName { get; set; }
        public int Age { 
            get {
                var now = DateTime.Now;
                return now.Year - this.DateOfBirth.Year;
            } 
        }
        public DateTime DateOfBirth { get; set; }
        public Boolean IsStudent { get; set; }
        public Sex Sex { get; set; }

        public Person() {
            this.PersonID = Guid.NewGuid().ToString();
        } // 고유 ID 생성

        public override string ToString()
        {
            return $"Student ID: {this.PersonID} \n" +
                $"Full Name: {this.FullName} \n" +
                $"Age: {this.Age} \n" +
                $"Date of birth: {this.DateOfBirth:yyyy-MM-dd} \n" +
                $"Is student: {this.IsStudent} \n" +
                $"Sex: {this.Sex}";
        }
    }
    public enum Sex
    {
        Male,
        Female
    }
}

/*
In your Program.cs file, inside your Question02 namespace and outside the Program class, create a new class called Person. 
In this class, you must define at least 5 properties that describe attributes that a person has. You are free to come up with your own properties, but you must use at least one instance of each of the following data types: 
string, int, DateTime, boolean, and an enumerator of your making.
In your Person class, override the ToString method, so that it returns a string that contains meaningful information on the object.

Once you are done, write the test harness in the Main method of your Program class, ensuring your code is fully functional as per requirements. 
In other words, define two or three random Person objects in your Main method, and display their information in the Console. 
You can create your people freely.

For full marks, ensure at least one of your properties are automatically calculated.
 */
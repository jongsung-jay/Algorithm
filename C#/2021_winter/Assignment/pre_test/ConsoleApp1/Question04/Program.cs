using System;
using System.IO;
using System.Xml.Serialization;

namespace Question04
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

            // Writing XML
            Person.SaveData(person, @"C:\Users\JONGSUNG\OneDrive\Desktop\C#\test");
            try
            {
                //Reading XML
                Person personFromFile = Person.LoadData(@"C:\Users\JONGSUNG\OneDrive\Desktop\C#\test\Person.xml");
                Console.WriteLine(personFromFile);
            }
            catch(Exception e) {
                Console.Write(e.Message);
                
            }
        }
    }
    public class Person
    {
        public string PersonID { get; set; }
        public string FullName { get; set; }
        public int Age
        {
            get
            {
                var now = DateTime.Now;
                return now.Year - this.DateOfBirth.Year;
            }
        }
        public DateTime DateOfBirth { get; set; }
        public Boolean IsStudent { get; set; }
        public Sex Sex { get; set; }

        public Person()
        {
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

        public static void SaveData(Person person, string path) {
            path = path.Replace('/', '\\');
            if(!path.EndsWith('\\')){
                path += "\\";        
            }
            // create serializer
            var serializer = new XmlSerializer(typeof(Person));
            using (var stream = new FileStream(path + $"Person.xml", FileMode.Create))
            {
                // Serialize the object
                serializer.Serialize(stream, person);
            }
        }
        public static Person LoadData(string filename)
        {
            Person person = null;

            filename = filename.Replace('/', '\\');

            if (!filename.EndsWith(".xml"))
                throw new Exception("Method LoadData expects a XML file, but did not get one.");

            var serializer = new XmlSerializer(typeof(Person));
            using (var stream = new FileStream(filename, FileMode.Open))
            {
                person = (Person)serializer.Deserialize(stream);
            }
            return person;
        }
    }
    public enum Sex
    {
        Male,
        Female
    }
}

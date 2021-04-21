using System;
using System.Collections.Generic;

namespace Class_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> school = new List<Person>
            {
                new Student("Jason" , "1590 E. First St." , "C# Daytime" , 1 , 9749.99 ),
                new Student("Megan" , "2795 Rollingwood" , "C# AfterHours" , 1 , 8749.99),
                new Student("Sean" , "925 Cherry St. SE" , "C# Daytime", 1 , 11750.00),
                new Staff("Billy" , "1570 Woodward Ave", "Grand Circus Detroit", 75900.42),
                new Staff("Justin", "38 Fulton St. W" , "Grand Circus Grand Rapids" , 49959.53)
            };

            foreach (Person person in school)
            {
                Console.WriteLine(person);
            }
        
        }

        static void TestProgram()
        {
            Person person = new Person("Justin", "38 Fulton St. W");//Parent
            string result = person.ToString();
            Console.WriteLine(result);

            Student student = new Student("Sean", "162 Houseman NE", "C#", 1, 9649.99);
            string studentResult = student.ToString();
            Console.WriteLine(studentResult);

            Staff staff = new Staff("Billy", "1570 Woodward Ave", "Grand Circus Detroit", 75900.42);
            string staffResult = staff.ToString();
            Console.WriteLine(staffResult);
        }
    } 
}

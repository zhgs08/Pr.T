using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Students
{
        class Student
        {
            public string firstName;
            public string lastName;
            public int age;
            public string id;
            public Student(string _firstName, string _lastName, int _age, string _id)
            {
                firstName = _firstName;
                lastName = _lastName;
                age = _age;
                id = _id;
            }
            public override string ToString()
            {
                return firstName + " " + lastName + " " + "age - " + age + " ," + "id -" + id;
            }
            static void Main(string[] args)
            {
                Student s = new Student("Gaukhar", "Zharkeyeva", 18, "15BD02034");
                Console.WriteLine(s);
                Console.ReadKey();
            }
        }
    
}
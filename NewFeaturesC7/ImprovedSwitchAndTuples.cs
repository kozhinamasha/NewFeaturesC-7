using System;
using System.CodeDom;
using System.Collections.Generic;

namespace NewFeaturesC7
{
    public class ImprovedSwitchAndTuples
    {
        public List<Students> student = null;

        public ImprovedSwitchAndTuples()
        {
            var s = new List<Students>()
                {
                    new Students()
                    {
                        Name = "Tom",
                        Age = 12,
                        Grade = "First",
                        Gender = "M"

                    },
                    new Students()
                    {
                        Name = "Ben",
                        Age = 15,
                        Grade = "First",
                        Gender = "M"

                    },
                    new Students()
                    {
                        Name = "Ann",
                        Age = 16,
                        Grade = "Second",
                        Gender = "F"

                    }
                };
            student = s;
        }

        public void GetStudentsInfoWithGrade(Students student)      //improved switch
        {
            switch (student)
            {
                case Students s when (s.Grade == "First" && s.Name.Contains("Tom")):
                    Console.WriteLine($"The student name is {s.Name} and his age is {s.Age}");
                    break;
                case Students s when (s.Grade == "Second"):
                    Console.WriteLine($"The student name is {s.Name} and the student age is {s.Age}");
                    break;
            }
        }

        public (string name, int age, string grade) ReturnStudentInfo()   //tuples
        {
            return ("Tom", 30, "w");
        }

        public void GetStudentsDetails(out string name, out int age)   //work with out
        {
            name = "Tom";
            age = 22;
        }
    }

    public class Students
    {
        public Students(string name) => Name = name;  //constructor

        public Students()
        {

        }

        private int _salary;
        public int Salary
        {
            get => _salary;
            set => _salary = value;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
        public string Gender { get; set; }

        public string GetStudentName()
        {
            return Name ?? throw new TypeInitializationException("Student.Name",
                       new Exception("Name has to be initialized"));
        }

        public void PrintName() => Console.WriteLine($"The name of student is {Name}");       //method with lambda expression
        public string Address => "London";   //set property
    }
}


using System;
using System.Linq;

namespace NewFeaturesC7
{
    class Program
    {
        static void Main(string[] args)
        {
            ImprovedSwitchAndTuples feature = new ImprovedSwitchAndTuples();
            feature.GetStudentsInfoWithGrade(feature.student.First());
            feature.GetStudentsInfoWithGrade(feature.student.Where(x => x.Grade == "Second").First());

            var studentInfo = feature.ReturnStudentInfo();
            Console.WriteLine($"The student with name {studentInfo.name} and age {studentInfo.age} and grade is {studentInfo.grade}");

            (string StudentName, int StudentAge, string StudentGrade) = feature.ReturnStudentInfo();
            if (StudentAge == 30)
                Console.WriteLine($"The name is {StudentName} and age {StudentAge} and grade {StudentGrade}");


            feature.GetStudentsDetails(out string name, out int age);
            Console.WriteLine($"The student with name {name} have age {age}");

            Students s = new Students() { Name = "Masha" };
            s.GetStudentName();
            Console.WriteLine($"The name of student is { s.GetStudentName()}");

            Students t = new Students("Ben");
            t.PrintName();



            Console.ReadKey();
        }
    }
}

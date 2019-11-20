using System;
using System.Collections.Generic;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class Student
        {
            private static int nextStudentId = 1;
  
            public string Name { get; set; }
            public int StudentId { get; set; }
            public int NumberOfCredits { get; set; }
            public double Gpa { get; set; }
            
            
            public Student(string name, int studentId,
                int numberOfCredits, double gpa)
            {
                Name = name;
                StudentId = studentId;
                NumberOfCredits = numberOfCredits;
                Gpa = gpa;
            }

            public Student(string name, int studentId)
                : this(name, studentId, 0, 0) { }

            public Student(string name)
                : this(name, nextStudentId)
            {
                nextStudentId++;
            }

            public void AddGrade(int courseCredits, double grade)
            {
                //Update the appropriate properties: NumberOfCredits, Gpa
                double totalQualityScore = Gpa * NumberOfCredits;
                totalQualityScore += courseCredits * grade;
                NumberOfCredits += courseCredits;
                Gpa = totalQualityScore / NumberOfCredits;
            }

            public string GetGradeLevel()
            {
                if (NumberOfCredits >0 && NumberOfCredits < 30)
                { return "Freshman"; }
                else if (NumberOfCredits >= 30 && NumberOfCredits < 60)
                { return "Sophomre"; }
                else if (NumberOfCredits >= 60 && NumberOfCredits < 90)
                { return "Junior"; }
                else
                { return "Senior"; }
            }

            public override bool Equals(Object o)
            {
                Student studentObj = o as Student;
                return StudentId == studentObj.StudentId;
            }

            public override String ToString()
            {
                return Name + " (Student ID: "+StudentId +", Grade Level: " + GetGradeLevel() + ", Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
            }
        }

        public class Course
        {
            public string courseName { get; set; }
            public int courseId { get; set; }
            public int courseCredits { get; set; }
            public List<Student> Students { get; set; }

            public override bool Equals(Object o)
            {
                Course courseObj = o as Course;
                return courseId == courseObj.courseId;
            }

            public override String ToString()
            {
                return courseName + " (Credits: " + courseCredits + ", Course Number: " + courseId + ")";
            }
        }
    }
}

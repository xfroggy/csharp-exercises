using System;

namespace ClassImplementationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }
    public abstract class AbstractEntity
    {
        private int idNum;

        public int IdNum
        {
            get { return idNum; }
            set { idNum = value; }
        }

        abstract public int ID();
      
    }
       
    public abstract class Student: AbstractEntity
    {
        public override int ID()
        {
            return IdNum = IdNum + 1;
        }
        public int itemID { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public int StudentId { get; set; }
        public double Gpa { get; set; }
        public static int nextStudentId = 1;
        

        public Student(string name, int studentId, int credits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            Credits = credits;
            Gpa = gpa;
            itemID = ID();
        }
        
        public Student(string name, int studentId) 
            : this(name, studentId, 0, 0) { }

    }

    public class UnderGraduateStudent : Student
     {
        public bool BachelorsDegree = false;
        public string UndergradMajor { get; set; }

        public UnderGraduateStudent(bool bachelorsDegree, 
            string undergradMajor, string name, int studentId, int credits, 
            double gpa): base(name, studentId, credits, gpa)
        {
            BachelorsDegree = bachelorsDegree;
            UndergradMajor = undergradMajor;
            Name = name;
            Credits = credits;
            Gpa = gpa;
            StudentId = studentId;
            itemID = ID();

        }
        public UnderGraduateStudent(string name) 
            : base(name, nextStudentId) { }

    }

    public class GraduateStudent: UnderGraduateStudent
    {
        public bool MastersDegree = false;
        public bool PhdDegree = false;
        public string GraduateMajor { get; set; }

        public GraduateStudent(bool mastersDegree, bool phdDegree,
            string graduateMajor, bool bachelorsDegree, string undergradMajor, string name,
            int studentId, int credits, double gpa): base(bachelorsDegree, 
                undergradMajor, name, studentId, credits, gpa)
        {
            MastersDegree = mastersDegree;
            PhdDegree = phdDegree;
            GraduateMajor = graduateMajor;
            BachelorsDegree = bachelorsDegree;
            UndergradMajor = undergradMajor;
            Name = name;
            StudentId = studentId;
            Credits = credits;
            Gpa = gpa;
            itemID = ID();
        }

        public GraduateStudent(string name): base(name) { }


}
}

using DapperDemo.Models;

namespace DapperDemo.Repository
{
    public static class StudentList
    {
        static List<Student> students = null;

        static StudentList()
        {
            students = new List<Student>()
            {
                new Student(){ StudentId=1, Name = "Hina", Stream="Science"}
            };
        }

        public static List<Student> GetAll()
        {
            return students;
        }

        public static Student Get(int id)
        {
            return students.FirstOrDefault(x => x.StudentId == id);
        }
        public static void Add(Student student)
        {
            students.Add(student);
        }

        public  static void Update(Student student)
        {
            Student std = students.Find(x => x.StudentId == student.StudentId);
            std.Name = student.Name;
            std.Stream = student.Stream;   
        }

        public  static  void Delete(int id)
        {
            Student std = students.Find(x => x.StudentId == id);
            students.Remove(std);
        }

    }
}

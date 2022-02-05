using DapperDemo.Models;

namespace DapperDemo.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public async Task Add(Student student)
        {
            StudentList.Add(student);
        }

        public async Task Delete(int id)
        {
            StudentList.Delete(id);
        }

        public async Task<Student> Get(int id)
        {
           return StudentList.Get(id);
        }

        public async Task<List<Student>> GetAll()
        {
            return StudentList.GetAll();
        }

        public async Task Update(Student student)
        {
            StudentList.Update(student);
        }
    }
}

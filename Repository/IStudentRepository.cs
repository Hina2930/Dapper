using DapperDemo.Models;

namespace DapperDemo.Repository
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAll();
        Task<Student> Get(int id);
        Task Add(Student student);
        Task Update(Student student);
        Task Delete(int id);
    }
}

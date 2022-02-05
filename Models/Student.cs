using System.ComponentModel.DataAnnotations;

namespace DapperDemo.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Name is mandatory")]
        public string Name { get; set; }

        public string Stream { get; set; }

    }
}

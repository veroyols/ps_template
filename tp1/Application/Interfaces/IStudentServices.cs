using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IStudentServices
    {
        Task<Student> CreateStudent();
        Task<Student> DeleteStudent(int studentId);
        Task<List<Student>> GetAll();
        Task<Student> GetById(int studentId);
   
    }
}

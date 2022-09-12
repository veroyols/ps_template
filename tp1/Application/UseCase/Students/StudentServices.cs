using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Students
{
    public class StudentServices : IStudentServices
    {
        public Task<Student> CreateStudent()
        {
            throw new NotImplementedException();
        }

        public Task<Student> DeleteStudent(int studentId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Student>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetById(int studentId)
        {
            throw new NotImplementedException();
        }
    }
}

using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Querys
{
    public class StudentQuery : IStudentQuery
    {
        public List<Student> GetListStudent()
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int studentId)
        {
            throw new NotImplementedException();
        }
    }
}

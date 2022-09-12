using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Command
{
    public class StudentCommand : IStudentCommand
    {
        //Inyecte en el contexto
        private readonly AppDbContext _context;

        public StudentCommand(AppDbContext context)
        {
            _context = context;
        }
        public async Task InsertStudent(Student student)
        {
            _context.Add(student);
            await _context.SaveChangesAsync();
        }

        public Task RemoveStudent(int studentId)
        {
            throw new NotImplementedException();
        }
    }
}
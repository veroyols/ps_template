using Domain.Entities;
using Microsoft.EntityFrameworkCore; //
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class AppDbContext : DbContext //Clase Tutorial 
    {
        //configuracion de entidades en dbContext
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        //constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base() { }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {}
        //No sobreescribo el metodo porque lo INYECTO en Program

        //MODELADO DE ENTIDADES -> Cardinalidad
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student"); //nombre de la tabla
                entity.HasKey(e => e.StudentId); //key
                entity.Property(t => t.StudentId).ValueGeneratedOnAdd(); //autoincremental
                //relacion 1 a 1 (composicion)
                entity.HasOne<StudentAddress>(stu => stu.Address)
                .WithOne(ad => ad.Student)
                .HasForeignKey<StudentAddress>(ad => ad.AddressOfStudentId);//FK
            });
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.CourseId); //key
                entity.Property(t => t.CourseId).ValueGeneratedOnAdd(); //autoincremental
            });
            modelBuilder.Entity<StudentAddress>(entity =>
            {
                entity.HasKey(e => e.StudentAddressId); //key
                entity.Property(t => t.StudentAddressId).ValueGeneratedOnAdd(); //autoincremental
            });

            //PK clave compuesta
            modelBuilder.Entity<StudentCourse>(entity =>
            {
                entity.HasKey(sc => new { sc.StudentId, sc.CourseId }); //clave compuesta

                entity.HasOne<Student>(sc => sc.Student)
                    .WithMany(s => s.StudentCourses)//lista de cursos en stu
                    .HasForeignKey(s => s.StudentId);

                entity.HasOne<Course>(sc => sc.Course)
                    .WithMany(s => s.StudentCourses)//lista de cursos en stu
                    .HasForeignKey(s => s.CourseId);

            });
        }
    }
}

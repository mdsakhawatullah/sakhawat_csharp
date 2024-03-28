using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class TrainingDbContext: DbContext
    {
        private readonly string _connectionString;

        public TrainingDbContext()
        {
            _connectionString = "Server=.\\SQLEXPRESS;Database=CSharpB16;User Id=csharpb16;Password=123456;Trust Server Certificate=True";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(_connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, UserName = "admin", Password = "12345", Role = UserRole.Admin }
            );

            modelBuilder.Entity<UserTeacher>().HasData(
               new UserTeacher { Id = 1, TeacherName = "teacher", Password = "12345" }
           );
        }


        public DbSet<User> Users { get; set; }
        public DbSet<GradeClass> GradeClasses { get; set; }
        public DbSet<UserTeacher> Teachers { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }

        public DbSet<TeacherRoom> TeachersTeachers { get;set; }
    }
}

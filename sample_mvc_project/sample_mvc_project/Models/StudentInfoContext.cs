using System;
using Microsoft.EntityFrameworkCore;

namespace sample_mvc_project.Models
{
    public class StudentInfoContext : DbContext
    {
        public StudentInfoContext(DbContextOptions<StudentInfoContext> options)
             : base(options)
        {
        }

        public DbSet<StudentInfo> StudentInfos { get; set; } = null!;
    }
}


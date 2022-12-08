using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryCureDemo.Models
{
    public class StudentDbcontext :DbContext
    {
        
        public StudentDbcontext(DbContextOptions<StudentDbcontext> options) : base(options)
        { }
        public DbSet<Student> students { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sulekha.Models
{
    public class Context:DbContext
    {
       
            public Context(DbContextOptions<Context> options)
                : base(options)
            {
            }
            public DbSet<Business> Business { get; set; }
            public DbSet<Appointment> Appointment { get; set; }
            public DbSet<Signup> Signup { get; set; }
            public DbSet<Doctor> Doctor { get; set; }
        }
    
}

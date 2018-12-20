using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ComITProject.Models
{
    public class ComITProjectContext : DbContext
    {
        public ComITProjectContext (DbContextOptions<ComITProjectContext> options)
            : base(options)
        {
        }

        public DbSet<ComITProject.Models.Recipe> Recipe { get; set; }
    }
}

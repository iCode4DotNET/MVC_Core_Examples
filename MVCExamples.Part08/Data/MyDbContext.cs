using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCExamples.Part08.Models;

namespace MVCExamples.Part08.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext (DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<MVCExamples.Part08.Models.Person> Person { get; set; } = default!;
    }
}

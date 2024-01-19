using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCExamples.Part08.Models;

namespace MVCExamples.Part08.Data
{
    public class MVCExamplesPart08Context : DbContext
    {
        public MVCExamplesPart08Context (DbContextOptions<MVCExamplesPart08Context> options)
            : base(options)
        {
        }

        public DbSet<MVCExamples.Part08.Models.Person> Person { get; set; } = default!;
    }
}

using E_IhaleBE.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_IhaleBE
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Register> Register { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}

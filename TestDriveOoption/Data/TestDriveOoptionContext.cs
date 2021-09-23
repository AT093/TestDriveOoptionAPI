using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestDriveOoption.Model;

namespace TestDriveOoption.Data
{
    public class TestDriveOoptionContext : DbContext
    {
        public TestDriveOoptionContext (DbContextOptions<TestDriveOoptionContext> options)
            : base(options)
        {
        }

        public DbSet<TestDriveOoption.Model.Register> Register { get; set; }

        public DbSet<TestDriveOoption.Model.Message> Message { get; set; }
    }
}

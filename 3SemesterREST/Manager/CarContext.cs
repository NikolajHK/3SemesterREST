using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _3SemesterREST.Models;
using Microsoft.EntityFrameworkCore;

namespace _3SemesterREST.Manager
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
    }
}

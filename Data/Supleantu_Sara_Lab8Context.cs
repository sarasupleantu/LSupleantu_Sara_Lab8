using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Supleantu_Sara_Lab8.Models;

namespace Supleantu_Sara_Lab8.Data
{
    public class Supleantu_Sara_Lab8Context : DbContext
    {
        public Supleantu_Sara_Lab8Context (DbContextOptions<Supleantu_Sara_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Supleantu_Sara_Lab8.Models.Book> Book { get; set; }

        public DbSet<Supleantu_Sara_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Supleantu_Sara_Lab8.Models.Category> Category { get; set; }
    }
}

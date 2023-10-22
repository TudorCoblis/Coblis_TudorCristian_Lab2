using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Coblis_TudorCristian_Lab2.Models;

namespace Coblis_TudorCristian_Lab2.Data
{
    public class Coblis_TudorCristian_Lab2Context : DbContext
    {
        public Coblis_TudorCristian_Lab2Context (DbContextOptions<Coblis_TudorCristian_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Coblis_TudorCristian_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Coblis_TudorCristian_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Coblis_TudorCristian_Lab2.Models.Author>? Author { get; set; }
    }
}

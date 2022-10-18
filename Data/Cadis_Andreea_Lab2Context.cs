using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cadis_Andreea_Lab2.Models;

namespace Cadis_Andreea_Lab2.Data
{
    public class Cadis_Andreea_Lab2Context : DbContext
    {
        public Cadis_Andreea_Lab2Context (DbContextOptions<Cadis_Andreea_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Cadis_Andreea_Lab2.Models.Book> Book { get; set; } = default!;
    }
}

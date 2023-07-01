using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.Models;

namespace Prueba.Context
{
    public class UCaninoContext : DbContext
    {
        public UCaninoContext(DbContextOptions<UCaninoContext> options): base(options)
        {
        }

        public DbSet<Product> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}

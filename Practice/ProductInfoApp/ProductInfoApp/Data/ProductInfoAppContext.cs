using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductInfoApp.Models;

namespace ProductInfoApp.Data
{
    public class ProductInfoAppContext : DbContext
    {
        public ProductInfoAppContext (DbContextOptions<ProductInfoAppContext> options)
            : base(options)
        {
        }

        public DbSet<ProductInfoApp.Models.Product> Product { get; set; } = default!;
    }
}

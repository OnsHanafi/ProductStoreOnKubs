using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KubsMvcApp.Models;

namespace KubsMvcApp.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext (DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public DbSet<KubsMvcApp.Models.Product> Product { get; set; } = default!;
    }
}

using Microsoft.EntityFrameworkCore;
using ProductApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Daos
{
    public class SellerContext : DbContext
    {
        public SellerContext(DbContextOptions<SellerContext> options) : base(options)
        {
        }

        public DbSet<Sellers> Sellers { get; set; }
    }
}

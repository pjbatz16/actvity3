using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myfirstproject.Models
{
    public class ShippingDBContext : DbContext
    {
        public ShippingDBContext(DbContextOptions options) :base(options)
        {

        }
        public DbSet<Shipping> Shippings { get; set; }
    }
}

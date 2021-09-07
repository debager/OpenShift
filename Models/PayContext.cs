using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayHistory.Models
{
    public class PayContext : DbContext
    {
        public PayContext(DbContextOptions<PayContext> options)
            : base(options)
        {
        }

        public DbSet<PayRequest> TodoItems { get; set; }
    }
}

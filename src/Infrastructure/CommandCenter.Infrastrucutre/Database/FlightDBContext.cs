using CommandCenter.Application.Persistence.Data;
using CommandCenter.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenter.Infrastrucutre.Database
{
    public class FlightDBContext: DbContext, IFlightDBContext
    {
        public FlightDBContext(DbContextOptions<FlightDBContext> options) : base(options)
        {
           
        }
        public int SaveChanges(CancellationToken cancellationToken = default)
        {
            return base.SaveChanges();
        }
        public DbSet<Users> Users { get; set; }
    }
}

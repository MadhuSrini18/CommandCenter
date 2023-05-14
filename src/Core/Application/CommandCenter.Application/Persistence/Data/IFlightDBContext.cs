using CommandCenter.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenter.Application.Persistence.Data
{
    public interface IFlightDBContext
    {
        public DbSet<Users> Users { get; set; }
        public int SaveChanges(CancellationToken cancellationToken = default);
    }
}

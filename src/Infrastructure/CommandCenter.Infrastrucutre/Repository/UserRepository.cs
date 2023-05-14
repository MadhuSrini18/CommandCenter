using CommandCenter.Application.Persistence.Data;
using CommandCenter.Application.Persistence.IRespositories;
using CommandCenter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenter.Infrastrucutre.Repository
{
    public class UserRepository : IUserRepository
    {
        public readonly IFlightDBContext _flightDBContext;

        public UserRepository(IFlightDBContext flightDBContext)
        {
            _flightDBContext = flightDBContext;
        }

        public void AddUser(Users user)
        {
            _flightDBContext.Users.Add(user);
            _flightDBContext.SaveChanges();
        }
    }
}

using CommandCenter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenter.Application.Persistence.IRespositories
{
    public interface IUserRepository
    {
        public void AddUser(Users user);
    }
}

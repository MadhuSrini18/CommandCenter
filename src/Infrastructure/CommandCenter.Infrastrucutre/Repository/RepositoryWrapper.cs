using CommandCenter.Application.Persistence.Data;
using CommandCenter.Application.Persistence.IRespositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenter.Infrastrucutre.Repository
{
    public class RepositoryWrapper: IRepositoryWrapper
    {
        public readonly IFlightDBContext _flightDBContext;

        public IUserRepository UserRepository { get; private set; }

        public RepositoryWrapper(IFlightDBContext flightDBContext)
        {     _flightDBContext = flightDBContext;
            
            UserRepository = new UserRepository(_flightDBContext);
        }
    }
}

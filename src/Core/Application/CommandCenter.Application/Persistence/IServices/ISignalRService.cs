using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCenter.Application.Persistence.IServices
{
    public interface ISignalRService
    {
        public Task UpdatePrinterData();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandCenter.Application.Persistence.IServices;
using Microsoft.AspNetCore.SignalR;

namespace CommandCenter.Application.Services
{
    public class SignalRService : Hub<IPrinterHubClient>, ISignalRService
    {
        public Task UpdatePrinterData()
        {
            return Task.CompletedTask;
        }
    }
}

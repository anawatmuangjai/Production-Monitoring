using PDR.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PDR.Core.Interfaces
{
    public interface IMonitorRepository
    {
        Task<List<MonitorDetail>> GetAllAsync();
        Task<List<MonitorDetail>> GetByZoneAsync(string zone);
    }
}

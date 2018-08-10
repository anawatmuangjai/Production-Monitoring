using PDR.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PDR.Core.Interfaces
{
    public interface IMonitorService
    {
        Task<List<MonitorDetail>> GetMonitorDetails();
        Task<List<MonitorDetail>> GetMonitorDetailByZone(string zone);
    }
}

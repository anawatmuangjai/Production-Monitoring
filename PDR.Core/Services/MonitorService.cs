using PDR.Core.Interfaces;
using PDR.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PDR.Core.Services
{
    public class MonitorService : IMonitorService
    {
        private readonly IMonitorRepository _monitorRepository;

        public MonitorService(IMonitorRepository monitorRepository)
        {
            _monitorRepository = monitorRepository;
        }

        public async Task<List<MonitorDetail>> GetMonitorDetails()
        {
            return await _monitorRepository.GetAllAsync();
        }

        public async Task<List<MonitorDetail>> GetMonitorDetailByZone(string zone)
        {
            return await _monitorRepository.GetByZoneAsync(zone);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using PDR.Core.Interfaces;
using PDR.Core.Models;
using PDR.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace PDR.Infrastructure.Repsoitories
{
    public class MonitorRepository : IMonitorRepository
    {
        private readonly PDRContext _context;

        public MonitorRepository(PDRContext context)
        {
            _context = context;
        }

        public async Task<List<MonitorDetail>> GetAllAsync()
        {
            return await _context.ProdMonitor
                .Include(x => x.IdMstLossGroupNavigation)
                .Select(x => new MonitorDetail
                {
                    LineName = x.LineName,
                    StatusId = x.IdMstLossGroup,
                    PlanShot = x.PlanShot,
                    ActualShot = x.ActualShot,
                    DefectQty = x.NgQty,
                    LossTime = x.LossTime,
                    PlanDiff = x.PlanDiff,
                    PlanId = x.PlanId,
                    IsUrgent = x.UrgentFlag,
                    UpdateDate = x.UpdateDate,
                    Zone = x.DisplayGroup,
                    Status = new Status
                    {
                        StatusId = x.IdMstLossGroupNavigation.IdFactor,
                        StatusName = x.IdMstLossGroupNavigation.StatusName,
                        TroubleName = x.IdMstLossGroupNavigation.TroubleName,
                        AppName = x.IdMstLossGroupNavigation.AppName,
                        Owner = x.IdMstLossGroupNavigation.Owner,
                        Charge = x.IdMstLossGroupNavigation.Charge,
                        StatusColor = x.IdMstLossGroupNavigation.BColor,
                        StopFlag = x.IdMstLossGroupNavigation.FlagStop,
                        OrderNumber = x.IdMstLossGroupNavigation.OrderNo,
                        Note = x.IdMstLossGroupNavigation.Note
                    }
                }).ToListAsync();
        }

        public async Task<List<MonitorDetail>> GetByZoneAsync(string zone)
        {
            return await _context.ProdMonitor
                .Where(x => x.DisplayGroup == zone)
                .Include(x => x.IdMstLossGroupNavigation)
                .Select(x => new MonitorDetail
                {
                    LineName = x.LineName,
                    StatusId = x.IdMstLossGroup,
                    PlanShot = x.PlanShot,
                    ActualShot = x.ActualShot,
                    DefectQty = x.NgQty,
                    LossTime = x.LossTime,
                    PlanDiff = x.PlanDiff,
                    PlanId = x.PlanId,
                    IsUrgent = x.UrgentFlag,
                    UpdateDate = x.UpdateDate,
                    Zone = x.DisplayGroup,
                    Status = new Status
                    {
                        StatusId = x.IdMstLossGroupNavigation.IdFactor,
                        StatusName = x.IdMstLossGroupNavigation.StatusName,
                        TroubleName = x.IdMstLossGroupNavigation.TroubleName,
                        AppName = x.IdMstLossGroupNavigation.AppName,
                        Owner = x.IdMstLossGroupNavigation.Owner,
                        Charge = x.IdMstLossGroupNavigation.Charge,
                        StatusColor = x.IdMstLossGroupNavigation.BColor,
                        StopFlag = x.IdMstLossGroupNavigation.FlagStop,
                        OrderNumber = x.IdMstLossGroupNavigation.OrderNo,
                        Note = x.IdMstLossGroupNavigation.Note
                    }
                }).ToListAsync();
        }
    }
}

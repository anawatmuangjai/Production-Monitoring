using System;
using System.Collections.Generic;
using System.Text;

namespace PDR.Core.Models
{
    public class MonitorDetail
    {
        public string LineName { get; set; }
        public int StatusId { get; set; }
        public int PlanShot { get; set; }
        public int ActualShot { get; set; }
        public int DefectQty { get; set; }
        public int LossTime { get; set; }
        public int PlanDiff { get; set; }
        public int PlanId { get; set; }
        public bool IsUrgent { get; set; }
        public string UpdateDate { get; set; }
        public string Zone { get; set; }
        public Status Status { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PDR.Infrastructure.Entities
{
    public partial class ProdMonitor
    {
        public string LineName { get; set; }
        public int IdMstLossGroup { get; set; }
        public int PlanShot { get; set; }
        public int ActualShot { get; set; }
        public int NgQty { get; set; }
        public int LossTime { get; set; }
        public int PlanDiff { get; set; }
        public int PlanId { get; set; }
        public bool UrgentFlag { get; set; }
        public string UpdateDate { get; set; }
        public string DisplayGroup { get; set; }

        public MstLossGroup IdMstLossGroupNavigation { get; set; }
    }
}

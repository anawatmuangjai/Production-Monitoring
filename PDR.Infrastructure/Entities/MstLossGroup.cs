using System;
using System.Collections.Generic;

namespace PDR.Infrastructure.Entities
{
    public partial class MstLossGroup
    {
        public MstLossGroup()
        {
            ProdMonitor = new HashSet<ProdMonitor>();
        }

        public int IdFactor { get; set; }
        public string TroubleName { get; set; }
        public string AppName { get; set; }
        public string StatusName { get; set; }
        public string Owner { get; set; }
        public string Charge { get; set; }
        public string BColor { get; set; }
        public bool FlagStop { get; set; }
        public int OrderNo { get; set; }
        public string Note { get; set; }

        public ICollection<ProdMonitor> ProdMonitor { get; set; }
    }
}

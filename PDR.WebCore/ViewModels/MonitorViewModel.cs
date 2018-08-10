using PDR.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDR.WebCore.ViewModels
{
    public class MonitorViewModel
    {
        public IEnumerable<MonitorDetail> MonitorDetails { get; set; }
    }
}

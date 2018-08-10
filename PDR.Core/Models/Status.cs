using System;
using System.Collections.Generic;
using System.Text;

namespace PDR.Core.Models
{
    public class Status
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string TroubleName { get; set; }
        public string AppName { get; set; }
        public string Owner { get; set; }
        public string Charge { get; set; }
        public string StatusColor { get; set; }
        public bool StopFlag { get; set; }
        public int OrderNumber { get; set; }
        public string Note { get; set; }
    }
}

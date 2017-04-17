using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minerva.Models
{
    public class Performance
    {
        public virtual int PerformanceId { get; set; }
        public virtual int Cores { get; set; }
        public virtual int Threads { get; set; }
        public virtual double Frequency { get; set; }
        public virtual double Turbo { get; set; }
        public virtual int L1 { get; set; }
        public virtual int L2 { get; set; }
        public virtual int L3 { get; set; }
        public virtual int Tdp { get; set; }
    }
}
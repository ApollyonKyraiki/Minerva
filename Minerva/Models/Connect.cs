using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minerva.Models
{
    public class Connect
    {
        public virtual int ConnectId { get; set; }
        public virtual int MaxMemory { get; set; }
        public virtual string MemoryType { get; set; }
        public virtual string MemoryChannels { get; set; }
        public virtual double MemoryBandwidth { get; set; }
        public virtual bool ECC { get; set; }
        public virtual string Scalability { get; set; }
        public virtual string PCIRev { get; set; }
        public virtual int PCILanes { get; set; }
    }
}
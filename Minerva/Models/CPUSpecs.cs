using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minerva.Models
{
    public class CPUSpecs
    {
        public virtual int CPUSpecsId { get; set; }
        public virtual int FeaturesId { get; set; }
        public virtual int PerformanceId { get; set; }
        public virtual int ConnectId { get; set; }
        public virtual string Brand { get; set; }
        public virtual string Family { get; set; }
        public virtual string Model { get; set; }
        public virtual string uarch { get; set; }
        public virtual int Lithography { get; set; }
        public virtual DateTime ReleaseDate { get; set; }
        public virtual double LaunchPrice { get; set; }
        public virtual string Socket { get; set; }
        public virtual Features Features { get; set; }
        public virtual Performance Performance { get; set; }
        public virtual Connect Connect { get; set; }
    }
}
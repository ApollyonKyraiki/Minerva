using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minerva.Models
{
    public class Features
    {
        public virtual int FeaturesId { get; set; }
        public virtual bool SSE { get; set; }
        public virtual bool SSE2 { get; set; }
        public virtual bool SSE3 { get; set; }
        public virtual bool SSSE3 { get; set; }
        public virtual bool SSE4 { get; set; }
        public virtual bool AES { get; set; }
        public virtual string AVX { get; set; }
        public virtual bool XD { get; set; }
        public virtual bool VTx { get; set; }
        public virtual bool VTd { get; set; }
    }
}
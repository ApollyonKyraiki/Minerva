using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minerva.Models
{
    public class Paper
    {
        public virtual int PaperId { get; set; }
        public virtual string Brand { get; set; }
        public virtual string Model { get; set; }
        public virtual string Binding { get; set; }
        public virtual string Ruled { get; set; }
        public virtual bool Refillable { get; set; }
        public virtual int Quantity { get; set; }
        public virtual string PaperSize { get; set; }
        public virtual double Price { get; set; }
    }
}
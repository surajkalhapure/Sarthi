using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sarthi.Models
{
    public class SarthiContext:DbContext
    {
        public DbSet<Register> Register { get; set; }
    }
}
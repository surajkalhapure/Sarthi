using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sarthi.Models
{
    public class Register
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string Pass {  get; set; }

    }
}
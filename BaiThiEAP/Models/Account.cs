using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaiThiEAP.Models
{
    public class Account
    {
        [Required]
        public int Code { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public String Password { get; set; }
        public String Username { get; set; }
        public decimal Blance { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TDLBack.Models
{
    public class Login
    {
        public int Id { get; set; }

        [Required]
        public string userName { get; set; }

        [Required]
        public string password { get; set; }
    }
}

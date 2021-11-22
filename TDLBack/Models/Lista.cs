using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TDLBack.Models
{
    public class Lista
    {
        public int Id { get; set; }
       
        [Required]
        public string item { get; set; }
    }
}

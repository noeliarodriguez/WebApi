using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string User_Api { get; set; }
        [Required]
        public string Pass_Api { get; set; }
        public bool Lvl_Access { get; set; }

    }
}

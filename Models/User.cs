using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace core_bili.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [Display(Name = "用户名")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "密码")]
        [MinLength(7)]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }

 
    }
}

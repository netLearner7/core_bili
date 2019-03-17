using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace core_bili.Models
{
    public class RegisterViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="用户名")]
        public string Name { get; set; }
        
        [Required]
        [Display(Name ="密码")]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
    }
}

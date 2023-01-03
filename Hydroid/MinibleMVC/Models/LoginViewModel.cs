using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Minible5.Models
{
    public class LoginViewModel
    {
        
            public int UserId { get; set; }

            [Required(ErrorMessage = "Required.")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Required.")]
            public string Password { get; set; }
        
    }
}
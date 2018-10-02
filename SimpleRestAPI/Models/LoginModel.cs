using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleRestAPI.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Требуется имя пользователя")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Требуется имя пользователя")]
        public string Password { get; set; }
    }
}

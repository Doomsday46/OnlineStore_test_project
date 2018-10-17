using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineStore.Models
{
    public class UserView
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Введите email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Пароли должны совпадать")]
        public string ConfirmPassword { get; set; }

        public string Captcha { get; set; }

        public string AvatarPath { get; set; }

    }
}
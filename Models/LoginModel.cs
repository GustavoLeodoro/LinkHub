﻿using System.ComponentModel.DataAnnotations;

namespace LinkHub.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "O campo Login é obrigatório.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O campo senha é obrigatório.")]
        public string Senha { get; set; }
        

    }
}

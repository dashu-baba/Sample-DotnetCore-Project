﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreAccessControl.Domain.RequestModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [MaxLength(250, ErrorMessage = "Email max length sould be 250 character.")]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_‘{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_‘{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Email is not valid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [MaxLength(250, ErrorMessage = "Password max length sould be 250 character.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "SecurityQuestion is required.")]
        [MaxLength(200, ErrorMessage = "SecurityQuestion max length sould be 250 character.")]
        public string SecurityQuestion { get; set; }
        [Required(ErrorMessage = "SecurityQuestionAnswer is required.")]
        [MaxLength(200, ErrorMessage = "SecurityQuestionAnswer max length sould be 250 character.")]
        public string SecurityQuestionAnswer { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace App.Models
{
    public class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string UserId { get; set; }
        [Required(ErrorMessage = "Proszę wprowadź nazwę użytkownika")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Proszę wprowadź hasło")]
        public string Password { get; set; }
        public string Role { get; set; }
        [Required(ErrorMessage = "Proszę wprowadź email")]
        public string Email { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library_System.Models
{


    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

     
//        [Display(Name = "Rol")]
//        public int Role { get; set; }
//
//
//        [Display(Name = "Creacion")]
//        public DateTime CreatedAt { get; set; }
//
//
//        [Display(Name = "Actualización")]
//        public DateTime UpdatedAt { get; set; }

    }

    public class LoginViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "El Nombre debe tener al menos 2 caracteres", MinimumLength = 2)]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "La contraseña debe tener al menos 6 caracteres", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contraseña")]
        [Compare("Password", ErrorMessage = "La contraseña y la contraseña de confirmación no son iguales.")]
        public string ConfirmPassword { get; set; }
    }

}

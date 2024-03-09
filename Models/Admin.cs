using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Albergo.Models
{
    public class Admin
    {

        [Key]
        public int Admin_ID { get; set; }

        // E-mail
        [Required(ErrorMessage = "Email Campo Obbligatorio")]
        [Display(Name = "E-mail")]
        [StringLength(255, ErrorMessage = "L'email deve avere massimo 255 caratteri")]
        [RegularExpression(@"^[\w-.]+@([\w-]+.)+[\w-]{2,4}$", ErrorMessage = "Inserisci un indirizzo email valido")]
        public string Email { get; set; }

        //Password
        [Required(ErrorMessage = " Password Campo Obbligatorio")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "la password deve contenere meno di 50 caratteri, almeno 5")]
        public string Password { get; set; }


    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Albergo.Models
{
    public class Servizio
    {
        [Key]
        public int Servizio_ID { get; set; }

        //Tipo
        [Required(ErrorMessage = "Campo Obbligatorio")]
        [Display(Name = "Tipo Servizio")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Il tipo deve contenere massimo 50 caratteri")]
        public string Tipo { get; set; }


    }
}

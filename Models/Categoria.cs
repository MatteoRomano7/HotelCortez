using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Albergo.Models
{
    public class Categoria
    {
        [Key]
        public int Categoria_ID { get; set; }

        //Tipo
        [Required(ErrorMessage = "Campo Obbligatorio")]
        [Display(Name = "Tipo Camera")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Il tipo deve contenere massimo 50 caratteri")]
        public string Tipo { get; set; }

        //Tariffa
        [Required(ErrorMessage = "Campo Obbligatorio")]
        [Range(1, 1000000, ErrorMessage = "Max 1000000 min 10 cifre")]
        public decimal TariffaNotte { get; set; }

        //Caparra
        [Required(ErrorMessage = "Campo Obbligatorio")]
        [Range(1, 1000000, ErrorMessage = "Max 1000000 min 10 cifre")]
        public decimal Caparra { get; set; }


    }
}
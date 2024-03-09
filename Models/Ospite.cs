using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Albergo.Models
{
    public class Ospite
    {
        [Key]
        public int Ospite_ID { get; set; }

        //Nome
        [Required(ErrorMessage = "Campo Obbligatorio")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Il nome deve contenere massimo 50 caratteri")]
        public string Nome { get; set; }

        //Cognome
        [Required(ErrorMessage = "Campo Obbligatorio")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Il cognome deve contenere massimo 50 caratteri")]
        public string Cognome { get; set; }

        //Citta
        [Required(ErrorMessage = "Campo Obbligatorio")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "La città deve contenere massimo 50 caratteri")]
        public string Citta { get; set; }

        //Provincia
        [Required(ErrorMessage = "Campo Obbligatorio")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "La provincia deve contenere massimo 50 caratteri")]
        public string Provincia { get; set; }

        // E-mail
        [Required(ErrorMessage = "Campo Obbligatorio")]
        [Display(Name = "E-mail")]
        [StringLength(255, ErrorMessage = "L'email deve avere massimo 255 caratteri")]
        [RegularExpression(@"^[\w-.]+@([\w-]+.)+[\w-]{2,4}$", ErrorMessage = "Inserisci un indirizzo email valido")]
        public string Email { get; set; }

        //Tel / Cell
        [Required(ErrorMessage = "Campo Obbligatorio")]
        [Display(Name = "Telefono/Cellulare")]
        [StringLength(20, MinimumLength = 7, ErrorMessage = "Minimo 7 cifre, massimo 20")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Il campo Tel accetta solo numeri.")]
        public string Telefono { get; set; }

        // Codice Fiscale
        [Required(ErrorMessage = "Campo Obbligatorio")]
        [Display(Name = "Codice Fiscale")]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "Il codice fiscale deve avere 16 caratteri")]
        public string Cod_Fisc { get; set; }















    }
}
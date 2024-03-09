using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Albergo.Models
{
    public class PS
    {
        public int Prenotazione_ID { get; set; }
        public int Servizio_ID { get; set; }

        public Prenotazione Prenotazione { get; set; }
        public Servizio Servizio { get; set; }

        //Data servizio
        [Required(ErrorMessage = "Campo Obbligatorio")]
        [Display(Name = "Data")]
        public DateTime Data_Serv { get; set; }

        //Quantità
        [Required(ErrorMessage = "Campo Obbligatorio")]
        public int Quantita { get; set; }

        //Servizio
        [Required(ErrorMessage = "Campo Obbligatorio")]
        [Display(Name = "Prezzo Servizio")]
        [Range(1, 1000000, ErrorMessage = "Max 1000000 min 10 cifre")]
        public decimal PrezzoServ { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Albergo.Models
{
    public class Prenotazione
    {
        [Key]
        public int Prenotazione_ID { get; set; }

        //Data Prenotazione
        [Required(ErrorMessage = "Campo obbligatorio")]
        [Display(Name = "Data prenotazione")]

        public DateTime Data_Pren { get; set; }



        //Data Arrivo
        [Required(ErrorMessage = "Campo obbligatorio")]
        [Display(Name = "Data arrivo")]

        public DateTime Data_Arrivo { get; set; }



        //Data Partenza
        [Required(ErrorMessage = "Campo obbligatorio")]
        [Display(Name = "Data partenza")]

        public DateTime Data_Partenza { get; set; }

        //AnnoProg
        public int AnnoProg { get; set; }

        public int Pensione_ID { get; set; }
        public int Ospite_ID { get; set; }
        public int Camera_ID { get; set; }


        public Pensione Pensione { get; set; }
        public Ospite Ospite { get; set; }
        public Camera Camera { get; set; }

        public Checkout Checkout { get; set; }




    }
}
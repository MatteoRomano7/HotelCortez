using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Albergo.Models
{
    public class Camera
    {
        [Key]
        public int Camera_ID { get; set; }

        //Numero
        [Required(ErrorMessage = "Campo Obbligatorio")]
        public int Numero { get; set; }

        //Descrizione 
        [Required(ErrorMessage = "Campo Obbligatorio")]
        [StringLength(255, ErrorMessage = "La descrizione deve avere massimo 255 caratteri")]
        public string Descrizione { get; set; }


        //ID categoria
        [Required(ErrorMessage = "Campo Obbligatorio")]
        public int Categoria_ID { get; set; }


        //Categoria
        [Required(ErrorMessage = "Campo Obbligatorio")]
        public Categoria Categoria { get; set; }



    }
}

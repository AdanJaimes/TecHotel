using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TecHotel.Models
{
   public class Suscripciones
    {
        [Key]
        public int IdSuscripciones { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }
    }
}

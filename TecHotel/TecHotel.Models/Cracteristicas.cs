using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TecHotel.Models
{
   public class Cracteristicas
    {
        [Key]
        public int IdCracteristicas { get; set; }
        public string Nombre { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TecHotel.Models
{
   public class ServiciosExtras
    {
		[Key]
		public int IdServiciosExtras { get; set; }
		public string Servicio { get; set; }
		public decimal Costo { get; set; }
		[ForeignKey("Hoteles")]
		public int? HotelId { get; set; }
		[ForeignKey("Habitaciones")]
		public int? HabitacionId { get; set; }		
		public string Descripcion { get; set; }
		[ForeignKey("Usuarios")]
		public int UsuarioId { get; set; }
		public bool Activo { get; set; }
		public virtual Hoteles Hoteles { get; set; }
		public virtual Habitaciones Habitaciones { get; set; }
		public virtual Usuarios Usuarios { get; set; }
	}
}

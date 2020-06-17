using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TecHotel.Models
{
	public class Imagenes
	{
		[Key]
		public int IdImagenes { get; set; }
		public string Imagen { get; set; }
		public string Nombre { get; set; }
		[ForeignKey("Hoteles")]
		public int? HotelId { get; set; }
		[ForeignKey("Habitaciones")]
		public int? HabitacionId { get; set; }
		[ForeignKey("ServiciosExtras")]
		public int? ServicioId { get; set; }
		[ForeignKey("Blog")]
		public int? BlogId { get; set; }
		public bool Activo { get; set; }
		public virtual Blog Blog { get; set; }
		public virtual Habitaciones Habitaciones { get; set; }
		public virtual Hoteles Hoteles { get; set; }
		public virtual ServiciosExtras ServiciosExtras { get; set; }
	}
}

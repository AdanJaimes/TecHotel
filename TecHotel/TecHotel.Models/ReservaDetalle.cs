﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TecHotel.Models
{
   public class ReservaDetalle
    {
		[Key]
		public int IdReservaDetalle { get; set; }
		public int TotalDias { get; set; }
		public int Adultos { get; set; }
		public int Niños { get; set; }
		public int Infantes { get; set; }
		public decimal CostoHabitacion { get; set; }
		[ForeignKey("Reservas")]
		public int ReservaId { get; set; }
		[ForeignKey("Habitaciones")]
		public int HabitacionId { get; set; }
		public virtual Habitaciones Habitaciones { get; set; }
		public virtual Reservas Reservas { get; set; }
	}
}

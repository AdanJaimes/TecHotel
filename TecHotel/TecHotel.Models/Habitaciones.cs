﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TecHotel.Models
{
   public class Habitaciones
    {
		[Key]
		public int IdHabitaciones { get; set; }
		public string Titulo { get; set; }
		public string PalabrasClave { get; set; }
		public string Descripcion { get; set; }
		public decimal Costo { get; set; }
		public int Adultos { get; set; }
		public int Niños { get; set; }
		public int Infantes { get; set; }
		public int MaximoAdultos { get; set; }
		public int MaximoNiños { get; set; }
		public int MaximoInfantes { get; set; }
		public int CostoAdicionalAdulto { get; set; }
		public int CostoAdicionalNiño { get; set; }
		public int CostoAdicionalInfante { get; set; }
		public int TotalHabitaciones { get; set; }
		public decimal Calificacion { get; set; }
		public int Activo { get; set; }
		[ForeignKey("Hoteles")]
		public int HotelId { get; set; }
		public virtual Hoteles Hoteles { get; set; }
	}
}

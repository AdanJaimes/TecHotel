﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TecHotel.Models
{
   public class Reservas
    {
		[Key]
		public int IdReservas { get; set; }
		public string Folio { get; set; }
		public DateTime FechaCreacion { get; set; }
		public DateTime FechaReversaInicia { get; set; }
		public DateTime FechaReversaFinaliza { get; set; }
		public decimal CostoTotal { get; set; }
		public string Estatus { get; set; }
		public string Email { get; set; }
		public string Nombres { get; set; }
		public string Apellidos { get; set; }
		public string Telefono { get; set; }
		public string Pais { get; set; }
		public string Estado { get; set; }
		public string Municipio { get; set; }
		public string Direccion { get; set; }
		public string CodigoPostal { get; set; }
		public string RequerimientosEspeciales { get; set; }
		public string ReferenciaPago { get; set; }
		[ForeignKey("Hoteles")]
		public string Tipo { get; set; }
		public int HotelId { get; set; }
		public virtual Hoteles Hoteles { get; set; }
	}
}

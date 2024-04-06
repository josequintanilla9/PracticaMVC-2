﻿using System.ComponentModel.DataAnnotations;

namespace PracticaMVC_2.Models
{
	public class equipos
	{
		[Key]
		[Display(Name = "ID")]
		public int id_equipos { get; set; }
		[Display(Name = "Nombre")]
		public string? nombre { get; set; }
		[Display(Name = "Descripción")]
		public string? descripcion { get; set; }
		[Display(Name = "Tipo de equipo")]
		public int? tipo_equipo_id { get; set; }
		[Display(Name = "Marca")]
		public int? marca_id { get; set; }
		[Display(Name = "Modelo")]
		public string? modelo { get; set; }
		[Display(Name = "Año de compra")]
		public int? anio_compra { get; set; }
		[Display(Name = "Costo")]
		public decimal? costo { get; set; }
		[Display(Name = "Vida util")]
		public int? vida_util { get; set; }
		[Display(Name = "Estado del equipo")]
		public int? estado_equipo_id { get; set; }
	}
}

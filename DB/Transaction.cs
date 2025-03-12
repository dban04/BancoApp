using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
	public class Transaction
	{
		public int Id { get; set; }

		[Required]
		[RegularExpression("Ingreso|Gasto", ErrorMessage = "El tipo debe ser 'Ingreso' o 'Gasto'.")]
		public string Tipo { get; set; } = string.Empty;

		[Required]
		[Range(0.01, double.MaxValue, ErrorMessage = "El monto debe ser mayor a 0.")]
		public decimal Monto { get; set; }

		[Required]
		public DateTime Fecha { get; set; } = DateTime.UtcNow;

		[MaxLength(255)]
		public string Descripcion { get; set; } = string.Empty;

		[Required]
		public string Categoria { get; set; } = string.Empty;
	}
}

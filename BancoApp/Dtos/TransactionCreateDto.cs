using System.ComponentModel.DataAnnotations;

namespace BancoApp.Dtos
{
	public class TransactionCreateDto
	{
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

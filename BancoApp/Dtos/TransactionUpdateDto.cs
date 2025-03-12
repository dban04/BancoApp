using System.ComponentModel.DataAnnotations;

namespace BancoApp.Dtos
{
	public class TransactionUpdateDto
	{
		[Required]
		[Range(0.01, double.MaxValue, ErrorMessage = "El monto debe ser mayor a 0.")]
		public decimal Monto { get; set; }

		[MaxLength(255)]
		public string Descripcion { get; set; } = string.Empty;
	}
}

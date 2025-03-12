namespace BancoApp.Dtos
{
	public class TransactionResponseDto
	{
		public int Id { get; set; }
		public string Tipo { get; set; } = string.Empty;
		public decimal Monto { get; set; }
		public DateTime Fecha { get; set; }
		public string Descripcion { get; set; } = string.Empty;
		public string Categoria { get; set; } = string.Empty;
	}
}

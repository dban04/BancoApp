using BancoApp.Dtos;
using DB;
using Microsoft.EntityFrameworkCore;


namespace BancoApp.Services
{
	public class TransactionService(BancoContext context) : ITransactionService
	{
		private readonly BancoContext _context = context;

		public async Task<IEnumerable<TransactionResponseDto>> GetAllTransactions()
		{
			return await _context.Transactions
				.Select(t => new TransactionResponseDto
				{
					Id = t.Id,
					Tipo = t.Tipo,
					Monto = t.Monto,
					Fecha = t.Fecha,
					Descripcion = t.Descripcion,
					Categoria = t.Categoria
				})
				.ToListAsync();
		}

		public async Task<TransactionResponseDto?> GetTransactionById(int id)
		{
			var transaction = await _context.Transactions.FindAsync(id);
			return transaction == null ? null : new TransactionResponseDto
			{
				Id = transaction.Id,
				Tipo = transaction.Tipo,
				Monto = transaction.Monto,
				Fecha = transaction.Fecha,
				Descripcion = transaction.Descripcion,
				Categoria = transaction.Categoria
			};
		}

		public async Task<TransactionResponseDto> CreateTransaction(TransactionCreateDto transactionDto)
		{
			var transaction = new Transaction
			{
				Tipo = transactionDto.Tipo,
				Monto = transactionDto.Monto,
				Fecha = transactionDto.Fecha,
				Descripcion = transactionDto.Descripcion,
				Categoria = transactionDto.Categoria
			};

			_context.Transactions.Add(transaction);
			await _context.SaveChangesAsync();

			return new TransactionResponseDto
			{
				Id = transaction.Id,
				Tipo = transaction.Tipo,
				Monto = transaction.Monto,
				Fecha = transaction.Fecha,
				Descripcion = transaction.Descripcion,
				Categoria = transaction.Categoria
			};
		}

		public async Task<bool> UpdateTransaction(int id, TransactionUpdateDto transactionDto)
		{
			var transaction = await _context.Transactions.FindAsync(id);
			if (transaction == null) return false;

			transaction.Monto = transactionDto.Monto;
			transaction.Descripcion = transactionDto.Descripcion;

			await _context.SaveChangesAsync();
			return true;
		}

		public async Task<bool> DeleteTransaction(int id)
		{
			var transaction = await _context.Transactions.FindAsync(id);
			if (transaction == null) return false;

			_context.Transactions.Remove(transaction);
			await _context.SaveChangesAsync();
			return true;
		}
	}
}

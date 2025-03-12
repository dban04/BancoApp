using BancoApp.Dtos;

namespace BancoApp.Services
{
	public interface ITransactionService
	{
		Task<IEnumerable<TransactionResponseDto>> GetAllTransactions();
		Task<TransactionResponseDto?> GetTransactionById(int id);
		Task<TransactionResponseDto> CreateTransaction(TransactionCreateDto transactionDto);
		Task<bool> UpdateTransaction(int id, TransactionUpdateDto transactionDto);
		Task<bool> DeleteTransaction(int id);
	}
}

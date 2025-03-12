using BancoApp.Dtos;
using BancoApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BancoApp.Controllers
{
	[Route("api/transactions")]
	[ApiController]
	public class TransactionController : ControllerBase
	{
		private readonly ITransactionService _service;

		public TransactionController(ITransactionService service)
		{
			_service = service;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll() => Ok(await _service.GetAllTransactions());

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id) =>
			await _service.GetTransactionById(id) is TransactionResponseDto transaction
				? Ok(transaction)
				: NotFound();

		[HttpPost]
		public async Task<IActionResult> Create(TransactionCreateDto transactionDto)
		{
			var createdTransaction = await _service.CreateTransaction(transactionDto);
			return CreatedAtAction(nameof(GetById), new { id = createdTransaction.Id }, createdTransaction);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> Update(int id, TransactionUpdateDto transactionDto) =>
			await _service.UpdateTransaction(id, transactionDto) ? NoContent() : NotFound();

		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(int id) =>
			await _service.DeleteTransaction(id) ? NoContent() : NotFound();
	}
}

﻿using ExpenseTracker.Core.Models;

namespace ExpenseTracker.Core.Interfaces
{
  public interface ITransactionRepository
  {
    Task<Guid> AddTransactionAsync(Transaction transaction);

    Task<Transaction> GetTransactionByIdAsync(Guid transactionId);

    Task<IEnumerable<Transaction>> GetTransactionsPaginatedAsync(int offset, int limit);

    Task<Transaction> UpdateTransactionAsync(Transaction transaction);

    Task<bool> DeleteTransactionAsync(Guid transactionId);

    Task<IEnumerable<Transaction>> GetTransactionsByTypeAsync(int transactionType);
  }
}

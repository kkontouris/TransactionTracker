using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionsTrackerApp.DataLayer;

namespace TransactionsTrackerApp.BusinessLayer
{
    public class TransactionService
    {
        private readonly TransactionRepository _transactionRepository;

        public TransactionService(TransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public void RecordTransaction(string name, decimal amount, DateTime date, string category, bool _isIncome)
        {
            var transaction = new Transaction
            {
                Name = name,
                Amount = amount,
                Date = date,
                Category = category,
                IsIncome = _isIncome
            };
            _transactionRepository.AddTransaction(transaction);
        }
        public IEnumerable<Transaction> GetAllTransactions()
        {
            return _transactionRepository.GetAllTransactions();
        }

    }
}

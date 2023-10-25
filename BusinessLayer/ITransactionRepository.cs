using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionsTrackerApp.DataLayer;

namespace TransactionsTrackerApp.BusinessLayer
{
        // Data Layer
        public interface ITransactionRepository
        {
            void AddTransaction(Transaction transaction);
            IEnumerable<Transaction> GetAllTransactions();
        }
    
}

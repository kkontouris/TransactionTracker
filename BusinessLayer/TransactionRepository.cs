using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionsTrackerApp.DataLayer;

namespace TransactionsTrackerApp.BusinessLayer
{
    public class TransactionRepository:ITransactionRepository
    {
        public void AddTransaction(Transaction transaction)
        {
            using (var context = new TransactionTrackerContext())
            {
                context.Transactions.Add(transaction);
                context.SaveChanges();
            }
            Console.WriteLine("Transaction is saved");
        }

        public IEnumerable<Transaction> GetAllTransactions()
        {
            using (var context = new TransactionTrackerContext())
            {
                return context.Transactions.ToList();
            }
        }
    }
}

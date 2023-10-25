using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionsTrackerApp.BusinessLayer;

namespace TransactionsTrackerApp.DataLayer
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public bool IsIncome { get; set; }

        public Transaction()
        {

        }
    }
}

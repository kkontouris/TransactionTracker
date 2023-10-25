using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TransactionsTrackerApp.BusinessLayer;

namespace TransactionsTrackerApp.DataLayer
{
    public class TransactionTrackerContext:DbContext
    {
            public DbSet<Transaction> Transactions { get; set; }

            public TransactionTrackerContext() : base("data source=.\\SQLEXPRESS; initial catalog=TransactionsCodeFirst; integrated security=SSPI")
            {

            }
    }
}

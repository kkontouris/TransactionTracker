using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransactionsTrackerApp.BusinessLayer;

namespace TransactionsTrackerApp.PresentationLayer
{
    public partial class MainForm : Form
    {
        private readonly TransactionService transactionService;

        public MainForm()
        {
            InitializeComponent();
            TransactionRepository transactionRepository= new TransactionRepository();
            this.transactionService = new TransactionService(transactionRepository);
        }

        private void AddExpenseButtonWinForm_Click(object sender, EventArgs e)
        {
            ExpensesForm expensesForm= new ExpensesForm(transactionService);
            expensesForm.Show();  
        }

        private void ViewTransactionButton_Click(object sender, EventArgs e)
        {
            var transactions= new TransactionRepository().GetAllTransactions();
            dataGridView1.DataSource= transactions;
        }

        private void AddIncomeButtonWinForm_Click(object sender, EventArgs e)
        {
            IncomesForm incomesForm= new IncomesForm(transactionService);
            incomesForm.Show();  
        }

        
    }
}

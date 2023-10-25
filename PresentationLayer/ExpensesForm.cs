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
    public partial class ExpensesForm : Form
    {
        private readonly TransactionService transactionService;
        public ExpensesForm(TransactionService transactionService)
        {
            InitializeComponent();
            this.transactionService = transactionService;
            
        }

        private void SaveExpenseButton_Click(object sender, EventArgs e)
        {
            string name = ExpenseNameTextBox.Text;
            decimal amount = decimal.Parse(ExpenseAmountTextBox.Text);
            DateTime date = DateTime.Now;
            string category= ExpensecomboBox.SelectedItem.ToString();
            bool IsIncome = false;

            transactionService.RecordTransaction(name, amount, date, category,false);
            ClearForm();
        }
        private void ClearForm()
        {
            // Clear form controls
            ExpensecomboBox.Items.Clear();
            ExpenseNameTextBox.Clear();
            ExpenseAmountTextBox.Clear();
        }
    }
}

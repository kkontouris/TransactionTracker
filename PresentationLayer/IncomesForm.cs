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
    public partial class IncomesForm : Form
    {
        private readonly TransactionService transactionService;
        public IncomesForm(TransactionService _transactionService)
        {
            InitializeComponent();
            this.transactionService = _transactionService;
        }

        private void SaveIncomeButton_Click(object sender, EventArgs e)
        {
            string Name=IncomeNameTextBox.Text;
            decimal Amount= decimal.Parse(IncomeAmountTextBox.Text);
            string category=IncomecomboBox.SelectedItem.ToString();
            DateTime date= DateTime.Now;
            bool isIncome = true;

            transactionService.RecordTransaction(Name,Amount, date, category, true);
            ClearForm();
        }
        private void ClearForm()
        {
            // Clear form controls
            IncomeNameTextBox.Clear();
            IncomeAmountTextBox.Clear();
            IncomecomboBox.Items.Clear();
        }
    }
}

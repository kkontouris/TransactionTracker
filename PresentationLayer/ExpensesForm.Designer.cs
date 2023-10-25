namespace TransactionsTrackerApp.PresentationLayer
{
    partial class ExpensesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExpenseNameLabel = new System.Windows.Forms.Label();
            this.ExpenseAmountLabel = new System.Windows.Forms.Label();
            this.ExpenseDateLabel = new System.Windows.Forms.Label();
            this.ExpenseCategoryLabel = new System.Windows.Forms.Label();
            this.ExpenseNameTextBox = new System.Windows.Forms.TextBox();
            this.ExpenseAmountTextBox = new System.Windows.Forms.TextBox();
            this.ExpensedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ExpensecomboBox = new System.Windows.Forms.ComboBox();
            this.IsIncomeCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveExpenseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExpenseNameLabel
            // 
            this.ExpenseNameLabel.AutoSize = true;
            this.ExpenseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseNameLabel.Location = new System.Drawing.Point(620, 128);
            this.ExpenseNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExpenseNameLabel.Name = "ExpenseNameLabel";
            this.ExpenseNameLabel.Size = new System.Drawing.Size(48, 16);
            this.ExpenseNameLabel.TabIndex = 0;
            this.ExpenseNameLabel.Text = "Name";
            // 
            // ExpenseAmountLabel
            // 
            this.ExpenseAmountLabel.AutoSize = true;
            this.ExpenseAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseAmountLabel.Location = new System.Drawing.Point(620, 201);
            this.ExpenseAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExpenseAmountLabel.Name = "ExpenseAmountLabel";
            this.ExpenseAmountLabel.Size = new System.Drawing.Size(58, 16);
            this.ExpenseAmountLabel.TabIndex = 1;
            this.ExpenseAmountLabel.Text = "Amount";
            // 
            // ExpenseDateLabel
            // 
            this.ExpenseDateLabel.AutoSize = true;
            this.ExpenseDateLabel.Location = new System.Drawing.Point(620, 270);
            this.ExpenseDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExpenseDateLabel.Name = "ExpenseDateLabel";
            this.ExpenseDateLabel.Size = new System.Drawing.Size(40, 16);
            this.ExpenseDateLabel.TabIndex = 2;
            this.ExpenseDateLabel.Text = "Date";
            // 
            // ExpenseCategoryLabel
            // 
            this.ExpenseCategoryLabel.AutoSize = true;
            this.ExpenseCategoryLabel.Location = new System.Drawing.Point(620, 332);
            this.ExpenseCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExpenseCategoryLabel.Name = "ExpenseCategoryLabel";
            this.ExpenseCategoryLabel.Size = new System.Drawing.Size(70, 16);
            this.ExpenseCategoryLabel.TabIndex = 3;
            this.ExpenseCategoryLabel.Text = "Category";
            // 
            // ExpenseNameTextBox
            // 
            this.ExpenseNameTextBox.Location = new System.Drawing.Point(738, 122);
            this.ExpenseNameTextBox.Name = "ExpenseNameTextBox";
            this.ExpenseNameTextBox.Size = new System.Drawing.Size(234, 22);
            this.ExpenseNameTextBox.TabIndex = 4;
            // 
            // ExpenseAmountTextBox
            // 
            this.ExpenseAmountTextBox.Location = new System.Drawing.Point(738, 196);
            this.ExpenseAmountTextBox.Name = "ExpenseAmountTextBox";
            this.ExpenseAmountTextBox.Size = new System.Drawing.Size(223, 22);
            this.ExpenseAmountTextBox.TabIndex = 5;
            // 
            // ExpensedateTimePicker
            // 
            this.ExpensedateTimePicker.Location = new System.Drawing.Point(738, 265);
            this.ExpensedateTimePicker.Name = "ExpensedateTimePicker";
            this.ExpensedateTimePicker.Size = new System.Drawing.Size(269, 22);
            this.ExpensedateTimePicker.TabIndex = 6;
            // 
            // ExpensecomboBox
            // 
            this.ExpensecomboBox.FormattingEnabled = true;
            this.ExpensecomboBox.Items.AddRange(new object[] {
            "Food",
            "Coffee",
            "Car",
            "Medicine",
            "Entertainment",
            "Home",
            "Clothes",
            "Other"});
            this.ExpensecomboBox.Location = new System.Drawing.Point(738, 324);
            this.ExpensecomboBox.Name = "ExpensecomboBox";
            this.ExpensecomboBox.Size = new System.Drawing.Size(121, 24);
            this.ExpensecomboBox.TabIndex = 7;
            // 
            // IsIncomeCheckBox
            // 
            this.IsIncomeCheckBox.AutoSize = true;
            this.IsIncomeCheckBox.Location = new System.Drawing.Point(738, 393);
            this.IsIncomeCheckBox.Name = "IsIncomeCheckBox";
            this.IsIncomeCheckBox.Size = new System.Drawing.Size(88, 20);
            this.IsIncomeCheckBox.TabIndex = 8;
            this.IsIncomeCheckBox.Text = "IsIncome";
            this.IsIncomeCheckBox.UseVisualStyleBackColor = true;
            this.IsIncomeCheckBox.Visible = false;
            // 
            // SaveExpenseButton
            // 
            this.SaveExpenseButton.BackColor = System.Drawing.Color.Turquoise;
            this.SaveExpenseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveExpenseButton.Location = new System.Drawing.Point(665, 453);
            this.SaveExpenseButton.Name = "SaveExpenseButton";
            this.SaveExpenseButton.Size = new System.Drawing.Size(212, 31);
            this.SaveExpenseButton.TabIndex = 19;
            this.SaveExpenseButton.Text = "Save Expense";
            this.SaveExpenseButton.UseVisualStyleBackColor = false;
            this.SaveExpenseButton.Click += new System.EventHandler(this.SaveExpenseButton_Click);
            // 
            // ExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 725);
            this.Controls.Add(this.SaveExpenseButton);
            this.Controls.Add(this.IsIncomeCheckBox);
            this.Controls.Add(this.ExpensecomboBox);
            this.Controls.Add(this.ExpensedateTimePicker);
            this.Controls.Add(this.ExpenseAmountTextBox);
            this.Controls.Add(this.ExpenseNameTextBox);
            this.Controls.Add(this.ExpenseCategoryLabel);
            this.Controls.Add(this.ExpenseDateLabel);
            this.Controls.Add(this.ExpenseAmountLabel);
            this.Controls.Add(this.ExpenseNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExpensesForm";
            this.Text = "ExpensesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExpenseNameLabel;
        private System.Windows.Forms.Label ExpenseAmountLabel;
        private System.Windows.Forms.Label ExpenseDateLabel;
        private System.Windows.Forms.Label ExpenseCategoryLabel;
        private System.Windows.Forms.TextBox ExpenseNameTextBox;
        private System.Windows.Forms.TextBox ExpenseAmountTextBox;
        private System.Windows.Forms.DateTimePicker ExpensedateTimePicker;
        private System.Windows.Forms.ComboBox ExpensecomboBox;
        private System.Windows.Forms.CheckBox IsIncomeCheckBox;
        private System.Windows.Forms.Button SaveExpenseButton;
    }
}
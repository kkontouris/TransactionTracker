namespace TransactionsTrackerApp.PresentationLayer
{
    partial class IncomesForm
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
            this.IsIncomeCheckBox = new System.Windows.Forms.CheckBox();
            this.IncomecomboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.IncomeAmountTextBox = new System.Windows.Forms.TextBox();
            this.IncomeNameTextBox = new System.Windows.Forms.TextBox();
            this.ExpenseCategoryLabel = new System.Windows.Forms.Label();
            this.ExpenseDateLabel = new System.Windows.Forms.Label();
            this.ExpenseAmountLabel = new System.Windows.Forms.Label();
            this.ExpenseNameLabel = new System.Windows.Forms.Label();
            this.SaveIncomeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IsIncomeCheckBox
            // 
            this.IsIncomeCheckBox.AutoSize = true;
            this.IsIncomeCheckBox.Checked = true;
            this.IsIncomeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsIncomeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsIncomeCheckBox.Location = new System.Drawing.Point(583, 417);
            this.IsIncomeCheckBox.Name = "IsIncomeCheckBox";
            this.IsIncomeCheckBox.Size = new System.Drawing.Size(88, 20);
            this.IsIncomeCheckBox.TabIndex = 17;
            this.IsIncomeCheckBox.Text = "IsIncome";
            this.IsIncomeCheckBox.UseVisualStyleBackColor = true;
            this.IsIncomeCheckBox.Visible = false;
            // 
            // IncomecomboBox
            // 
            this.IncomecomboBox.FormattingEnabled = true;
            this.IncomecomboBox.Items.AddRange(new object[] {
            "Job Salary",
            "Tips",
            "Lotto",
            "Other"});
            this.IncomecomboBox.Location = new System.Drawing.Point(583, 348);
            this.IncomecomboBox.Name = "IncomecomboBox";
            this.IncomecomboBox.Size = new System.Drawing.Size(121, 21);
            this.IncomecomboBox.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(583, 289);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(269, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // IncomeAmountTextBox
            // 
            this.IncomeAmountTextBox.Location = new System.Drawing.Point(583, 220);
            this.IncomeAmountTextBox.Name = "IncomeAmountTextBox";
            this.IncomeAmountTextBox.Size = new System.Drawing.Size(223, 20);
            this.IncomeAmountTextBox.TabIndex = 14;
            // 
            // IncomeNameTextBox
            // 
            this.IncomeNameTextBox.Location = new System.Drawing.Point(583, 146);
            this.IncomeNameTextBox.Name = "IncomeNameTextBox";
            this.IncomeNameTextBox.Size = new System.Drawing.Size(234, 20);
            this.IncomeNameTextBox.TabIndex = 13;
            // 
            // ExpenseCategoryLabel
            // 
            this.ExpenseCategoryLabel.AutoSize = true;
            this.ExpenseCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseCategoryLabel.Location = new System.Drawing.Point(465, 356);
            this.ExpenseCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExpenseCategoryLabel.Name = "ExpenseCategoryLabel";
            this.ExpenseCategoryLabel.Size = new System.Drawing.Size(70, 16);
            this.ExpenseCategoryLabel.TabIndex = 12;
            this.ExpenseCategoryLabel.Text = "Category";
            // 
            // ExpenseDateLabel
            // 
            this.ExpenseDateLabel.AutoSize = true;
            this.ExpenseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseDateLabel.Location = new System.Drawing.Point(465, 294);
            this.ExpenseDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExpenseDateLabel.Name = "ExpenseDateLabel";
            this.ExpenseDateLabel.Size = new System.Drawing.Size(40, 16);
            this.ExpenseDateLabel.TabIndex = 11;
            this.ExpenseDateLabel.Text = "Date";
            // 
            // ExpenseAmountLabel
            // 
            this.ExpenseAmountLabel.AutoSize = true;
            this.ExpenseAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseAmountLabel.Location = new System.Drawing.Point(465, 225);
            this.ExpenseAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExpenseAmountLabel.Name = "ExpenseAmountLabel";
            this.ExpenseAmountLabel.Size = new System.Drawing.Size(58, 16);
            this.ExpenseAmountLabel.TabIndex = 10;
            this.ExpenseAmountLabel.Text = "Amount";
            // 
            // ExpenseNameLabel
            // 
            this.ExpenseNameLabel.AutoSize = true;
            this.ExpenseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseNameLabel.Location = new System.Drawing.Point(465, 152);
            this.ExpenseNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExpenseNameLabel.Name = "ExpenseNameLabel";
            this.ExpenseNameLabel.Size = new System.Drawing.Size(48, 16);
            this.ExpenseNameLabel.TabIndex = 9;
            this.ExpenseNameLabel.Text = "Name";
            // 
            // SaveIncomeButton
            // 
            this.SaveIncomeButton.BackColor = System.Drawing.Color.Turquoise;
            this.SaveIncomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveIncomeButton.Location = new System.Drawing.Point(532, 478);
            this.SaveIncomeButton.Name = "SaveIncomeButton";
            this.SaveIncomeButton.Size = new System.Drawing.Size(212, 31);
            this.SaveIncomeButton.TabIndex = 18;
            this.SaveIncomeButton.Text = "Save Income";
            this.SaveIncomeButton.UseVisualStyleBackColor = false;
            this.SaveIncomeButton.Click += new System.EventHandler(this.SaveIncomeButton_Click);
            // 
            // IncomesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 727);
            this.Controls.Add(this.SaveIncomeButton);
            this.Controls.Add(this.IsIncomeCheckBox);
            this.Controls.Add(this.IncomecomboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.IncomeAmountTextBox);
            this.Controls.Add(this.IncomeNameTextBox);
            this.Controls.Add(this.ExpenseCategoryLabel);
            this.Controls.Add(this.ExpenseDateLabel);
            this.Controls.Add(this.ExpenseAmountLabel);
            this.Controls.Add(this.ExpenseNameLabel);
            this.Name = "IncomesForm";
            this.Text = "IncomesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox IsIncomeCheckBox;
        private System.Windows.Forms.ComboBox IncomecomboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox IncomeAmountTextBox;
        private System.Windows.Forms.TextBox IncomeNameTextBox;
        private System.Windows.Forms.Label ExpenseCategoryLabel;
        private System.Windows.Forms.Label ExpenseDateLabel;
        private System.Windows.Forms.Label ExpenseAmountLabel;
        private System.Windows.Forms.Label ExpenseNameLabel;
        private System.Windows.Forms.Button SaveIncomeButton;
    }
}
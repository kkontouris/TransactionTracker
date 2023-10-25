namespace TransactionsTrackerApp.PresentationLayer
{
    partial class MainForm
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
            this.AddIncomeButtonWinForm = new System.Windows.Forms.Button();
            this.AddExpenseButtonWinForm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ViewTransactionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddIncomeButtonWinForm
            // 
            this.AddIncomeButtonWinForm.BackColor = System.Drawing.Color.PowderBlue;
            this.AddIncomeButtonWinForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddIncomeButtonWinForm.Location = new System.Drawing.Point(456, 464);
            this.AddIncomeButtonWinForm.Name = "AddIncomeButtonWinForm";
            this.AddIncomeButtonWinForm.Size = new System.Drawing.Size(116, 47);
            this.AddIncomeButtonWinForm.TabIndex = 0;
            this.AddIncomeButtonWinForm.Text = "Add Income";
            this.AddIncomeButtonWinForm.UseVisualStyleBackColor = false;
            this.AddIncomeButtonWinForm.Click += new System.EventHandler(this.AddIncomeButtonWinForm_Click);
            // 
            // AddExpenseButtonWinForm
            // 
            this.AddExpenseButtonWinForm.BackColor = System.Drawing.Color.PowderBlue;
            this.AddExpenseButtonWinForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddExpenseButtonWinForm.Location = new System.Drawing.Point(643, 464);
            this.AddExpenseButtonWinForm.Name = "AddExpenseButtonWinForm";
            this.AddExpenseButtonWinForm.Size = new System.Drawing.Size(116, 47);
            this.AddExpenseButtonWinForm.TabIndex = 1;
            this.AddExpenseButtonWinForm.Text = "Add Expense";
            this.AddExpenseButtonWinForm.UseVisualStyleBackColor = false;
            this.AddExpenseButtonWinForm.Click += new System.EventHandler(this.AddExpenseButtonWinForm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(137, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 290);
            this.dataGridView1.TabIndex = 2;
            // 
            // ViewTransactionButton
            // 
            this.ViewTransactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTransactionButton.Location = new System.Drawing.Point(671, 194);
            this.ViewTransactionButton.Name = "ViewTransactionButton";
            this.ViewTransactionButton.Size = new System.Drawing.Size(137, 36);
            this.ViewTransactionButton.TabIndex = 3;
            this.ViewTransactionButton.Text = "View Transactions";
            this.ViewTransactionButton.UseVisualStyleBackColor = true;
            this.ViewTransactionButton.Click += new System.EventHandler(this.ViewTransactionButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 727);
            this.Controls.Add(this.ViewTransactionButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddExpenseButtonWinForm);
            this.Controls.Add(this.AddIncomeButtonWinForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddIncomeButtonWinForm;
        private System.Windows.Forms.Button AddExpenseButtonWinForm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ViewTransactionButton;
    }
}
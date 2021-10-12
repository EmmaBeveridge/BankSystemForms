
namespace BankSystemForms
{
    partial class Form1
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
            this.buttonCreateCustomer = new System.Windows.Forms.Button();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.buttonViewBalance = new System.Windows.Forms.Button();
            this.buttonCreditAccount = new System.Windows.Forms.Button();
            this.buttonDebitAccount = new System.Windows.Forms.Button();
            this.labelSelectOption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCreateCustomer
            // 
            this.buttonCreateCustomer.Location = new System.Drawing.Point(295, 159);
            this.buttonCreateCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreateCustomer.Name = "buttonCreateCustomer";
            this.buttonCreateCustomer.Size = new System.Drawing.Size(251, 63);
            this.buttonCreateCustomer.TabIndex = 0;
            this.buttonCreateCustomer.Text = "Create New Customer";
            this.buttonCreateCustomer.UseVisualStyleBackColor = true;
            this.buttonCreateCustomer.Click += new System.EventHandler(this.buttonCreateCustomer_Click);
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Location = new System.Drawing.Point(295, 255);
            this.buttonCreateAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(251, 63);
            this.buttonCreateAccount.TabIndex = 1;
            this.buttonCreateAccount.Text = "Create New Account";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // buttonViewBalance
            // 
            this.buttonViewBalance.Location = new System.Drawing.Point(295, 350);
            this.buttonViewBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonViewBalance.Name = "buttonViewBalance";
            this.buttonViewBalance.Size = new System.Drawing.Size(251, 63);
            this.buttonViewBalance.TabIndex = 2;
            this.buttonViewBalance.Text = "View Account Balance";
            this.buttonViewBalance.UseVisualStyleBackColor = true;
            this.buttonViewBalance.Click += new System.EventHandler(this.buttonViewBalance_Click_1);
            // 
            // buttonCreditAccount
            // 
            this.buttonCreditAccount.Location = new System.Drawing.Point(295, 444);
            this.buttonCreditAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreditAccount.Name = "buttonCreditAccount";
            this.buttonCreditAccount.Size = new System.Drawing.Size(251, 63);
            this.buttonCreditAccount.TabIndex = 3;
            this.buttonCreditAccount.Text = "Credit Account";
            this.buttonCreditAccount.UseVisualStyleBackColor = true;
            // 
            // buttonDebitAccount
            // 
            this.buttonDebitAccount.Location = new System.Drawing.Point(295, 544);
            this.buttonDebitAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDebitAccount.Name = "buttonDebitAccount";
            this.buttonDebitAccount.Size = new System.Drawing.Size(251, 63);
            this.buttonDebitAccount.TabIndex = 4;
            this.buttonDebitAccount.Text = "Debit Account";
            this.buttonDebitAccount.UseVisualStyleBackColor = true;
            // 
            // labelSelectOption
            // 
            this.labelSelectOption.AutoSize = true;
            this.labelSelectOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectOption.Location = new System.Drawing.Point(264, 71);
            this.labelSelectOption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectOption.Name = "labelSelectOption";
            this.labelSelectOption.Size = new System.Drawing.Size(296, 42);
            this.labelSelectOption.TabIndex = 5;
            this.labelSelectOption.Text = "Select an option:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 782);
            this.Controls.Add(this.labelSelectOption);
            this.Controls.Add(this.buttonDebitAccount);
            this.Controls.Add(this.buttonCreditAccount);
            this.Controls.Add(this.buttonViewBalance);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.buttonCreateCustomer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateCustomer;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Button buttonViewBalance;
        private System.Windows.Forms.Button buttonCreditAccount;
        private System.Windows.Forms.Button buttonDebitAccount;
        private System.Windows.Forms.Label labelSelectOption;
    }
}



namespace BankSystemForms
{
    partial class CreateNewCustomerForm
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
            this.textBoxForename = new System.Windows.Forms.TextBox();
            this.labelForename = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelEnternewcust = new System.Windows.Forms.Label();
            this.labelEmailValid = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelForenameInvalid = new System.Windows.Forms.Label();
            this.labelSurnameInvalid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxForename
            // 
            this.textBoxForename.Location = new System.Drawing.Point(213, 119);
            this.textBoxForename.Name = "textBoxForename";
            this.textBoxForename.Size = new System.Drawing.Size(179, 20);
            this.textBoxForename.TabIndex = 0;
            this.textBoxForename.TextChanged += new System.EventHandler(this.textBoxForename_TextChanged);
            // 
            // labelForename
            // 
            this.labelForename.AutoSize = true;
            this.labelForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForename.Location = new System.Drawing.Point(81, 119);
            this.labelForename.Name = "labelForename";
            this.labelForename.Size = new System.Drawing.Size(115, 25);
            this.labelForename.TabIndex = 1;
            this.labelForename.Text = "Forename:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.Location = new System.Drawing.Point(92, 164);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(104, 25);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Surname:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(213, 164);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(179, 20);
            this.textBoxSurname.TabIndex = 3;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(213, 259);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDOB.TabIndex = 4;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(125, 210);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(71, 25);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(213, 210);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(237, 20);
            this.textBoxEmail.TabIndex = 6;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOB.Location = new System.Drawing.Point(59, 259);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(137, 25);
            this.labelDOB.TabIndex = 7;
            this.labelDOB.Text = "Date of Birth:";
            // 
            // labelEnternewcust
            // 
            this.labelEnternewcust.AutoSize = true;
            this.labelEnternewcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnternewcust.Location = new System.Drawing.Point(36, 54);
            this.labelEnternewcust.Name = "labelEnternewcust";
            this.labelEnternewcust.Size = new System.Drawing.Size(367, 33);
            this.labelEnternewcust.TabIndex = 8;
            this.labelEnternewcust.Text = "Enter new customer details";
            // 
            // labelEmailValid
            // 
            this.labelEmailValid.AutoSize = true;
            this.labelEmailValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailValid.Location = new System.Drawing.Point(474, 213);
            this.labelEmailValid.Name = "labelEmailValid";
            this.labelEmailValid.Size = new System.Drawing.Size(0, 20);
            this.labelEmailValid.TabIndex = 9;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(506, 291);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(118, 32);
            this.buttonSubmit.TabIndex = 10;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelForenameInvalid
            // 
            this.labelForenameInvalid.AutoSize = true;
            this.labelForenameInvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForenameInvalid.Location = new System.Drawing.Point(406, 119);
            this.labelForenameInvalid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelForenameInvalid.Name = "labelForenameInvalid";
            this.labelForenameInvalid.Size = new System.Drawing.Size(0, 20);
            this.labelForenameInvalid.TabIndex = 11;
            // 
            // labelSurnameInvalid
            // 
            this.labelSurnameInvalid.AutoSize = true;
            this.labelSurnameInvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurnameInvalid.Location = new System.Drawing.Point(406, 168);
            this.labelSurnameInvalid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSurnameInvalid.Name = "labelSurnameInvalid";
            this.labelSurnameInvalid.Size = new System.Drawing.Size(0, 20);
            this.labelSurnameInvalid.TabIndex = 12;
            // 
            // CreateNewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.labelSurnameInvalid);
            this.Controls.Add(this.labelForenameInvalid);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelEmailValid);
            this.Controls.Add(this.labelEnternewcust);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelForename);
            this.Controls.Add(this.textBoxForename);
            this.Name = "CreateNewCustomerForm";
            this.Text = "CreateNewCustomerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateNewCustomerForm_FormClosed_1);
            this.Load += new System.EventHandler(this.CreateNewCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxForename;
        private System.Windows.Forms.Label labelForename;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelEnternewcust;
        private System.Windows.Forms.Label labelEmailValid;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelForenameInvalid;
        private System.Windows.Forms.Label labelSurnameInvalid;
    }
}
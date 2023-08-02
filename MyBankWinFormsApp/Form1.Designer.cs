namespace MyBankWinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            emailTextBox = new TextBox();
            panel1 = new Panel();
            Register_Submit = new Button();
            label3 = new Label();
            label2 = new Label();
            PasswordTextBox = new TextBox();
            panel2 = new Panel();
            label11 = new Label();
            textBox10 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            RegCustomButton = new Button();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            OtherNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            FirstNameTextBox = new TextBox();
            label5 = new Label();
            RegisterCustomerTitle = new Label();
            textBox9 = new TextBox();
            panel3 = new Panel();
            SubmitWithdraw = new Button();
            SubmitDeposit = new Button();
            DescriptDepo = new TextBox();
            DepositAmount = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            Deposit = new Label();
            Description = new Label();
            AcctNumber = new TextBox();
            DescriptTrans = new TextBox();
            WithdrawAmount = new TextBox();
            AccountNum = new TextBox();
            Amount = new Label();
            AccountNumber = new Label();
            WithdrawTitle = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 84);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "Email";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailTextBox.Location = new Point(13, 116);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(210, 23);
            emailTextBox.TabIndex = 2;
            emailTextBox.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(Register_Submit);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(PasswordTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(emailTextBox);
            panel1.Location = new Point(38, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 286);
            panel1.TabIndex = 3;
            // 
            // Register_Submit
            // 
            Register_Submit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Register_Submit.BackColor = SystemColors.ActiveCaption;
            Register_Submit.Location = new Point(13, 228);
            Register_Submit.Name = "Register_Submit";
            Register_Submit.Size = new Size(150, 24);
            Register_Submit.TabIndex = 4;
            Register_Submit.Text = "Submit";
            Register_Submit.UseVisualStyleBackColor = false;
            Register_Submit.Click += Register_Submit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.InactiveCaption;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(83, 16);
            label3.Name = "label3";
            label3.Size = new Size(68, 30);
            label3.TabIndex = 5;
            label3.Text = "Log in";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 151);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.Location = new Point(13, 169);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(210, 23);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.TextChanged += textBox2_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(label11);
            panel2.Controls.Add(textBox10);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(RegCustomButton);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(OtherNameTextBox);
            panel2.Controls.Add(LastNameTextBox);
            panel2.Controls.Add(FirstNameTextBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(RegisterCustomerTitle);
            panel2.Location = new Point(349, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(287, 382);
            panel2.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 264);
            label11.Name = "label11";
            label11.Size = new Size(79, 15);
            label11.TabIndex = 15;
            label11.Text = "Account Type";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(22, 282);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(160, 190);
            label10.Name = "label10";
            label10.Size = new Size(85, 15);
            label10.TabIndex = 13;
            label10.Text = "PhoneNumber";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 194);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 12;
            label9.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(159, 124);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 11;
            label8.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 125);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 10;
            label7.Text = "OtherName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(157, 57);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 9;
            label6.Text = "LastName";
            label6.Click += label6_Click;
            // 
            // RegCustomButton
            // 
            RegCustomButton.BackColor = SystemColors.GradientActiveCaption;
            RegCustomButton.Location = new Point(65, 322);
            RegCustomButton.Name = "RegCustomButton";
            RegCustomButton.Size = new Size(150, 33);
            RegCustomButton.TabIndex = 8;
            RegCustomButton.Text = "Register";
            RegCustomButton.UseVisualStyleBackColor = false;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(157, 218);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(22, 218);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(157, 150);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 5;
            // 
            // OtherNameTextBox
            // 
            OtherNameTextBox.Location = new Point(22, 153);
            OtherNameTextBox.Name = "OtherNameTextBox";
            OtherNameTextBox.Size = new Size(100, 23);
            OtherNameTextBox.TabIndex = 4;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(157, 87);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(100, 23);
            LastNameTextBox.TabIndex = 3;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(22, 87);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(100, 23);
            FirstNameTextBox.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 57);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 1;
            label5.Text = "FirstName";
            // 
            // RegisterCustomerTitle
            // 
            RegisterCustomerTitle.AutoSize = true;
            RegisterCustomerTitle.BackColor = SystemColors.ActiveCaption;
            RegisterCustomerTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterCustomerTitle.Location = new Point(44, 18);
            RegisterCustomerTitle.Name = "RegisterCustomerTitle";
            RegisterCustomerTitle.Size = new Size(171, 28);
            RegisterCustomerTitle.TabIndex = 0;
            RegisterCustomerTitle.Text = "Register Customer";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(163, 394);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(SubmitWithdraw);
            panel3.Controls.Add(SubmitDeposit);
            panel3.Controls.Add(DescriptDepo);
            panel3.Controls.Add(DepositAmount);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(Deposit);
            panel3.Controls.Add(Description);
            panel3.Controls.Add(AcctNumber);
            panel3.Controls.Add(DescriptTrans);
            panel3.Controls.Add(WithdrawAmount);
            panel3.Controls.Add(AccountNum);
            panel3.Controls.Add(Amount);
            panel3.Controls.Add(AccountNumber);
            panel3.Controls.Add(WithdrawTitle);
            panel3.Location = new Point(690, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 376);
            panel3.TabIndex = 10;
            // 
            // SubmitWithdraw
            // 
            SubmitWithdraw.BackColor = SystemColors.ActiveCaption;
            SubmitWithdraw.Location = new Point(136, 133);
            SubmitWithdraw.Name = "SubmitWithdraw";
            SubmitWithdraw.Size = new Size(75, 23);
            SubmitWithdraw.TabIndex = 15;
            SubmitWithdraw.Text = "SubmitWithdraw";
            SubmitWithdraw.UseVisualStyleBackColor = false;
            // 
            // SubmitDeposit
            // 
            SubmitDeposit.BackColor = SystemColors.ActiveCaption;
            SubmitDeposit.Location = new Point(58, 331);
            SubmitDeposit.Name = "SubmitDeposit";
            SubmitDeposit.Size = new Size(116, 23);
            SubmitDeposit.TabIndex = 14;
            SubmitDeposit.Text = "SubmitDeposit";
            SubmitDeposit.UseVisualStyleBackColor = false;
            // 
            // DescriptDepo
            // 
            DescriptDepo.Location = new Point(9, 302);
            DescriptDepo.Name = "DescriptDepo";
            DescriptDepo.Size = new Size(100, 23);
            DescriptDepo.TabIndex = 13;
            // 
            // DepositAmount
            // 
            DepositAmount.Location = new Point(120, 259);
            DepositAmount.Name = "DepositAmount";
            DepositAmount.Size = new Size(100, 23);
            DepositAmount.TabIndex = 12;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(9, 284);
            label15.Name = "label15";
            label15.Size = new Size(67, 15);
            label15.TabIndex = 11;
            label15.Text = "Description";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(143, 241);
            label14.Name = "label14";
            label14.Size = new Size(51, 15);
            label14.TabIndex = 10;
            label14.Text = "Amount";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(9, 240);
            label13.Name = "label13";
            label13.Size = new Size(99, 15);
            label13.TabIndex = 9;
            label13.Text = "Account Number";
            // 
            // Deposit
            // 
            Deposit.AutoSize = true;
            Deposit.BackColor = SystemColors.ActiveCaption;
            Deposit.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Deposit.Location = new Point(77, 204);
            Deposit.Name = "Deposit";
            Deposit.Size = new Size(80, 28);
            Deposit.TabIndex = 8;
            Deposit.Text = "Deposit";
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Location = new Point(32, 112);
            Description.Name = "Description";
            Description.Size = new Size(67, 15);
            Description.TabIndex = 7;
            Description.Text = "Description";
            // 
            // AcctNumber
            // 
            AcctNumber.Location = new Point(9, 258);
            AcctNumber.Name = "AcctNumber";
            AcctNumber.Size = new Size(100, 23);
            AcctNumber.TabIndex = 6;
            // 
            // DescriptTrans
            // 
            DescriptTrans.Location = new Point(20, 134);
            DescriptTrans.Name = "DescriptTrans";
            DescriptTrans.Size = new Size(89, 23);
            DescriptTrans.TabIndex = 5;
            // 
            // WithdrawAmount
            // 
            WithdrawAmount.Location = new Point(120, 81);
            WithdrawAmount.Name = "WithdrawAmount";
            WithdrawAmount.Size = new Size(100, 23);
            WithdrawAmount.TabIndex = 4;
            // 
            // AccountNum
            // 
            AccountNum.Location = new Point(20, 81);
            AccountNum.Name = "AccountNum";
            AccountNum.Size = new Size(89, 23);
            AccountNum.TabIndex = 3;
            // 
            // Amount
            // 
            Amount.AutoSize = true;
            Amount.Location = new Point(160, 62);
            Amount.Name = "Amount";
            Amount.Size = new Size(51, 15);
            Amount.TabIndex = 2;
            Amount.Text = "Amount";
            // 
            // AccountNumber
            // 
            AccountNumber.AutoSize = true;
            AccountNumber.Location = new Point(20, 61);
            AccountNumber.Name = "AccountNumber";
            AccountNumber.Size = new Size(99, 15);
            AccountNumber.TabIndex = 1;
            AccountNumber.Text = "Account Number";
            AccountNumber.Click += label13_Click;
            // 
            // WithdrawTitle
            // 
            WithdrawTitle.AutoSize = true;
            WithdrawTitle.BackColor = SystemColors.ActiveCaption;
            WithdrawTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            WithdrawTitle.Location = new Point(58, 12);
            WithdrawTitle.Name = "WithdrawTitle";
            WithdrawTitle.Size = new Size(97, 28);
            WithdrawTitle.TabIndex = 0;
            WithdrawTitle.Text = "Withdraw";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(453, 17);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 11;
            label12.Text = "label12";
            label12.Click += label12_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(966, 507);
            Controls.Add(label12);
            Controls.Add(panel3);
            Controls.Add(textBox9);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox emailTextBox;
        private Panel panel1;
        private Label label2;
        private TextBox PasswordTextBox;
        private Label label3;
        private Button Register_Submit;
        private Panel panel2;
        private Label RegisterCustomerTitle;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox OtherNameTextBox;
        private TextBox LastNameTextBox;
        private TextBox FirstNameTextBox;
        private Label label5;
        private Label label6;
        private Button RegCustomButton;
        private TextBox textBox9;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Panel panel3;
        private Label label11;
        private TextBox textBox10;
        private Label WithdrawTitle;
        private Label label12;
        private Label AccountNumber;
        private Label Amount;
        private TextBox AcctNumber;
        private TextBox DescriptTrans;
        private TextBox WithdrawAmount;
        private TextBox AccountNum;
        private Label Description;
        private TextBox DescriptDepo;
        private TextBox DepositAmount;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label Deposit;
        private Button SubmitWithdraw;
        private Button SubmitDeposit;
    }
}
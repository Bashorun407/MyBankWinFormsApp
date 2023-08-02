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
            button1 = new Button();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            OtherNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            FirstNameTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox9 = new TextBox();
            panel3 = new Panel();
            Transaction = new Label();
            label12 = new Label();
            TransFirstName = new Label();
            TransLastname = new Label();
            TranFirstName = new TextBox();
            TranLastName = new TextBox();
            OtherName = new TextBox();
            TransactionType = new TextBox();
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
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(OtherNameTextBox);
            panel2.Controls.Add(LastNameTextBox);
            panel2.Controls.Add(FirstNameTextBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
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
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(65, 322);
            button1.Name = "button1";
            button1.Size = new Size(150, 33);
            button1.TabIndex = 8;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 18);
            label4.Name = "label4";
            label4.Size = new Size(171, 28);
            label4.TabIndex = 0;
            label4.Text = "Register Customer";
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
            panel3.Controls.Add(TransactionType);
            panel3.Controls.Add(OtherName);
            panel3.Controls.Add(TranLastName);
            panel3.Controls.Add(TranFirstName);
            panel3.Controls.Add(TransLastname);
            panel3.Controls.Add(TransFirstName);
            panel3.Controls.Add(Transaction);
            panel3.Location = new Point(690, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 337);
            panel3.TabIndex = 10;
            // 
            // Transaction
            // 
            Transaction.AutoSize = true;
            Transaction.BackColor = SystemColors.ActiveCaption;
            Transaction.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Transaction.Location = new Point(58, 12);
            Transaction.Name = "Transaction";
            Transaction.Size = new Size(110, 28);
            Transaction.TabIndex = 0;
            Transaction.Text = "Transaction";
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
            // TransFirstName
            // 
            TransFirstName.AutoSize = true;
            TransFirstName.Location = new Point(20, 61);
            TransFirstName.Name = "TransFirstName";
            TransFirstName.Size = new Size(61, 15);
            TransFirstName.TabIndex = 1;
            TransFirstName.Text = "FirstName";
            TransFirstName.Click += label13_Click;
            // 
            // TransLastname
            // 
            TransLastname.AutoSize = true;
            TransLastname.Location = new Point(160, 62);
            TransLastname.Name = "TransLastname";
            TransLastname.Size = new Size(60, 15);
            TransLastname.TabIndex = 2;
            TransLastname.Text = "LastName";
            // 
            // TranFirstName
            // 
            TranFirstName.Location = new Point(20, 81);
            TranFirstName.Name = "TranFirstName";
            TranFirstName.Size = new Size(89, 23);
            TranFirstName.TabIndex = 3;
            // 
            // TranLastName
            // 
            TranLastName.Location = new Point(120, 81);
            TranLastName.Name = "TranLastName";
            TranLastName.Size = new Size(100, 23);
            TranLastName.TabIndex = 4;
            // 
            // OtherName
            // 
            OtherName.Location = new Point(20, 134);
            OtherName.Name = "OtherName";
            OtherName.Size = new Size(89, 23);
            OtherName.TabIndex = 5;
            // 
            // TransactionType
            // 
            TransactionType.Location = new Point(120, 134);
            TransactionType.Name = "TransactionType";
            TransactionType.Size = new Size(100, 23);
            TransactionType.TabIndex = 6;
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
        private Label label4;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox OtherNameTextBox;
        private TextBox LastNameTextBox;
        private TextBox FirstNameTextBox;
        private Label label5;
        private Label label6;
        private Button button1;
        private TextBox textBox9;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Panel panel3;
        private Label label11;
        private TextBox textBox10;
        private Label Transaction;
        private Label label12;
        private Label TransFirstName;
        private Label TransLastname;
        private TextBox TransactionType;
        private TextBox OtherName;
        private TextBox TranLastName;
        private TextBox TranFirstName;
    }
}
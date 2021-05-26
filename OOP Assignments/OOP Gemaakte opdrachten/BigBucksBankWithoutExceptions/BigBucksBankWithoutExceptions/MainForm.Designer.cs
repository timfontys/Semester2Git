namespace BigBucksBankWithoutExceptions
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
            this.createAccountButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.initialBalanceTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.depositAmountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.depositButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.withdrawAmountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.withDrawButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nameInfoTextBox = new System.Windows.Forms.TextBox();
            this.balanceInfoTextBox = new System.Windows.Forms.TextBox();
            this.maxDepthInfoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(103, 71);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(117, 23);
            this.createAccountButton.TabIndex = 0;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(85, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(135, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // initialBalanceTextBox
            // 
            this.initialBalanceTextBox.Location = new System.Drawing.Point(85, 45);
            this.initialBalanceTextBox.Name = "initialBalanceTextBox";
            this.initialBalanceTextBox.Size = new System.Drawing.Size(135, 20);
            this.initialBalanceTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.createAccountButton);
            this.groupBox1.Controls.Add(this.initialBalanceTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 106);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Initial Balance";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.depositAmountTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.depositButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 81);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deposit";
            // 
            // depositAmountTextBox
            // 
            this.depositAmountTextBox.Location = new System.Drawing.Point(85, 23);
            this.depositAmountTextBox.Name = "depositAmountTextBox";
            this.depositAmountTextBox.Size = new System.Drawing.Size(135, 20);
            this.depositAmountTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "amount";
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(145, 49);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 0;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.withdrawAmountTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.withDrawButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 82);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Withdraw";
            // 
            // withdrawAmountTextBox
            // 
            this.withdrawAmountTextBox.Location = new System.Drawing.Point(85, 22);
            this.withdrawAmountTextBox.Name = "withdrawAmountTextBox";
            this.withdrawAmountTextBox.Size = new System.Drawing.Size(135, 20);
            this.withdrawAmountTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "amount";
            // 
            // withDrawButton
            // 
            this.withDrawButton.Location = new System.Drawing.Point(145, 48);
            this.withDrawButton.Name = "withDrawButton";
            this.withDrawButton.Size = new System.Drawing.Size(75, 23);
            this.withDrawButton.TabIndex = 0;
            this.withDrawButton.Text = "Withdraw";
            this.withDrawButton.UseVisualStyleBackColor = true;
            this.withDrawButton.Click += new System.EventHandler(this.withDrawButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nameInfoTextBox);
            this.groupBox4.Controls.Add(this.balanceInfoTextBox);
            this.groupBox4.Controls.Add(this.maxDepthInfoTextBox);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(250, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(211, 106);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Account Info";
            // 
            // nameInfoTextBox
            // 
            this.nameInfoTextBox.Location = new System.Drawing.Point(65, 19);
            this.nameInfoTextBox.Name = "nameInfoTextBox";
            this.nameInfoTextBox.ReadOnly = true;
            this.nameInfoTextBox.Size = new System.Drawing.Size(132, 20);
            this.nameInfoTextBox.TabIndex = 5;
            // 
            // balanceInfoTextBox
            // 
            this.balanceInfoTextBox.Location = new System.Drawing.Point(65, 73);
            this.balanceInfoTextBox.Name = "balanceInfoTextBox";
            this.balanceInfoTextBox.ReadOnly = true;
            this.balanceInfoTextBox.Size = new System.Drawing.Size(132, 20);
            this.balanceInfoTextBox.TabIndex = 4;
            // 
            // maxDepthInfoTextBox
            // 
            this.maxDepthInfoTextBox.Location = new System.Drawing.Point(65, 45);
            this.maxDepthInfoTextBox.Name = "maxDepthInfoTextBox";
            this.maxDepthInfoTextBox.ReadOnly = true;
            this.maxDepthInfoTextBox.Size = new System.Drawing.Size(132, 20);
            this.maxDepthInfoTextBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Max Debt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 303);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Big Bucks Banking";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox initialBalanceTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox depositAmountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox withdrawAmountTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button withDrawButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameInfoTextBox;
        private System.Windows.Forms.TextBox balanceInfoTextBox;
        private System.Windows.Forms.TextBox maxDepthInfoTextBox;
    }
}


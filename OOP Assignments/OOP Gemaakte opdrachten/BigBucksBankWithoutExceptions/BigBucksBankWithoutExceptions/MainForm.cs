using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBucksBankWithoutExceptions
{
    public partial class MainForm : Form
    {
        private Account account;

        public MainForm()
        {
            InitializeComponent();
            groupBox4.Enabled = false;
            account = null;
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            decimal initialBalance;
            try
            {
                initialBalance = Convert.ToDecimal(initialBalanceTextBox.Text);
                account = new Account(nameTextBox.Text, initialBalance);
                groupBox4.Enabled = true;
                ShowAccountInfo();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid information.");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please fill in information");
            }
            catch (NoInformationGivenExeption exeption) 
            {
                MessageBox.Show(exeption.Message);
            }
        }

        private void ShowAccountInfo()
        {
            nameInfoTextBox.Text = account.Name;
            maxDepthInfoTextBox.Text = account.MaxDebt.ToString();
            balanceInfoTextBox.Text = account.Balance.ToString();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            decimal amount;
            try
            {
                amount = Convert.ToDecimal(depositAmountTextBox.Text);
                account.Deposit(amount);
                ShowAccountInfo();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid information.");
            }
        }

        private void withDrawButton_Click(object sender, EventArgs e)
        {
            decimal amount;
            try
            {
                amount = Convert.ToDecimal(withdrawAmountTextBox.Text);
                account.Withdraw(amount);
                ShowAccountInfo();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid information.");
            }
            catch (NotEnoughMoneyExeption exeption) 
            {
                MessageBox.Show(exeption.Message);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please fill in information");
            }
        }
    }
}

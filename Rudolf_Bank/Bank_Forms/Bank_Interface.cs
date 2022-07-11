using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rudolf_Bank.Bank_Forms
{
    public partial class Bank_Interface : Form
    {
        private string _login;
        private string _password;

        private Bank_Logic _bank_Logic;

        public Bank_Interface(string login, string password)
        {
            InitializeComponent();

            _login = login;
            _password = password;

            TextBox_Welcome.Text = $"Добро пожаловать {login}";
            _bank_Logic = new Bank_Logic();
        }

        private void Button_Take_Click(object sender, EventArgs e)
        {
            Button_Take_Accept.Visible = true;
            TextBox_Take.Visible = true;
        }

        private void Button_Deposite_Click(object sender, EventArgs e)
        {
            TextBox_Deposite_Nominal.Visible = true;
            TextBox_Deposite_Count.Visible = true;
            Button_Deposite_Accept.Visible = true;
            Label_Deposite_Nominal.Visible = true;
            Label_Deposite_Count.Visible = true;
        }

        private void Button_Balance_Click(object sender, EventArgs e)
        {
            TextBox_Balance.Visible = true;
            TextBox_Balance.Clear();
            TextBox_Balance.Text = _bank_Logic.BalanceOnCard().ToString();
        }

        private void Button_Deposite_Accept_Click(object sender, EventArgs e)
        {
            string Deposite_Nominal = TextBox_Deposite_Nominal.Text;
            string Deposite_Count = TextBox_Deposite_Count.Text;

            if (string.IsNullOrEmpty(Deposite_Nominal) || string.IsNullOrEmpty(Deposite_Count) || Convert.ToInt32(Deposite_Nominal) == 0 || Convert.ToInt32(Deposite_Count) == 0)
            {
                MessageBox.Show("Неверно указан депозит", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int Deposite_Nominal_INT = Convert.ToInt32(Deposite_Nominal);
                int Deposite_Count_INT = Convert.ToInt32(Deposite_Count);
                if (!_bank_Logic.DepositeOnCard(Deposite_Nominal_INT, Deposite_Count_INT))
                {
                    MessageBox.Show("Неверно указан депозит", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Button_Take_Accept_Click(object sender, EventArgs e)
        {
            string cash_out = TextBox_Take.Text;
            
            
            if (string.IsNullOrEmpty(cash_out) || Convert.ToInt32(cash_out) == 0)
            {
                MessageBox.Show("Неверно указана сумма", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int cash_output = Convert.ToInt32(cash_out);
                _bank_Logic.TakeCash(cash_output);
                MessageBox.Show($"Вы сняли {cash_out}", "Снятие средств", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TextBox_Take_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

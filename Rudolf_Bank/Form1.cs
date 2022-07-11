using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rudolf_Bank.Bank_Forms;

namespace Rudolf_Bank
{
    public partial class Form1 : Form
    {
        private string _login = "admin";
        private string _password = "admin";

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_LogOn_Click(object sender, EventArgs e)
        {
            string login = TextBox_Login.Text;
            string password = TextBox_Password.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || (_login != login) || (_password != password))
            {
                MessageBox.Show("Неверно указан логин/пароль", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                new Bank_Interface(login, password).Show();
            }
        }
    }
}

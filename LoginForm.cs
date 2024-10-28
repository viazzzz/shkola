using System;
using System.Windows.Forms;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string password = txtPassword.Text;

        if (СервисПользователей.Вход(username, password))
        {
            MessageBox.Show("Вход выполнен успешно!");
            var mainForm = new MainForm();
            this.Hide(); // Скрываем форму входа
            mainForm.ShowDialog(); // Открываем главную форму
            this.Close(); // Закрываем форму входа после завершения работы главной формы
        }
        else
        {
            MessageBox.Show("Неверное имя пользователя или пароль!");
        }
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        // Открываем форму регистрации
        var registrationForm = new RegistrationForm();
        registrationForm.ShowDialog();
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
        // Включаем режим маскирования для пароля
        txtPassword.PasswordChar = '•';
    }

    private void txtPassword_TextChanged(object sender, EventArgs e)
    {

    }
}

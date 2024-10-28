using System;
using System.Windows.Forms;

public partial class RegistrationForm : Form
{
    public RegistrationForm()
    {
        InitializeComponent();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string password = txtPassword.Text;

        if (СервисПользователей.Регистрация(username, password))
        {
            MessageBox.Show("Пользователь успешно зарегистрирован!");
            this.Close(); // Закрываем форму регистрации после успешной регистрации
        }
        else
        {
            MessageBox.Show("Имя пользователя уже существует!");
        }
    }

    private void RegistrationForm_Load(object sender, EventArgs e)
    {
        // Включаем режим маскирования для пароля
        txtPassword.PasswordChar = '•';
    }
}

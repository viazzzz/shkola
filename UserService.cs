// Services/UserService.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public static class СервисПользователей
{
    private static string filePath = "users.txt"; // Файл для хранения пользователей
    private static Dictionary<string, string> пользователи = new Dictionary<string, string>();

    static СервисПользователей()
    {
        ЗагрузитьПользователей(); // Загружаем пользователей при инициализации сервиса
    }

    // Метод для входа
    public static bool Вход(string имяПользователя, string пароль)
    {
        ЗагрузитьПользователей(); // Обновляем пользователей перед проверкой
        string hashedPassword = ХэшироватьПароль(пароль); // Хэшируем введённый пароль
        return пользователи.TryGetValue(имяПользователя, out var storedPassword) && storedPassword == hashedPassword;
    }

    // Метод для регистрации
    public static bool Регистрация(string имяПользователя, string пароль)
    {
        if (!пользователи.ContainsKey(имяПользователя))
        {
            string hashedPassword = ХэшироватьПароль(пароль); // Хэшируем пароль при регистрации
            пользователи[имяПользователя] = hashedPassword;
            СохранитьПользователей(); // Сохраняем после регистрации
            return true;
        }
        return false;
    }

    private static void ЗагрузитьПользователей()
    {
        пользователи.Clear(); // Очищаем список пользователей перед загрузкой
        if (File.Exists(filePath))
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 2)
                {
                    пользователи[parts[0]] = parts[1]; // Загружаем имя и пароль
                }
            }
        }
    }

    private static void СохранитьПользователей()
    {
        var lines = new List<string>();
        foreach (var user in пользователи)
        {
            lines.Add($"{user.Key},{user.Value}");
        }
        File.WriteAllLines(filePath, lines); // Записываем всех пользователей в файл
    }

    // Метод для хэширования паролей с использованием SHA256
    private static string ХэшироватьПароль(string пароль)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(пароль));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2")); // Преобразуем байты в строку
            }
            return builder.ToString();
        }
    }
}

# Универсальные шаблоны WinForms + SQL Server

Этот файл нужен как быстрая шпаргалка для экзаменационных задач, где база данных меняется, но логика написания кода остаётся почти одинаковой.

## 1. Универсальный шаблон авторизации

Используй этот шаблон, когда нужно сделать форму входа почти для любой базы данных.

```csharp
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace MyApp
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=ИМЯ_СЕРВЕРА;Database=ИМЯ_БАЗЫ;Integrated Security=True;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM ТАБЛИЦА_ПОЛЬЗОВАТЕЛЕЙ WHERE ПОЛЕ_ЛОГИНА = @login AND ПОЛЕ_ПАРОЛЯ = @password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Form2 form2 = new Form2();
                            form2.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль");
                        }
                    }
                }
            }
        }
    }
}
```

## 2. Универсальный шаблон загрузки карточек

Используй этот шаблон, когда записи нужно выводить в `FlowLayoutPanel`.

```csharp
private void LoadData(string query)
{
    flowLayoutPanel1.Controls.Clear();

    using (SqlConnection conn = new SqlConnection(connectionString))
    {
        conn.Open();

        using (SqlCommand cmd = new SqlCommand(query, conn))
        using (SqlDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                UserControl1 card = new UserControl1();

                card.SetData(
                    reader["ПОЛЕ_1"].ToString(),
                    reader["ПОЛЕ_2"].ToString(),
                    reader["ПОЛЕ_3"].ToString(),
                    reader["ПОЛЕ_4"].ToString()
                );

                flowLayoutPanel1.Controls.Add(card);
            }
        }
    }
}
```

## 3. Универсальная загрузка данных при открытии формы

```csharp
private void Form2_Load(object sender, EventArgs e)
{
    string query = "SELECT * FROM ИМЯ_ТАБЛИЦЫ";
    LoadData(query);
}
```

Если в задаче таблицы связаны между собой, вместо простого `SELECT` нужно писать запрос с `JOIN`.

## 4. Универсальный шаблон поиска

```csharp
private void textBoxSearch_TextChanged(object sender, EventArgs e)
{
    string search = textBoxSearch.Text.Trim();
    string query = "SELECT * FROM ИМЯ_ТАБЛИЦЫ";

    if (!string.IsNullOrEmpty(search))
        query += " WHERE ПОЛЕ_ПОИСКА LIKE '%" + search + "%'";

    LoadData(query);
}
```

Логика:

1. взять текст из поля поиска
2. убрать пробелы через `Trim()`
3. если строка не пустая, добавить `WHERE ... LIKE`
4. заново загрузить карточки

## 5. Универсальный шаблон сортировки

```csharp
private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
{
    string query = "SELECT * FROM ИМЯ_ТАБЛИЦЫ";

    if (comboBoxSort.SelectedIndex == 0)
        query += " ORDER BY ПОЛЕ_СОРТИРОВКИ ASC";
    else if (comboBoxSort.SelectedIndex == 1)
        query += " ORDER BY ПОЛЕ_СОРТИРОВКИ DESC";

    LoadData(query);
}
```

Логика:

- `ASC` — по возрастанию
- `DESC` — по убыванию

## 6. Универсальный шаблон фильтрации

```csharp
private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
{
    string query = "SELECT * FROM ИМЯ_ТАБЛИЦЫ";

    if (comboBoxFilter.SelectedIndex == 0)
        query += " WHERE ПОЛЕ_ФИЛЬТРА = 'ЗНАЧЕНИЕ_1'";
    else if (comboBoxFilter.SelectedIndex == 1)
        query += " WHERE ПОЛЕ_ФИЛЬТРА = 'ЗНАЧЕНИЕ_2'";

    LoadData(query);
}
```

Логика:

- `WHERE` оставляет только подходящие строки
- обычно фильтруют по статусу, категории, роли, типу, наличию или диапазону цены

## 7. Что меняется от одной экзаменационной задачи к другой

Обычно меняются только:

- строка подключения
- названия таблиц
- названия столбцов
- текст, который выводится в карточке
- значения фильтрации
- поле сортировки
- поле поиска

Сама логика программирования остаётся той же.

## 8. Быстрая памятка перед экзаменом

Когда видишь новую базу данных, сначала ответь на эти вопросы:

1. Какая таблица используется для входа?
2. Какие поля являются логином и паролем?
3. Какая таблица содержит данные каталога?
4. Какие поля нужно показывать в карточке?
5. По какому полю делать поиск?
6. По какому полю делать сортировку?
7. По какому полю делать фильтрацию?
8. Нужен простой `SELECT` или запрос с `JOIN`?

## 9. Главная мысль

На экзамене не нужно заново изобретать код под каждую новую базу.

Нужно помнить один и тот же каркас:

- получить данные
- проверить данные
- подключиться к БД
- выполнить запрос
- прочитать строки
- создать карточки
- добавить карточки на форму
- отдельно подключить поиск, сортировку и фильтрацию

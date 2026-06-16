using Microsoft.Data.SqlClient;

namespace UniversityAppDemo;

public partial class Form1 : Form
{
    private readonly string connectionString =
        @"Server=(localdb)\MSSQLLocalDB;Database=university;Integrated Security=True;TrustServerCertificate=True";

    public Form1()
    {
        InitializeComponent();
        textBox2.UseSystemPasswordChar = true;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string login = textBox1.Text.Trim();
        string password = textBox2.Text.Trim();

        if (login == "" || password == "")
        {
            MessageBox.Show(
                "Оба поля должны быть заполнены!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        using SqlConnection conn = new(connectionString);
        conn.Open();

        string query = """
            SELECT *
            FROM Students
            WHERE email = @login AND idStudens = @password
            """;

        using SqlCommand sqlCommand = new(query, conn);
        sqlCommand.Parameters.AddWithValue("@login", login);
        sqlCommand.Parameters.AddWithValue("@password", password);

        using SqlDataReader reader = sqlCommand.ExecuteReader();
        if (reader.Read())
        {
            MessageBox.Show(
                "Добро пожаловать!",
                "Авторизация прошла успешно",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Form2 mainForm = new();
            mainForm.Show();
            Hide();
        }
        else
        {
            MessageBox.Show(
                "Неправильный логин или пароль",
                "Ошибка авторизации",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}

using Microsoft.Data.SqlClient;

namespace UniversityAppDemo;

public partial class Form2 : Form
{
    private readonly string connection =
        @"Server=(localdb)\MSSQLLocalDB;Database=university;Integrated Security=True;TrustServerCertificate=True";

    public Form2()
    {
        InitializeComponent();
    }

    private void Form2_Load(object sender, EventArgs e)
    {
        flowLayoutPanel1.Controls.Clear();

        using SqlConnection conn = new(connection);
        conn.Open();

        string query = """
            SELECT TOP 500
                Students.fullNameStudens,
                Discipline.nameDiscipline,
                Teacher.fullNameTeacher,
                FufilmentOfTasks.Status,
                FufilmentOfTasks.mark,
                FufilmentOfTasks.description
            FROM FufilmentOfTasks
            INNER JOIN Students
                ON FufilmentOfTasks.idStudents = Students.idStudens
            INNER JOIN Task
                ON FufilmentOfTasks.idTask = Task.idTask
            INNER JOIN Discipline
                ON Task.idDiscipline = Discipline.idDiscipline
            INNER JOIN Teacher
                ON Discipline.idTeacher = Teacher.idTeacher
            INNER JOIN Session
                ON FufilmentOfTasks.idSession = Session.idSession
            """;

        using SqlCommand sql = new(query, conn);
        using SqlDataReader reader = sql.ExecuteReader();

        while (reader.Read())
        {
            UserControl1 userControl = new();

            string fullNameStudents = reader["fullNameStudens"].ToString() ?? "";
            string nameDiscipline = reader["nameDiscipline"].ToString() ?? "";
            string fullNameTeacher = reader["fullNameTeacher"].ToString() ?? "";
            string status = reader["Status"].ToString() ?? "";
            string mark = reader["mark"].ToString() ?? "";
            string description = reader["description"].ToString() ?? "";

            if (mark == "")
            {
                mark = "Нет оценки";
            }

            userControl.Card(
                fullNameStudents,
                nameDiscipline,
                fullNameTeacher,
                status,
                mark,
                description);

            flowLayoutPanel1.Controls.Add(userControl);
        }
    }
}

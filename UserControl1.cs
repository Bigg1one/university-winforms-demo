namespace UniversityAppDemo;

public partial class UserControl1 : UserControl
{
    public UserControl1()
    {
        InitializeComponent();
    }

    public void Card(
        string fullNameStudents,
        string nameDiscipline,
        string fullNameTeacher,
        string status,
        string mark,
        string description)
    {
        label1.Text = fullNameStudents;
        label3.Text = nameDiscipline;
        label5.Text = fullNameTeacher;
        label7.Text = status;
        label9.Text = mark;
        label11.Text = description;
    }
}

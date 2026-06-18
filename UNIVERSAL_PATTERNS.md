# Universal WinForms + SQL Patterns

This file is a quick adaptation guide for exam tasks where the database changes, but the coding logic stays almost the same.

## 1. Universal authorization pattern

Use this when you need a login form for almost any database.

```csharp
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace MyApp
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=SERVER_NAME;Database=DATABASE_NAME;Integrated Security=True;TrustServerCertificate=True";

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
                MessageBox.Show("Fill in all fields");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM USERS_TABLE WHERE LOGIN_COLUMN = @login AND PASSWORD_COLUMN = @password";

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
                            MessageBox.Show("Invalid login or password");
                        }
                    }
                }
            }
        }
    }
}
```

## 2. Universal card loading pattern

Use this when records must be displayed inside a `FlowLayoutPanel`.

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
                    reader["COLUMN_1"].ToString(),
                    reader["COLUMN_2"].ToString(),
                    reader["COLUMN_3"].ToString(),
                    reader["COLUMN_4"].ToString()
                );

                flowLayoutPanel1.Controls.Add(card);
            }
        }
    }
}
```

## 3. Universal base load

```csharp
private void Form2_Load(object sender, EventArgs e)
{
    string query = "SELECT * FROM TABLE_NAME";
    LoadData(query);
}
```

If the task has related tables, replace it with a query using `JOIN`.

## 4. Universal search pattern

```csharp
private void textBoxSearch_TextChanged(object sender, EventArgs e)
{
    string search = textBoxSearch.Text.Trim();
    string query = "SELECT * FROM TABLE_NAME";

    if (!string.IsNullOrEmpty(search))
        query += " WHERE SEARCH_COLUMN LIKE '%" + search + "%'";

    LoadData(query);
}
```

Logic:

1. read search text
2. trim spaces
3. if text exists, add `WHERE ... LIKE`
4. reload cards

## 5. Universal sorting pattern

```csharp
private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
{
    string query = "SELECT * FROM TABLE_NAME";

    if (comboBoxSort.SelectedIndex == 0)
        query += " ORDER BY SORT_COLUMN ASC";
    else if (comboBoxSort.SelectedIndex == 1)
        query += " ORDER BY SORT_COLUMN DESC";

    LoadData(query);
}
```

Logic:

- `ASC` = ascending
- `DESC` = descending

## 6. Universal filtering pattern

```csharp
private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
{
    string query = "SELECT * FROM TABLE_NAME";

    if (comboBoxFilter.SelectedIndex == 0)
        query += " WHERE FILTER_COLUMN = 'VALUE_1'";
    else if (comboBoxFilter.SelectedIndex == 1)
        query += " WHERE FILTER_COLUMN = 'VALUE_2'";

    LoadData(query);
}
```

Logic:

- `WHERE` keeps only matching rows
- common filters are category, status, role, type, price range, availability

## 7. What changes from one exam task to another

Usually only these parts change:

- connection string
- table names
- column names
- text shown in the card
- filter values
- sort column
- search column

The programming logic stays the same.

## 8. Fast exam checklist

When you see a new database, answer these questions first:

1. Which table is used for login?
2. Which columns are login and password?
3. Which table contains the catalog data?
4. Which columns must be shown on the card?
5. Which column should be searchable?
6. Which column should be sortable?
7. Which column should be filterable?
8. Do I need a simple `SELECT` or a `JOIN` query?

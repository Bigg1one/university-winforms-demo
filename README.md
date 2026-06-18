# UniversityAppDemo

Minimal WinForms demo for practice work with SQL Server and the `university` database.

## What is in the repository

- `Form1` - authorization form
- `Form2` - main form with data cards
- `UserControl1` - reusable card for showing a single record
- `UNIVERSAL_PATTERNS.md` - universal templates for adapting the same logic to another database

## What this project demonstrates

This repository shows the same core exam logic that appears in many practice tasks:

1. Read values from text boxes.
2. Validate that required fields are not empty.
3. Open a SQL Server connection.
4. Execute a query with `SqlCommand`.
5. Read data with `SqlDataReader`.
6. Show records in a `FlowLayoutPanel` through a `UserControl`.
7. Extend the catalog with search, sorting, and filtering.

## Current database used in the example

The sample project is wired to:

```csharp
Server=(localdb)\MSSQLLocalDB;Database=university;Integrated Security=True;TrustServerCertificate=True
```

If your exam machine uses another SQL Server instance or another database name, replace the connection string in:

- `Form1.cs`
- `Form2.cs`

## Authorization logic in this example

For the current `university` database the project uses:

- login = `email`
- password = `idStudens`

Example:

- `anna.ivanova@zaochnik.ru`
- `S001`

## How to adapt this code to another database

Usually only three things change:

1. Connection string
2. Table names
3. Column names

The logic stays the same.

### Universal Form1 logic

The authorization form always follows this pattern:

1. Get login and password from text boxes.
2. Check for empty values.
3. Connect to the database.
4. Execute a `SELECT` query.
5. If `reader.Read()` returns `true`, open `Form2`.
6. Otherwise show an error message.

### Universal Form2 logic

The main form always follows this pattern:

1. Build a query.
2. Open a connection.
3. Execute the query.
4. Read rows in `while (reader.Read())`.
5. Create a new `UserControl1`.
6. Pass values into the card method.
7. Add the card to `flowLayoutPanel1`.

### Universal search logic

- read text from `TextBox`
- use `Trim()`
- if not empty, add `WHERE ... LIKE '%text%'`

### Universal sorting logic

- read `SelectedIndex` from `ComboBox`
- add `ORDER BY Column ASC`
- or add `ORDER BY Column DESC`

### Universal filtering logic

- read `SelectedIndex` from `ComboBox`
- add `WHERE Column = 'Value'`

## Why there is a separate universal file

The repository code itself is tied to the sample `university` database.
The file `UNIVERSAL_PATTERNS.md` explains how to reuse the same coding logic for:

- students
- products
- books
- clients
- flowers
- any similar SQL-backed WinForms exam task

## Build

```bash
dotnet build
```

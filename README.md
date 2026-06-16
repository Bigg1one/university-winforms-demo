# UniversityAppDemo

Минимальный пример WinForms-приложения для практических работ по базе данных `university`.

Что есть в репозитории:

- `Form1` — авторизация по таблице `Students`
- `Form2` — главная форма с выводом карточек
- `UserControl1` — карточка записи о выполнении задания

Логика `Form1`:

- логин = `email`
- пароль = `idStudens`

Пример для входа:

- `anna.ivanova@zaochnik.ru`
- `S001`

Подключение по умолчанию:

```csharp
Server=(localdb)\MSSQLLocalDB;Database=university;Integrated Security=True;TrustServerCertificate=True
```

Если у вас другой экземпляр SQL Server, замените строку подключения в `Form1.cs` и `Form2.cs`.

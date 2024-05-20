using AllowanceApp.Data;
using System.Data.SQLite;

public class DatabaseHelper
{
    private const string ConnectionString = "Data Source=expenses.db;Version=3;";

    public DatabaseHelper()
    {
        InitializeDatabase();
    }

    private void InitializeDatabase()
    {
        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS Expenses (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    Description TEXT,
                    Amount REAL,
                    Date TEXT
                )";
            using (var command = new SQLiteCommand(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    public void InsertExpense(Expense expense)
    {
        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            string insertQuery = "INSERT INTO Expenses (Name, Description, Amount, Date) VALUES (@Name, @Description, @Amount, @Date)";
            using (var command = new SQLiteCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", expense.Name);
                command.Parameters.AddWithValue("@Description", expense.Description);
                command.Parameters.AddWithValue("@Amount", expense.Amount);
                command.Parameters.AddWithValue("@Date", expense.Date.ToString("yyyy-MM-dd"));
                command.ExecuteNonQuery();
            }
        }
    }

    public List<Expense> GetExpenses(DateTime startDate, DateTime endDate)
    {
        var expenses = new List<Expense>();
        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            string selectQuery = "SELECT Name, Description, Amount, Date FROM Expenses WHERE Date BETWEEN @StartDate AND @EndDate";
            using (var command = new SQLiteCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@StartDate", startDate.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@EndDate", endDate.ToString("yyyy-MM-dd"));
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var expense = new Expense
                        {
                            Name = reader["Name"].ToString(),
                            Description = reader["Description"].ToString(),
                            Amount = Convert.ToDecimal(reader["Amount"]),
                            Date = DateTime.Parse(reader["Date"].ToString())
                        };
                        expenses.Add(expense);
                    }
                }
            }
        }
        return expenses;
    }
}

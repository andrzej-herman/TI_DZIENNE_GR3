
using Quiz.Data;
using System.Data.SqlClient;
using System.Text.Json;

var connectionString = "Server=.\\HERMANLOCAL;Database=QuizDbDzienneGr3;Integrated Security=True;";
var path = "S:\\ZIMA 2024\\questions.json";
var json = File.ReadAllText(path);

// desarialzujemy plik json na listę pytań:
var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
var questions = JsonSerializer.Deserialize<List<Question>>(json);



var connection = new SqlConnection(connectionString);
connection.Open();
if (questions != null)
{
    var counter = 1;
    foreach (var question in questions!)
    {
        var properContent = question.Content!.Replace("'", "\"");
        string query = $"INSERT INTO Questions VALUES ({question.Category}, '{properContent}')";
        var command = new SqlCommand(query, connection);
        command.ExecuteNonQuery();
        Console.WriteLine($" Dodano pytanie nr {counter}");
        counter++;
       
    }
}

connection.Close();

Console.ReadLine();



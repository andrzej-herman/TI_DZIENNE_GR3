using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Quiz.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class QuizController : ControllerBase
	{
		public QuizController()
		{
	
		}

		[HttpGet]
		public string GetQuestion([FromQuery] int category)
		{
			return $"Daj pytanie za {category} pkt.";
		}

		
		[HttpPost]
		public string CheckAnswers([FromBody] int questionId, int answerId)
		{
			return $"Dobra odpowiedü";
        }

	}
}



// CONNECTION STRING

// PRZYK£AD
// "Server=myServerName\myInstanceName;Database=myDataBase;User Id=myUsername;Password=myPassword;"

// LOKALNA INSTANCJA
// "Server=.\\HERMANLOCAL;Database=QuizDbDzienneGr3;Integrated Security=True;"

// PRZYK£ADOWY CONNECTION STRING DO BAZY NA AZURE
// "Server=tcp:san-edu-pl.database.windows.net,1433;Initial Catalog=san;Persist Security Info=False;User ID=aherman;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"



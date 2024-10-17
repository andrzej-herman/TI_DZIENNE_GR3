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

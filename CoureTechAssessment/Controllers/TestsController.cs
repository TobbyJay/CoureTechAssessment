using CoureTechAssessment.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoureTechAssessment.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestsController : ControllerBase
	{
		private readonly ICalculatorService _calculatorService;
		private readonly ICountryService _countryService;
		public TestsController(ICalculatorService calculatorService, ICountryService countryService)
		{
			_calculatorService = calculatorService;
			_countryService = countryService;
		}

		[HttpPost("CalculateTotalScore")]
		public IActionResult CalculateTotalScore([FromBody] int[] numbers) 
		{
			var totalScore = _calculatorService.CalculateTotalScore(numbers);
			return Ok(totalScore);
		}
		
		[HttpGet("PhoneNumberInfo")]
		public IActionResult PhoneNumberInfo([FromQuery] string phoneNumber) 
		{
			var response = _countryService.GetCountriesInfo(phoneNumber);
			return Ok(response);
		}
	}
}

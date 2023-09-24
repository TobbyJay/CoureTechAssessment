using CoureTechAssessment.Application.Implementations;
using CoureTechAssessment.Application.Interfaces;
using CoureTechAssessment.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CoureTechAssessment.Extensions
{
	public static class ServiceExtensions
	{
		public static void ConfigureServices(this IServiceCollection services)
		{
			services.AddScoped<ICalculatorService, CalculatorService>();
			services.AddScoped<ICountryService, CountryService>();
		}
		
		public static void ConfigureInMemoryDB(this IServiceCollection services)
		{
			services.AddDbContext<AppDbContext>(options =>
			{
				options.UseInMemoryDatabase(databaseName: "InMemoryDb");
			});
		}
	}
}

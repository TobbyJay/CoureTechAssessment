using CoureTechAssessment.Application.DTOs;
using CoureTechAssessment.Application.Helpers;
using CoureTechAssessment.Application.Interfaces;
using CoureTechAssessment.Domain;
using CoureTechAssessment.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoureTechAssessment.Application.Implementations
{
	public class CountryService : ICountryService
	{
		private readonly AppDbContext _context;
		public CountryService(AppDbContext context)
		{
			_context = context;
		}
		public ApiResponseDTO<object> GetCountriesInfo(string phoneNumber)
		{
			var countryCode = PhoneNumberUtilityHelper.ExtractCountryCode(phoneNumber);

			// Fetch country details
			var country = _context.Countries
				.Include(c => c.CountryDetails)
				.FirstOrDefault(c => c.CountryCode == countryCode);

			if (country == null)
				  return new ApiResponseDTO<object> { Status = 404, Message = "Country not found for the given country code", Data = country };

			var response = MapCountriesInfo(phoneNumber, country);
		
			return new ApiResponseDTO<object> { Status = 200, Message = "Info retrieved successfully", Data = response };
		}
		private object MapCountriesInfo(string phoneNumber, Country country)
		{
			return new
			{
				number = phoneNumber,
				country = new
				{
					countryCode = country.CountryCode.ToString(),
					name = country.Name,
					countryIso = country.CountryIso,
					countryDetails = country.CountryDetails
						.Select(d => new
						{
							operatorName = d.Operator,
							operatorCode = d.OperatorCode
						})
						.ToList()
				}
			};
		}		
	}
}

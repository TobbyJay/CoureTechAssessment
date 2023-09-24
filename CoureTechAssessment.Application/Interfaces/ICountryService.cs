using CoureTechAssessment.Application.DTOs;
using CoureTechAssessment.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoureTechAssessment.Application.Interfaces
{
	public interface ICountryService
	{
		ApiResponseDTO<object> GetCountriesInfo(string phoneNumber);
	}
}

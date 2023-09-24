using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoureTechAssessment.Application.Helpers
{
	public class PhoneNumberUtilityHelper
	{
		public static string ExtractCountryCode(string phoneNumber)
		{
			string countryAndCode = phoneNumber.Split('-')[0];
			string countryCode = countryAndCode.Substring(0, 3);

			return countryCode;
		}
	}
}

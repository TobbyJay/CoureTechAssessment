using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoureTechAssessment.Application.Helpers
{
	public class CalculatorHelper
	{
		public static bool IsEven(int number)
		{
			return number % 2 == 0;
		}

		public static bool IsEight(int number)
		{
			return number == 8;
		}
	}
}

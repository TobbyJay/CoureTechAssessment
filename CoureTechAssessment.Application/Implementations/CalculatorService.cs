using CoureTechAssessment.Application.Helpers;
using CoureTechAssessment.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoureTechAssessment.Application.Implementations
{
	public class CalculatorService : ICalculatorService
	{
		public int CalculateTotalScore(int[] numbers)
		{
			var totalScore = 0;

			foreach (var number in numbers)
			{
				totalScore += CalculatorHelper.IsEven(number) ? 1 : 3;
				totalScore += CalculatorHelper.IsEight(number) ? 5 : 0;
			}
			return totalScore;
		}
	}
}

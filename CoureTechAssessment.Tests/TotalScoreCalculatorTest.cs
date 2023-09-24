using CoureTechAssessment.Application.Implementations;
using Xunit;

namespace CoureTechAssessment.Tests
{
	public class TotalScoreCalculatorTest
	{
		[Theory]
		[InlineData(new[] { 1, 2, 3, 4, 5, 8 }, 22)] // Input and expected result
		[InlineData(new[] { 1, 3, 5, 7 }, 12)]         // Another input and expected result
		[InlineData(new[] { 2, 4, 6, 8 }, 8)]          // Yet another input and expected result
		public void CalculateTotalScore_ShouldCalculateScoreCorrectly(int[] numbers, int expectedTotalScore)
		{
			// Arrange
			var scoreCalculator = new CalculatorService();

			// Act
			var totalScore = scoreCalculator.CalculateTotalScore(numbers);

			// Assert
			Assert.Equal(expectedTotalScore, totalScore);
		}
	}

}
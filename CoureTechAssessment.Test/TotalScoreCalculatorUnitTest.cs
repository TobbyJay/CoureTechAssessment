using CoureTechAssessment.Application.Implementations;

namespace CoureTechAssessment.Test
{
	public class TotalScoreCalculatorUnitTest
	{

		[Theory]
		[InlineData(new[] { 1, 2, 3, 4, 5 }, 11)]
		[InlineData(new[] { 15, 25 ,35 }, 9)] 
		[InlineData(new[] { 8,8}, 12)]
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
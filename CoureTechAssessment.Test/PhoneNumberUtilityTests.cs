using CoureTechAssessment.Application.Helpers;

namespace CoureTechAssessment.Test
{
	public class PhoneNumberUtilityTests
	{

		[Theory]
		[InlineData("234-1234567890", "234")]
		[InlineData("225-1234567890", "225")]
		[InlineData("2331234567890", "233")]
		[InlineData("2291234567890", "229")]
		public void ExtractCountryCode_ShouldReturnCorrectResult(string phoneNumber, string expectedCountryCode)
		{
			// Act
			string actualCountryCode = PhoneNumberUtilityHelper.ExtractCountryCode(phoneNumber);

			// Assert
			Assert.Equal(expectedCountryCode, actualCountryCode);
		}
	}
}
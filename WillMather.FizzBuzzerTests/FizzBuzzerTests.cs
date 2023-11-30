using NUnit.Framework;
using WillMather.FizzBuzz;

namespace WillMather.FizzBuzzerTests;

[TestFixture]
public class FizzBuzzerTests
{
    [TestCase(1, "1")]
    public void FizzBuzzer_GivenIntInput_ReturnsExpectedString(int input, string expected)
    {
        // Arrange
        FizzBuzzer fizzbuzzer = new FizzBuzzer();

        // Act
        string actual = fizzbuzzer.RunFzzBuzz(input);
        
        // Assert
        Assert.Equals(expected, actual);
    }
}

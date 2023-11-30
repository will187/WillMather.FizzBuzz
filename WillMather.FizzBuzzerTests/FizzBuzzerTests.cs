using NUnit.Framework;
using WillMather.FizzBuzz;

namespace WillMather.FizzBuzzerTests;

[TestFixture]
public class FizzBuzzerTests
{
    [TestCase(1, "1")]
    [TestCase(2, "2")]
    public void FizzBuzzer_GivenIntInput_ReturnsExpectedString(int input, string expected)
    {
        // Arrange
        FizzBuzzer fizzbuzzer = new FizzBuzzer();

        // Act
        string actual = fizzbuzzer.RunFzzBuzz(input);
        
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

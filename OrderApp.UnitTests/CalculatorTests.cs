using NUnit.Framework;

namespace OrderApp.UnitTests;

public class CalculatorTests
{
    [Test]
    public void CalculateBrutto_WhenValueIs100AndTaxis20_ShouldReturn120()
    {
        Calculator calculator = new Calculator();

        var result = calculator.CalculateBrutto(100, 20);

        Assert.AreEqual(120, result);
    }
}

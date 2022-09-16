namespace OrderApp;

public class Calculator
{
    public double CalculateBrutto(double value, int tax)
    {
        return value + value * tax/100;
    }
}

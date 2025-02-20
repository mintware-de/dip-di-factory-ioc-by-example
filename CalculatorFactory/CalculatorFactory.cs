using Contracts;

namespace CalculatorFactory;

public class CalculatorFactory
{
    public static IRouteCalculator Create()
    {
        return new RouteCalculator.RouteCalculator();
    }
}
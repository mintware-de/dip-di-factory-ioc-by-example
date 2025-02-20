namespace RouteCalculator;

public class RouteCalculator : IRouteCalculator
{
    public void CalculateRoute(string start, string destination)
    {
        Console.WriteLine($"Calculating the trip from {start} to {destination}.");
        // Do stuff for calculating the route...
    }
}
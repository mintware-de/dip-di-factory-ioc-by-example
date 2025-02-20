using Contracts;

namespace TripPlanner;

public class TripPlanner
{
    private readonly IRouteCalculator _routeCalculator;

    private readonly Gps _gps = new Gps();

    public TripPlanner()
    {
        _routeCalculator = CalculatorFactory.CalculatorFactory.Create();
    }

    public void PlanTripFromCurrentLocation(string destination)
    {
        var currentLocation = _gps.CurrentLocation;
        _routeCalculator.CalculateRoute(currentLocation, destination);
    }
}
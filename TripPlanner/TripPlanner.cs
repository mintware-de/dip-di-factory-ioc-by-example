using Contracts;

namespace TripPlanner;

public class TripPlanner
{
    private readonly IRouteCalculator _routeCalculator;

    private readonly Gps _gps;

    public TripPlanner(IRouteCalculator routeCalculator, Gps gps)
    {
        _routeCalculator = routeCalculator;
        _gps = gps;
    }

    public void PlanTripFromCurrentLocation(string destination)
    {
        var currentLocation = _gps.CurrentLocation;
        _routeCalculator.CalculateRoute(currentLocation, destination);
    }
}
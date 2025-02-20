using Contracts;

namespace TripPlanner;

public class TripPlanner
{
    private readonly IRouteCalculator _routeCalculator = new RouteCalculator.RouteCalculator();

    private readonly Gps _gps = new Gps();

    public void PlanTripFromCurrentLocation(string destination)
    {
        var currentLocation = _gps.CurrentLocation;
        _routeCalculator.CalculateRoute(currentLocation, destination);
    }
}
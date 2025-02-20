namespace TripPlanner;

public class TripPlanner
{
    private readonly RouteCalculator.RouteCalculator _routeCalculator = new RouteCalculator.RouteCalculator();

    private readonly Gps _gps = new Gps();

    public void PlanTripFromCurrentLocation(string destination)
    {
        var currentLocation = _gps.CurrentLocation;
        _routeCalculator.CalculateRoute(currentLocation, destination);
    }
}
using TripPlanner;

var routeCalculator = new RouteCalculator.RouteCalculator();
var gps = new Gps();

var planner = new TripPlanner.TripPlanner(routeCalculator, gps);

planner.PlanTripFromCurrentLocation("Panoramastraße 1, 10178 Berlin");
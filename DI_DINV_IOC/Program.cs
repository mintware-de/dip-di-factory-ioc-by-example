using Contracts;
using Microsoft.Extensions.DependencyInjection;
using TripPlanner;

var provider = new DefaultServiceProviderFactory().CreateServiceProvider(
    new ServiceCollection()
        .AddSingleton<Gps>()
        .AddTransient<RouteCalculator.RouteCalculator>()
        .AddSingleton<IRouteCalculator>(p => p.GetService<RouteCalculator.RouteCalculator>()!)
        .AddTransient<TripPlanner.TripPlanner>()
);

var planner = provider.GetService<TripPlanner.TripPlanner>()!;

planner.PlanTripFromCurrentLocation("Panoramastraße 1, 10178 Berlin");
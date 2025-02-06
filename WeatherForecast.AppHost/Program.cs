var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.WeatherForecast_ApiService>("apiservice");

builder.AddProject<Projects.WeatherForecast_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();

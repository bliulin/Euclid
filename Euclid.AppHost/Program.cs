var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Euclid_ApiService>("apiservice");

builder.AddProject<Projects.Euclid_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();

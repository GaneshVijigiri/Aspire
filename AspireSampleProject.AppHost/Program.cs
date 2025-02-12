using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<AspireWebApp>("AspireWebApp");
builder.AddNpmApp("Frontend", "../aspireuiapp", "dev").WithExternalHttpEndpoints().WaitFor(apiService);

builder.Build().Run();

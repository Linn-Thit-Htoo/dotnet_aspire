var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.dotnet_aspire_BlogMicroservice>("dotnet-aspire-blogmicroservice");

builder.AddProject<Projects.dotnet_aspire_ProductMicroservice>("dotnet-aspire-productmicroservice");

builder.Build().Run();

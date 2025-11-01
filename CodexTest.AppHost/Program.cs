using Aspire.Hosting;
using CodexTest.ServiceDefaults;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.AddProject<Projects.CodexTest_Api>("api");

builder.Build().Run();

using SmartTaskandTimeTrackingSystem.Api;
using SmartTaskandTimeTrackingSystem.DataAccess.Extension;
using SmartTaskandTimeTrackingSystem.Shared.Extensions;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCommonServiceExt(typeof(TaskAssembly));
builder.Services.AddDataAccessDependency(builder.Configuration.GetConnectionString("sqlCon")!);

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}


app.Run();


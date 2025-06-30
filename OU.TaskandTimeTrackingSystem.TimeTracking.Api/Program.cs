using OU.TaskandTimeTrackingSystem.TimeTracking.Api;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Extension;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry;
using SmartTaskandTimeTrackingSystem.Shared.Extensions;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCommonServiceExt(typeof(TimeTrackingAssembly));
builder.Services.AddDataAccessDependcy(builder.Configuration.GetConnectionString("postgreSql")!);

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

app.AddTimeEntryGroupEndpointExt();
app.BreakPeriodGroupEndpointExt();

app.Run();



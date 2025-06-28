using SmartTaskandTimeTrackingSystem.Api;
using SmartTaskandTimeTrackingSystem.Api.Enpoints.Category;
using SmartTaskandTimeTrackingSystem.Bussiness.Extension;
using SmartTaskandTimeTrackingSystem.DataAccess.Extension;
using SmartTaskandTimeTrackingSystem.DataAccess.Repositories.Concretes;
using SmartTaskandTimeTrackingSystem.DataAccess.Repositories.Interfaces;
using SmartTaskandTimeTrackingSystem.Shared.Extensions;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCommonServiceExt(typeof(TaskAssembly));
builder.Services.AddDataAccessDependency(builder.Configuration.GetConnectionString("sqlCon")!);
builder.Services.AddBussinessDependency();


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

app.AddCategoryGroupEndpointExt();


app.Run();


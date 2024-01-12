using NannoA_MiniChallengeTwoToFour_Endpoints.Services.AddService;
using NannoA_MiniChallengeTwoToFour_Endpoints.Services.CompNumService;
using NannoA_MiniChallengeTwoToFour_Endpoints.Services.TwoQuestionService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAddService, AddService>();
builder.Services.AddScoped<ITwoQuestionService, TwoQuestionService>();
builder.Services.AddScoped<ICompNumService, CompNumService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

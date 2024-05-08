var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else {app.UseHttpsRedirection();}
 //later will use own ssl certificate to route this



// app.MapGet("/weatherforecast", () =>
// {

    
// }) //delegate functionality should use this name when creating controllers in other script
// .WithName("GetWeatherForecast")
// .WithOpenApi();
app.MapControllers();
app.Run();


#region Build Section

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

#endregion


#region Application Section

var app = builder.Build();

app.MapControllers();

app.Run();

#endregion


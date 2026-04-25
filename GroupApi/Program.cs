using GroupApi.Aplacation.InterfaceServies;
using GroupApi.Aplacation.Servies;
using GroupApi.Doamin.Interfais;
using GroupApi.Infrastructure.Repotisory;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

// Регистрация зависимостей
builder.Services.AddScoped<IFirebaseAuth, FireBaseAuthRepotisorycs>();
builder.Services.AddScoped<IFirebaseAuthServies, FirebaseAuthSerivsecs>();
builder.Services.AddScoped<IFirebaseTokenRepotisory, FireBaseTokenRepotisiory>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

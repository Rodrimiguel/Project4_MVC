var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default", // PODEMOS TENER VARIAS CONFIGURACIONES / VARIAS CON DISTINTAS NOMBRES
    // VIENE POR DEFAULT (POR DEFECTO)
    pattern: "{controller=Home}/{action=Index}/{id?}"); //PATRON QUE MANEJA EL ENRUTAMIENTO (CONTROLADOR / ACTION/ EL PARAMETRO) 
    // CONTROLADOR POR DEFECTO SE LLAMA HOME, ACTION POR DEFECTO DE LLAMA INDEX.
    // CUANDO CARQUE NUESTRA APLICACION VA A BUSCAR EL CONTROLADOR HOME  Y VA TRATAR DE EJECUTAR LA ACCION INDEX .
    // CUAL ES EL ¿HOME? EL QUE NOS CREA POR DEFECTO.

app.Run();

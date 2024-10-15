internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("PermitirTodasOrigem", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            });
        });

        builder.Services.AddAuthorization();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseHttpsRedirection();
        app.UseCors("PermitirTodasOrigem");
        app.UseAuthorization();
        app.MapControllers();
        app.MapGet("/", () => "API de Gerenciamento de Produtos");
        app.Run();
    }
}

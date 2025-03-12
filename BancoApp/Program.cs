
using BancoApp.Services;
using DB;
using Microsoft.EntityFrameworkCore;


namespace BancoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddCors(options =>
			{
				options.AddPolicy("AllowAll", builder =>
				{
					builder.AllowAnyOrigin()
						   .AllowAnyMethod()
						   .AllowAnyHeader();
				});
			});

			builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
			builder.Services.AddScoped<ITransactionService, TransactionService>();

			builder.Services.AddDbContext<BancoContext>(options =>
				options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

			var app = builder.Build();

			/*using (var scope = app.Services.CreateScope())
			{
				var context = scope.ServiceProvider.GetRequiredService<BancoContext>();
				context.Database.Migrate();
			}*/

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
			app.UseCors("AllowAll");


			app.MapControllers();

            app.Run();
        }
    }
}

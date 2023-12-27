using Identity.Api.Configurations;
using Identity.Application.Common.Identity.Services;
using Identity.Persistence.DataContexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

await builder.ConfigureAsync();

var app = builder.Build();

await app.ConfigureAsync();

//var scope = app.Services.CreateScope().ServiceProvider;

//var dbContext = scope.GetRequiredService<IdentityDbContext>();
//var tokenGeneratorService = scope.GetRequiredService<ITokenGeneratorService>();
//var passwordHasherService = scope.GetRequiredService<IPasswordHasherService>();

//var adminPassword = passwordHasherService.HashPassword("AdminTest_1");
//var guestPassword = passwordHasherService.HashPassword("GuestTest_1");

//var user = await dbContext.Users.Include(user => user.Role).OrderBy(user => user.Id).FirstOrDefaultAsync();
//var token = tokenGeneratorService.GetToken(user);

await app.RunAsync();
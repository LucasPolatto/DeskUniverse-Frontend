using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using DeskUniverse_Frontend;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5041") });

builder.Services.AddSingleton<UserService>();
builder.Services.AddSingleton<CharacterService>();
builder.Services.AddSingleton<CampaignService>();
builder.Services.AddSingleton<ItemService>();
builder.Services.AddSingleton<SkillService>();
builder.Services.AddSingleton<ImageService>();
builder.Services.AddSingleton<BoardService>();
builder.Services.AddSingleton<TokenService>();


await builder.Build().RunAsync();

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FinanzasMamaApp;
using Supabase;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var url = "https://oqcugkwqsakjdrzoakpu.supabase.co";
var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Im9xY3Vna3dxc2FramRyem9ha3B1Iiwicm9sZSI6ImFub24iLCJpYXQiOjE3NzkyMDc5MTMsImV4cCI6MjA5NDc4MzkxM30.283tOvUSB48GRWexANwASymuLzhXsTekDF_RR7Fi27M";

var options = new SupabaseOptions
{
    AutoConnectRealtime = false
};

var supabase = new Client(url, key, options);
await supabase.InitializeAsync();

builder.Services.AddSingleton(supabase);

builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
    });

await builder.Build().RunAsync();

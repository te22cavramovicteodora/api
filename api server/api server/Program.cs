var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Urls.Add("http://localhost:5167");
app.Urls.Add("http://*:5167");

app.MapGet("/", GetMe);
app.MapGet("/orb", GetAlso);
app.MapGet("/graa", GetTedoror);
app.MapGet("/hello", SayHello);

app.Run();

static void SayHello(string message)
{
    Console.WriteLine(message);
}

static teacher GetTedoror()
{
    teacher tedorora = new() { Name = "tedorora"};
    return tedorora; 
}

static string GetAlso()
{
    return "hej tedorora";
}

static string GetMe()
{
    return "Hello world!";
}

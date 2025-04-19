using syncronousDemo.Services;

var builder = WebApplication.CreateBuilder(args);

// Register ProductService with HttpClient
builder.Services.AddHttpClient<IProductService, ProductService>();

builder.Services.AddControllers()
    .AddNewtonsoftJson(); // Optional if you use Newtonsoft for deserialization

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();
app.MapControllers();
app.Run();

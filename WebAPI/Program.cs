using Business.Abstracts;
using Business.Concretes;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Singleton-Scoped-Transient -> Lifetime
// Singleton => Üretilen bağımlılık uygulama açık olduðu sürece tek bir kere newlenir. 
// Her enjeksiyonda o instance kullanılır.

// Scoped => (API isteği) İstek başına 1 instance oluþturur.

// Transient => Her adımda (her talepte) yeni 1 instance.
builder.Services.AddSingleton<IProductService, ProductManager>();
builder.Services.AddSingleton<ICategoryService, CategoryManager>(); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

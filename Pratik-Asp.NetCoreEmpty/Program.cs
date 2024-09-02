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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

// Controller: Uygulaman�n i� mant���n� ve veri i�lemlerini y�neten s�n�ft�r. Kullan�c�n�n iste�ine g�re model ile etkile�ime ge�er ve uygun g�r�n�m� (view) d�ner.

// Action: Bir controller i�erisindeki bir metottur. Kullan�c�n�n iste�ine yan�t olarak belirli bir i�levi yerine getirir ve genellikle bir view d�ner.

// Model: Uygulaman�n veri yap�s�n� ve i� mant���n� temsil eder. Veritaban� ile etkile�ime ge�mek ve verileri saklamak i�in kullan�l�r.

// View: Kullan�c�ya sunulan aray�zd�r. Controller taraf�ndan g�nderilen verileri kullan�c�ya g�rsel olarak sunar. Genellikle Razor �ablonlar� ile olu�turulur.

// Razor: ASP.NET Core'da dinamik HTML i�eri�i olu�turmak i�in kullan�lan bir �ablon motorudur. C# kodu ve HTML'yi birle�tirerek dinamik i�erikler olu�turur.

// RazorView: Razor motoru taraf�ndan i�lenen ve HTML ��kt�s� �reten bir view'dir. Controller taraf�ndan verilerle birlikte i�lenir ve sonu� olarak kullan�c�ya sunulur.

// wwwroot: Statik dosyalar�n (CSS, JavaScript, resimler vb.) sakland��� klas�rd�r. Taray�c�lar bu dosyalara do�rudan eri�ebilir.

// builder.Build(): Uygulama yap�land�rmas�n� tamamlar ve bir WebApplication nesnesi olu�turur. Bu nesne, uygulaman�n �al��ma zaman�ndaki yap�land�rmas�n� temsil eder.

// app.Run(): Uygulamay� ba�lat�r ve HTTP isteklerini dinlemeye ba�lar. Bu metod �a�r�ld���nda uygulama �al���r ve gelen istekleri i�leyebilir.

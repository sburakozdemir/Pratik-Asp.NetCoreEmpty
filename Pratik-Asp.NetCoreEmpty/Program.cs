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

// Controller: Uygulamanýn iþ mantýðýný ve veri iþlemlerini yöneten sýnýftýr. Kullanýcýnýn isteðine göre model ile etkileþime geçer ve uygun görünümü (view) döner.

// Action: Bir controller içerisindeki bir metottur. Kullanýcýnýn isteðine yanýt olarak belirli bir iþlevi yerine getirir ve genellikle bir view döner.

// Model: Uygulamanýn veri yapýsýný ve iþ mantýðýný temsil eder. Veritabaný ile etkileþime geçmek ve verileri saklamak için kullanýlýr.

// View: Kullanýcýya sunulan arayüzdür. Controller tarafýndan gönderilen verileri kullanýcýya görsel olarak sunar. Genellikle Razor þablonlarý ile oluþturulur.

// Razor: ASP.NET Core'da dinamik HTML içeriði oluþturmak için kullanýlan bir þablon motorudur. C# kodu ve HTML'yi birleþtirerek dinamik içerikler oluþturur.

// RazorView: Razor motoru tarafýndan iþlenen ve HTML çýktýsý üreten bir view'dir. Controller tarafýndan verilerle birlikte iþlenir ve sonuç olarak kullanýcýya sunulur.

// wwwroot: Statik dosyalarýn (CSS, JavaScript, resimler vb.) saklandýðý klasördür. Tarayýcýlar bu dosyalara doðrudan eriþebilir.

// builder.Build(): Uygulama yapýlandýrmasýný tamamlar ve bir WebApplication nesnesi oluþturur. Bu nesne, uygulamanýn çalýþma zamanýndaki yapýlandýrmasýný temsil eder.

// app.Run(): Uygulamayý baþlatýr ve HTTP isteklerini dinlemeye baþlar. Bu metod çaðrýldýðýnda uygulama çalýþýr ve gelen istekleri iþleyebilir.

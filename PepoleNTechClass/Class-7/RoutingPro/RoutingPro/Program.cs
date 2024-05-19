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
    name: "students",
    pattern: "student/{org}/{course}/{batchno}",
    defaults: new { controller = "Course", action = "StdList" }
    );


app.MapControllerRoute(
    name: "article",
    pattern: "news/{year}/{month}/{day}/{pageno}",
    defaults: new { controller = "News", action = "Page" }
    );

app.MapControllerRoute(
    name: "article",
    pattern: "news/{year}/{month}/{day}/{pageno}/{contentId}",
    defaults: new { controller = "News", action = "Article" }
    );



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

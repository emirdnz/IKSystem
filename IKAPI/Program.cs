using Ik.Bl.Abstract;
using Ik.Bl.Concrete;
using Ik.Dal.Abstract;
using Ik.Dal.Concrete;
using Ik.Dal.Context;
using IKAPI.AutoMapperProfile;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<IKDB>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));


// Add services to the container.
builder.Services.AddControllersWithViews();



builder.Services.AddScoped<ICompanyManager, CompanyManager>();
builder.Services.AddScoped<IEmployeeManager, EmployeeManager>();
builder.Services.AddScoped<IExpenseManager, ExpenseManager>();
builder.Services.AddScoped<IHolidayEventManager, HolidayEventManager>();
builder.Services.AddScoped<ILeaveRequestManager, LeaveRequestManager>();
builder.Services.AddScoped<ILoggingManager, LoggingManager>();  
builder.Services.AddScoped<IReportManager, ReportManager>();
builder.Services.AddScoped<IResumeManager, ResumeManager>();
builder.Services.AddScoped<IRoleManager, RoleManager>();    
builder.Services.AddScoped<ISettingsManager, SettingsManager>();
builder.Services.AddScoped<IUserManager, UserManager>();

builder.Services.AddAutoMapper(typeof(IKProfile));




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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

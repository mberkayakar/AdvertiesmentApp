var builder = WebApplication.CreateBuilder(args);

#region Services 
builder.Services.AddControllersWithViews(); // MVC için eklendi.

#endregion 


var app = builder.Build();

#region Middlewares     

if(app.Environment.IsDevelopment()){
    
    app.UseDeveloperExceptionPage(); // Development modunda developer exception page kısmı gözüksün diye eklenmiş bir yapıdır
}   
else {
 // Costume exception page kısmı gözükecek
}   

app.UseHsts(); // Http yönlendirmesi için konulmaktadır. 

app.UseRouting();

app.UseEndpoints(endpoints => endpoints.MapControllerRoute( 
    name : "default", 
    pattern: "{Areas=Vistor}/{Controller=Home}/{Action=Index}/{id?}")); // varsayılanda bişi denmezse visitor index gözüksün 


#endregion

app.Run();
